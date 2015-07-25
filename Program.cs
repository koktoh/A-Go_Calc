using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace A_Go_Calc
{
	/// <summary>
	/// Windows API にアクセスするための静的クラスです。
	/// </summary>
	public static class WindowsAPI
	{
		/// <summary>
		/// ShowWindow Commands 定数を列挙型にしたものです。
		/// VC\PratformSDK\Includes\winuser.h を参考にしました。
		/// </summary>
		public enum ShowWindowEnum : int
		{
			SW_HIDE = 0,
			SW_NORMAL = 1,
			SW_SHOWMINIMIZED = 2,
			SW_MAXIMIZE = 3,
			SW_SHOWNOACTIVATE = 4,
			SW_SHOW = 5,
			SW_MINIMIZE = 6,
			SW_SHOWMINNOACTIVE = 7,
			SW_SHOWNA = 8,
			SW_RESTORE = 9,
			SW_SHOWDEFAULT = 10,
			SW_MAX = 11
		}

		/// <summary>
		/// 最前面に表示されるウィンドウを指定する Windows API です。
		/// </summary>
		/// <param name="hWnd">対象となるウィンドウハンドルです。</param>
		/// <returns>正常に終了した場合に true が返ります。</returns>
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		/// <summary>
		/// ウィンドウの状態を変更する Windows API です。
		/// </summary>
		/// <param name="hWnd">対象となるウィンドウハンドルです。</param>
		/// <param name="nCmdShow">ウィンドウの状態を示す ShowWindowEnum 列挙子です。</param>
		/// <returns>設定前にウィンドウが可視状態だった場合に true が返ります。</returns>
		[DllImport("user32.dll")]
		public static extern bool ShowWindowAsync(IntPtr hWnd, ShowWindowEnum nCmdShow);

		/// <summary>
		/// 指定したウィンドウが最小化されているかどうかを判定する Windows API です。
		/// </summary>
		/// <param name="hWnd">対象となるウィンドウハンドルです。</param>
		/// <returns>ウィンドウが最小化に設定されている場合に true が返ります。</returns>
		[DllImport("user32.dll")]
		public static extern bool IsIconic(IntPtr hWnd);
	}

	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			System.Threading.Mutex mutex = new System.Threading.Mutex(false, "A-Go_Calc");

			if (mutex.WaitOne(0, false))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());

				mutex.ReleaseMutex();
			}
			else
			{
				if (!WakeupWindow())
					System.Windows.Forms.MessageBox.Show("あ号進行度計算機は起動しています");
			}
		}



		/// <summary>
		/// プロセス名とプログラム名が同一のプロセスを見つけ、
		/// それが所持しているメインウィンドウを前面に表示します。
		/// </summary>
		/// <returns>正常にウィンドウを前面に表示できた場合に true を返します。</returns>
		static bool WakeupWindow()
		{
			bool result;

			System.Diagnostics.Process current;
			System.Diagnostics.Process[] running;

			System.Diagnostics.Process target = null;

			// 現在アクティブなプロセスを取得します。
			current = System.Diagnostics.Process.GetCurrentProcess();

			// 稼働中のプロセスから、アクティブなプロセスと同一のプロセス名を持つプロセスを取得します。
			running = System.Diagnostics.Process.GetProcessesByName(current.ProcessName);

			// 自分自身を除外しつつ、自分以外の同一プログラムのプロセスを target に取得します。
			foreach (System.Diagnostics.Process proc in running)
			{
				// プロセス ID が自分自身とは異なるものを探します。
				if (proc.Id != current.Id)
				{
					// 捜査中のプロセスが、アクティブなプロセスと同一ファイル名であるかどうかを調べます。
					if (proc.MainModule.FileName == current.MainModule.FileName)
					{
						// ファイル名が一致した場合は、それが目的のプロセスとなります。
						target = proc;
						break;
					}
				}
			}

			// 該当するプロセスが見つかった場合の操作です。
			if (target != null)
			{
				// ウィンドウが最小化されていた場合には、それを元に戻します。
				if (WindowsAPI.IsIconic(target.MainWindowHandle)) WindowsAPI.ShowWindowAsync(target.MainWindowHandle, WindowsAPI.ShowWindowEnum.SW_RESTORE);

				// ウィンドウを前面に移動します。
				result = WindowsAPI.SetForegroundWindow(target.MainWindowHandle);
			}
			else
			{
				// 該当するプロセスが見つからなかった場合には false を返させます。
				result = false;
			}

			return result;
		}
	}
}
