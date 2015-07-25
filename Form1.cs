using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace A_Go_Calc
{
	public partial class Form1 : Form
	{
		string savePath;

		private DataGridViewCellStyle defaultCellStyle;
		private DataGridViewCellStyle selectionCellStyle;

		private int displayedRowStart = 0;
		private int displayedRowLength = 0;

		private int attackCounter = 0;

		public Form1()
		{
			InitializeComponent();

			savePath = Application.StartupPath;

			defaultCellStyle = new DataGridViewCellStyle();

			selectionCellStyle = new DataGridViewCellStyle();
			selectionCellStyle.BackColor = Color.Aqua;

			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			
			setColumn();

			this.MaximumSize = new Size(357, Screen.GetBounds(this).Height);
			this.MinimumSize = new Size(357, 300);

			loadSetting();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			checkDisplayedRange();
			loadData();
			changeSelectionColor();
			checkDisplayedRange();
			checkDisplayed();
			calcProgress();
		}

		private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			saveData();
			saveSetting();
		}

		private void Form1_SizeChanged(object sender, System.EventArgs e)
		{
			checkDisplayedRange();
		}

		private void Form1_LocationChanged(object sender, System.EventArgs e)
		{
			this.MaximumSize = new Size(357, Screen.GetBounds(this).Height);
		}

		private void changeSelectionColor()
		{
			for (int i = 0; i < 4; i++)
				dataGridView1.Rows[attackCounter].Cells[i].Style = selectionCellStyle;
		}

		private void changeDefaultColor()
		{
			for (int i = 0; i < 4; i++)
				dataGridView1.Rows[attackCounter].Cells[i].Style = defaultCellStyle;
		}

		private void checkDisplayedRange()
		{
			bool displayedStartFixed = false;

			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				if (dataGridView1.Rows[i].Displayed && !displayedStartFixed)
				{
					displayedRowStart = i;
					displayedStartFixed = true;
				}

				if (displayedStartFixed && !dataGridView1.Rows[i].Displayed)
				{
					displayedRowLength = i - displayedRowStart - 1;
					break;
				}
			}
		}

		private void checkDisplayed()
		{
			while (displayedRowStart > attackCounter || attackCounter >= displayedRowStart + displayedRowLength)
			{
				displayedRowStart++;
				dataGridView1.FirstDisplayedScrollingRowIndex = displayedRowStart;
			}
		}

		private void attackButton_Click(object sender, EventArgs e)
		{
			doAttack();
		}

		private void bossButton_Click(object sender, EventArgs e)
		{
			doOther(1);
		}

		private void bossWinButton_Click(object sender, EventArgs e)
		{
			doOther(2);
		}

		private void sWinButton_Click(object sender, EventArgs e)
		{
			doOther(3);
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.A:
					doAttack();
					break;
				case Keys.S:
					doOther(1);
					break;
				case Keys.D:
					doOther(2);
					break;
				case Keys.F:
					doOther(3);
					break;
			}
		}

		private void doAttack()
		{
			if (attackCounter >= 99)
				return;

			changeDefaultColor();

			attackCounter++;

			for (int i = 1; i < 4; i++)
				dataGridView1.Rows[attackCounter].Cells[i].Value = dataGridView1.Rows[attackCounter - 1].Cells[i].Value;

			checkDisplayed();

			changeSelectionColor();

			calcProgress();
		}

		private void doOther(int cellNum)
		{
			int i = int.Parse(dataGridView1.Rows[attackCounter].Cells[cellNum].Value.ToString()) + 1;

			dataGridView1.Rows[attackCounter].Cells[cellNum].Value = i.ToString();

			calcProgress();
		}

		private void setColumn()
		{
			for (int i = 0; i < 100; i++)
			{
				if (dataGridView1.Rows.Count <= 0)
				{
					for (int t = 0; t < 4; t++)
					{
						DataGridViewTextBoxColumn initColumn = new DataGridViewTextBoxColumn();

						initColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						initColumn.ReadOnly = true;
						initColumn.Resizable = DataGridViewTriState.False;

						dataGridView1.Columns.Add(initColumn);
					}
				}
				else
				{
					dataGridView1.Rows.Add();
				}
			}

			for (int i = 0; i < 100; i++)
			{
				for (int t = 0; t < 4; t++)
				{
					if (t == 0)
					{
						dataGridView1.Rows[i].Cells[t].Value = i + 1;
					}
					else
					{
						dataGridView1.Rows[i].Cells[t].Value = 0;
					}
				}
			}
		}

		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			e.PaintParts &= ~DataGridViewPaintParts.Focus;
			e.PaintParts &= ~DataGridViewPaintParts.SelectionBackground;
		}

		private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
		{
			dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = false;
		}

		private void calcProgress()
		{
			double attackTimes = double.Parse(dataGridView1.Rows[attackCounter].Cells[0].Value.ToString());
			double bossTimes = double.Parse(dataGridView1.Rows[attackCounter].Cells[1].Value.ToString());
			double bossWinTimes = double.Parse(dataGridView1.Rows[attackCounter].Cells[2].Value.ToString());
			double sWinTimes = double.Parse(dataGridView1.Rows[attackCounter].Cells[3].Value.ToString());

			if (attackTimes > 36)
				attackTimes = 36;

			if (bossTimes > 24)
				bossTimes = 24;

			if (bossWinTimes > 12)
				bossWinTimes = 12;

			if (sWinTimes > 6)
				sWinTimes = 6;

			double attackProgress = attackTimes / 36 * 100;
			double bossProgress = bossTimes / 24 * 100;
			double bossWinProgress = bossWinTimes / 12 * 100;
			double sWinProgress = sWinTimes / 6 * 100;
			double wholeProgress = attackProgress * 0.25 + bossProgress * 0.25 + bossWinProgress * 0.25 + sWinProgress * 0.25;

			attackProgressLabel.Text = ((int)attackProgress).ToString() + "%";
			attackProgressBar.Value = (int)attackProgress;
			bossProgressLabel.Text = ((int)bossProgress).ToString() + "%";
			bossProgressBar.Value = (int)bossProgress;
			bossWinProgressLabel.Text = ((int)bossWinProgress).ToString() + "%";
			bossWinProgressBar.Value = (int)bossWinProgress;
			sWinProgressLabel.Text = ((int)sWinProgress).ToString() + "%";
			sWinProgressBar.Value = (int)sWinProgress;
			wholeProgressLabel.Text = ((int)wholeProgress).ToString() + "%";
			wholeProgressBar.Value = (int)wholeProgress;
		}

		private void loadData()
		{
			if (!File.Exists(savePath + "\\data.csv"))
				return;

			DateTime now = DateTime.Now;
			int dow = (int)now.DayOfWeek;
			if (dow == 0) dow = 7;
			now = now.AddDays(1 - dow);
			if (now < new DateTime(now.Year, now.Month, now.Day, 5, 0, 0))
				now.AddDays(-7);
			now = new DateTime(now.Year, now.Month, now.Day, 5, 0, 0);

			DateTime createTime = File.GetCreationTime(savePath + "\\data.csv");

			if (createTime < now)
			{
				File.Copy(savePath + "data.csv", savePath + "old_data.csv", true);
				File.Delete(savePath + "\\data.csv");
				File.Create(savePath + "\\data.csv");
				File.SetCreationTime(savePath + "\\data.csv", DateTime.Now);
				return;
			}

			StreamReader sr = new StreamReader(savePath + "\\data.csv", Encoding.UTF8);

			while (!sr.EndOfStream)
			{
				string[] str = sr.ReadLine().Split(',');

				dataGridView1.Rows[attackCounter].Cells[1].Value = str[1];
				dataGridView1.Rows[attackCounter].Cells[2].Value = str[2];
				dataGridView1.Rows[attackCounter].Cells[3].Value = str[3];

				attackCounter++;
			}

			attackCounter--;

			sr.Close();
		}

		private void saveData()
		{
			StreamWriter sw = new StreamWriter(savePath + "\\data.csv", false, Encoding.UTF8);

			for (int i = 0; i <= attackCounter; i++)
			{
				sw.WriteLine(i + 1 + "," + dataGridView1.Rows[i].Cells[1].Value + "," + dataGridView1.Rows[i].Cells[2].Value + "," + dataGridView1.Rows[i].Cells[3].Value);
			}

			sw.Close();
		}

		private void loadSetting()
		{
			this.Location = new Point(Properties.Settings.Default.WindowPositionX, Properties.Settings.Default.WindowPositionY);
		}

		private void saveSetting()
		{
			Properties.Settings.Default.WindowPositionX = this.Location.X;
			Properties.Settings.Default.WindowPositionY = this.Location.Y;
			Properties.Settings.Default.Save();
		}
	}
}
