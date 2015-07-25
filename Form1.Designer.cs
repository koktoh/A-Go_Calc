namespace A_Go_Calc
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.attackButton = new System.Windows.Forms.Button();
			this.bossButton = new System.Windows.Forms.Button();
			this.bossWinButton = new System.Windows.Forms.Button();
			this.sWinButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.attackProgressBar = new System.Windows.Forms.ProgressBar();
			this.bossProgressBar = new System.Windows.Forms.ProgressBar();
			this.bossWinProgressBar = new System.Windows.Forms.ProgressBar();
			this.sWinProgressBar = new System.Windows.Forms.ProgressBar();
			this.attackProgressLabel = new System.Windows.Forms.Label();
			this.bossProgressLabel = new System.Windows.Forms.Label();
			this.bossWinProgressLabel = new System.Windows.Forms.Label();
			this.sWinProgressLabel = new System.Windows.Forms.Label();
			this.wholeProgressBar = new System.Windows.Forms.ProgressBar();
			this.wholeProgressLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ColumnHeadersVisible = false;
			this.dataGridView1.Location = new System.Drawing.Point(14, 88);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(315, 335);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "36回";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// attackButton
			// 
			this.attackButton.Location = new System.Drawing.Point(12, 12);
			this.attackButton.Name = "attackButton";
			this.attackButton.Size = new System.Drawing.Size(75, 23);
			this.attackButton.TabIndex = 2;
			this.attackButton.Text = "出撃";
			this.attackButton.UseVisualStyleBackColor = true;
			this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
			// 
			// bossButton
			// 
			this.bossButton.Location = new System.Drawing.Point(93, 12);
			this.bossButton.Name = "bossButton";
			this.bossButton.Size = new System.Drawing.Size(75, 23);
			this.bossButton.TabIndex = 3;
			this.bossButton.Text = "ボス到達";
			this.bossButton.UseVisualStyleBackColor = true;
			this.bossButton.Click += new System.EventHandler(this.bossButton_Click);
			// 
			// bossWinButton
			// 
			this.bossWinButton.Location = new System.Drawing.Point(174, 12);
			this.bossWinButton.Name = "bossWinButton";
			this.bossWinButton.Size = new System.Drawing.Size(75, 23);
			this.bossWinButton.TabIndex = 4;
			this.bossWinButton.Text = "ボス勝利";
			this.bossWinButton.UseVisualStyleBackColor = true;
			this.bossWinButton.Click += new System.EventHandler(this.bossWinButton_Click);
			// 
			// sWinButton
			// 
			this.sWinButton.Location = new System.Drawing.Point(255, 12);
			this.sWinButton.Name = "sWinButton";
			this.sWinButton.Size = new System.Drawing.Size(75, 23);
			this.sWinButton.TabIndex = 5;
			this.sWinButton.Text = "S勝利";
			this.sWinButton.UseVisualStyleBackColor = true;
			this.sWinButton.Click += new System.EventHandler(this.sWinButton_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(93, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "24回";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(174, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "12回";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(255, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "6回";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// attackProgressBar
			// 
			this.attackProgressBar.Location = new System.Drawing.Point(12, 53);
			this.attackProgressBar.Name = "attackProgressBar";
			this.attackProgressBar.Size = new System.Drawing.Size(75, 17);
			this.attackProgressBar.TabIndex = 9;
			// 
			// bossProgressBar
			// 
			this.bossProgressBar.Location = new System.Drawing.Point(93, 53);
			this.bossProgressBar.Name = "bossProgressBar";
			this.bossProgressBar.Size = new System.Drawing.Size(75, 17);
			this.bossProgressBar.TabIndex = 10;
			// 
			// bossWinProgressBar
			// 
			this.bossWinProgressBar.Location = new System.Drawing.Point(174, 53);
			this.bossWinProgressBar.Name = "bossWinProgressBar";
			this.bossWinProgressBar.Size = new System.Drawing.Size(75, 17);
			this.bossWinProgressBar.TabIndex = 11;
			// 
			// sWinProgressBar
			// 
			this.sWinProgressBar.Location = new System.Drawing.Point(254, 53);
			this.sWinProgressBar.Name = "sWinProgressBar";
			this.sWinProgressBar.Size = new System.Drawing.Size(75, 17);
			this.sWinProgressBar.TabIndex = 12;
			// 
			// attackProgressLabel
			// 
			this.attackProgressLabel.Location = new System.Drawing.Point(12, 73);
			this.attackProgressLabel.Name = "attackProgressLabel";
			this.attackProgressLabel.Size = new System.Drawing.Size(75, 12);
			this.attackProgressLabel.TabIndex = 13;
			this.attackProgressLabel.Text = "0%";
			this.attackProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bossProgressLabel
			// 
			this.bossProgressLabel.Location = new System.Drawing.Point(93, 73);
			this.bossProgressLabel.Name = "bossProgressLabel";
			this.bossProgressLabel.Size = new System.Drawing.Size(75, 12);
			this.bossProgressLabel.TabIndex = 14;
			this.bossProgressLabel.Text = "0%";
			this.bossProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bossWinProgressLabel
			// 
			this.bossWinProgressLabel.Location = new System.Drawing.Point(172, 73);
			this.bossWinProgressLabel.Name = "bossWinProgressLabel";
			this.bossWinProgressLabel.Size = new System.Drawing.Size(75, 12);
			this.bossWinProgressLabel.TabIndex = 15;
			this.bossWinProgressLabel.Text = "0%";
			this.bossWinProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sWinProgressLabel
			// 
			this.sWinProgressLabel.Location = new System.Drawing.Point(253, 73);
			this.sWinProgressLabel.Name = "sWinProgressLabel";
			this.sWinProgressLabel.Size = new System.Drawing.Size(75, 12);
			this.sWinProgressLabel.TabIndex = 16;
			this.sWinProgressLabel.Text = "0%";
			this.sWinProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// wholeProgressBar
			// 
			this.wholeProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.wholeProgressBar.Location = new System.Drawing.Point(14, 429);
			this.wholeProgressBar.Name = "wholeProgressBar";
			this.wholeProgressBar.Size = new System.Drawing.Size(257, 23);
			this.wholeProgressBar.TabIndex = 17;
			// 
			// wholeProgressLabel
			// 
			this.wholeProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.wholeProgressLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.wholeProgressLabel.Location = new System.Drawing.Point(277, 429);
			this.wholeProgressLabel.Name = "wholeProgressLabel";
			this.wholeProgressLabel.Size = new System.Drawing.Size(53, 23);
			this.wholeProgressLabel.TabIndex = 18;
			this.wholeProgressLabel.Text = "0%";
			this.wholeProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 464);
			this.Controls.Add(this.wholeProgressLabel);
			this.Controls.Add(this.wholeProgressBar);
			this.Controls.Add(this.sWinProgressLabel);
			this.Controls.Add(this.bossWinProgressLabel);
			this.Controls.Add(this.bossProgressLabel);
			this.Controls.Add(this.attackProgressLabel);
			this.Controls.Add(this.sWinProgressBar);
			this.Controls.Add(this.bossWinProgressBar);
			this.Controls.Add(this.bossProgressBar);
			this.Controls.Add(this.attackProgressBar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.sWinButton);
			this.Controls.Add(this.bossWinButton);
			this.Controls.Add(this.bossButton);
			this.Controls.Add(this.attackButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "あ号進行度計算機";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button attackButton;
		private System.Windows.Forms.Button bossButton;
		private System.Windows.Forms.Button bossWinButton;
		private System.Windows.Forms.Button sWinButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar attackProgressBar;
		private System.Windows.Forms.ProgressBar bossProgressBar;
		private System.Windows.Forms.ProgressBar bossWinProgressBar;
		private System.Windows.Forms.ProgressBar sWinProgressBar;
		private System.Windows.Forms.Label attackProgressLabel;
		private System.Windows.Forms.Label bossProgressLabel;
		private System.Windows.Forms.Label bossWinProgressLabel;
		private System.Windows.Forms.Label sWinProgressLabel;
		private System.Windows.Forms.ProgressBar wholeProgressBar;
		private System.Windows.Forms.Label wholeProgressLabel;
	}
}

