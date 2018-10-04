namespace ColorTech.Forms {
	partial class CheckUpdateForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Logo = new System.Windows.Forms.PictureBox();
			this.LabelCurrentVersion = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnLoad = new System.Windows.Forms.Button();
			this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
			this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
			this.VersionChangelog = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelLastVersionValue = new System.Windows.Forms.Label();
			this.LabelLastVersion = new System.Windows.Forms.Label();
			this.LabelCurrentVersionValue = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.LabelStatus = new System.Windows.Forms.Label();
			this.TabPageCheckUpdate = new System.Windows.Forms.TabPage();
			this.LabelCheckUpdate = new System.Windows.Forms.Label();
			this.TabPageAvailableUpdate = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
			this.colorWithAlpha4 = new System.Windows.Forms.ColorWithAlpha();
			this.colorWithAlpha3 = new System.Windows.Forms.ColorWithAlpha();
			this.CheckBoxOpenUpdateWindow = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.TabPageCheckUpdate.SuspendLayout();
			this.TabPageAvailableUpdate.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.alphaGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Logo
			// 
			this.Logo.BackgroundImage = global::ColorTech.Properties.Resources.colortechlogo;
			this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Logo.Location = new System.Drawing.Point(5, 5);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(75, 75);
			this.Logo.TabIndex = 0;
			this.Logo.TabStop = false;
			// 
			// LabelCurrentVersion
			// 
			this.LabelCurrentVersion.AutoSize = true;
			this.LabelCurrentVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelCurrentVersion.Location = new System.Drawing.Point(3, 0);
			this.LabelCurrentVersion.Name = "LabelCurrentVersion";
			this.LabelCurrentVersion.Size = new System.Drawing.Size(111, 20);
			this.LabelCurrentVersion.TabIndex = 1;
			this.LabelCurrentVersion.Text = "Текущая версия: ";
			this.LabelCurrentVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(87, 227);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(200, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 3;
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnCancel.Location = new System.Drawing.Point(374, 227);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(74, 23);
			this.BtnCancel.TabIndex = 4;
			this.BtnCancel.Text = "Отмена";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnLoad
			// 
			this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnLoad.Location = new System.Drawing.Point(293, 227);
			this.BtnLoad.Name = "BtnLoad";
			this.BtnLoad.Size = new System.Drawing.Size(75, 23);
			this.BtnLoad.TabIndex = 5;
			this.BtnLoad.Text = "Обновить";
			this.BtnLoad.UseVisualStyleBackColor = true;
			this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
			// 
			// colorWithAlpha1
			// 
			this.colorWithAlpha1.Alpha = 255;
			this.colorWithAlpha1.Color = System.Drawing.SystemColors.Control;
			this.colorWithAlpha1.Parent = null;
			// 
			// colorWithAlpha2
			// 
			this.colorWithAlpha2.Alpha = 255;
			this.colorWithAlpha2.Color = System.Drawing.SystemColors.ControlDark;
			this.colorWithAlpha2.Parent = null;
			// 
			// VersionChangelog
			// 
			this.VersionChangelog.AutoScroll = true;
			this.VersionChangelog.BackColor = System.Drawing.Color.Transparent;
			this.VersionChangelog.BaseStylesheet = "* {\r\nfont-size:12px !important;\r\n}";
			this.VersionChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VersionChangelog.Location = new System.Drawing.Point(5, 18);
			this.VersionChangelog.Name = "VersionChangelog";
			this.VersionChangelog.Size = new System.Drawing.Size(348, 117);
			this.VersionChangelog.TabIndex = 7;
			this.VersionChangelog.Text = null;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5779F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.4221F));
			this.tableLayoutPanel1.Controls.Add(this.LabelLastVersionValue, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelLastVersion, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelCurrentVersionValue, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelCurrentVersion, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.65217F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.34783F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 46);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// LabelLastVersionValue
			// 
			this.LabelLastVersionValue.AutoSize = true;
			this.LabelLastVersionValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelLastVersionValue.Location = new System.Drawing.Point(120, 20);
			this.LabelLastVersionValue.Name = "LabelLastVersionValue";
			this.LabelLastVersionValue.Size = new System.Drawing.Size(238, 26);
			this.LabelLastVersionValue.TabIndex = 4;
			this.LabelLastVersionValue.Text = "0";
			this.LabelLastVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelLastVersion
			// 
			this.LabelLastVersion.AutoSize = true;
			this.LabelLastVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelLastVersion.Location = new System.Drawing.Point(3, 20);
			this.LabelLastVersion.Name = "LabelLastVersion";
			this.LabelLastVersion.Size = new System.Drawing.Size(111, 26);
			this.LabelLastVersion.TabIndex = 3;
			this.LabelLastVersion.Text = "Последняя версия: ";
			this.LabelLastVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelCurrentVersionValue
			// 
			this.LabelCurrentVersionValue.AutoSize = true;
			this.LabelCurrentVersionValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelCurrentVersionValue.Location = new System.Drawing.Point(120, 0);
			this.LabelCurrentVersionValue.Name = "LabelCurrentVersionValue";
			this.LabelCurrentVersionValue.Size = new System.Drawing.Size(238, 20);
			this.LabelCurrentVersionValue.TabIndex = 2;
			this.LabelCurrentVersionValue.Text = "0";
			this.LabelCurrentVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.VersionChangelog);
			this.groupBox1.Location = new System.Drawing.Point(87, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox1.Size = new System.Drawing.Size(358, 140);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Об обновлении";
			// 
			// LabelStatus
			// 
			this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LabelStatus.AutoSize = true;
			this.LabelStatus.Location = new System.Drawing.Point(84, 206);
			this.LabelStatus.Name = "LabelStatus";
			this.LabelStatus.Size = new System.Drawing.Size(135, 13);
			this.LabelStatus.TabIndex = 9;
			this.LabelStatus.Text = "Проверка на обновление";
			// 
			// TabPageCheckUpdate
			// 
			this.TabPageCheckUpdate.Controls.Add(this.LabelCheckUpdate);
			this.TabPageCheckUpdate.Location = new System.Drawing.Point(4, 25);
			this.TabPageCheckUpdate.Name = "TabPageCheckUpdate";
			this.TabPageCheckUpdate.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageCheckUpdate.Size = new System.Drawing.Size(454, 258);
			this.TabPageCheckUpdate.TabIndex = 1;
			this.TabPageCheckUpdate.Text = "Проверка на обновления";
			this.TabPageCheckUpdate.UseVisualStyleBackColor = true;
			// 
			// LabelCheckUpdate
			// 
			this.LabelCheckUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelCheckUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.LabelCheckUpdate.Location = new System.Drawing.Point(3, 3);
			this.LabelCheckUpdate.Name = "LabelCheckUpdate";
			this.LabelCheckUpdate.Padding = new System.Windows.Forms.Padding(10);
			this.LabelCheckUpdate.Size = new System.Drawing.Size(448, 252);
			this.LabelCheckUpdate.TabIndex = 0;
			this.LabelCheckUpdate.Text = "Проверка на обновления...";
			this.LabelCheckUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TabPageAvailableUpdate
			// 
			this.TabPageAvailableUpdate.Controls.Add(this.LabelStatus);
			this.TabPageAvailableUpdate.Controls.Add(this.progressBar1);
			this.TabPageAvailableUpdate.Controls.Add(this.BtnCancel);
			this.TabPageAvailableUpdate.Controls.Add(this.BtnLoad);
			this.TabPageAvailableUpdate.Controls.Add(this.Logo);
			this.TabPageAvailableUpdate.Controls.Add(this.groupBox1);
			this.TabPageAvailableUpdate.Controls.Add(this.tableLayoutPanel1);
			this.TabPageAvailableUpdate.Location = new System.Drawing.Point(4, 25);
			this.TabPageAvailableUpdate.Margin = new System.Windows.Forms.Padding(0);
			this.TabPageAvailableUpdate.Name = "TabPageAvailableUpdate";
			this.TabPageAvailableUpdate.Size = new System.Drawing.Size(454, 258);
			this.TabPageAvailableUpdate.TabIndex = 0;
			this.TabPageAvailableUpdate.Text = "Доступно обновление";
			this.TabPageAvailableUpdate.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl1.Controls.Add(this.TabPageCheckUpdate);
			this.tabControl1.Controls.Add(this.TabPageAvailableUpdate);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(462, 287);
			this.tabControl1.TabIndex = 10;
			// 
			// alphaGradientPanel1
			// 
			this.alphaGradientPanel1.BackColor = System.Drawing.Color.Transparent;
			this.alphaGradientPanel1.Border = false;
			this.alphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha4);
			this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha3);
			this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
			this.alphaGradientPanel1.Controls.Add(this.CheckBoxOpenUpdateWindow);
			this.alphaGradientPanel1.CornerRadius = 1;
			this.alphaGradientPanel1.Corners = System.Windows.Forms.Corner.None;
			this.alphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.alphaGradientPanel1.Gradient = true;
			this.alphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.alphaGradientPanel1.GradientOffset = 1F;
			this.alphaGradientPanel1.GradientSize = new System.Drawing.Size(0, 0);
			this.alphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
			this.alphaGradientPanel1.Grayscale = false;
			this.alphaGradientPanel1.Image = null;
			this.alphaGradientPanel1.ImageAlpha = 75;
			this.alphaGradientPanel1.ImagePadding = new System.Windows.Forms.Padding(5);
			this.alphaGradientPanel1.ImagePosition = System.Windows.Forms.ImagePosition.BottomRight;
			this.alphaGradientPanel1.ImageSize = new System.Drawing.Size(48, 48);
			this.alphaGradientPanel1.Location = new System.Drawing.Point(0, 287);
			this.alphaGradientPanel1.Name = "alphaGradientPanel1";
			this.alphaGradientPanel1.Rounded = false;
			this.alphaGradientPanel1.Size = new System.Drawing.Size(462, 50);
			this.alphaGradientPanel1.TabIndex = 11;
			// 
			// colorWithAlpha4
			// 
			this.colorWithAlpha4.Alpha = 255;
			this.colorWithAlpha4.Color = System.Drawing.SystemColors.ControlLight;
			this.colorWithAlpha4.Parent = this.alphaGradientPanel1;
			// 
			// colorWithAlpha3
			// 
			this.colorWithAlpha3.Alpha = 255;
			this.colorWithAlpha3.Color = System.Drawing.SystemColors.ControlDark;
			this.colorWithAlpha3.Parent = this.alphaGradientPanel1;
			// 
			// CheckBoxOpenUpdateWindow
			// 
			this.CheckBoxOpenUpdateWindow.Checked = true;
			this.CheckBoxOpenUpdateWindow.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxOpenUpdateWindow.Location = new System.Drawing.Point(9, 6);
			this.CheckBoxOpenUpdateWindow.Name = "CheckBoxOpenUpdateWindow";
			this.CheckBoxOpenUpdateWindow.Size = new System.Drawing.Size(225, 38);
			this.CheckBoxOpenUpdateWindow.TabIndex = 0;
			this.CheckBoxOpenUpdateWindow.Text = "Открывать данное окно при запуске (при наличии обновления)";
			this.CheckBoxOpenUpdateWindow.UseVisualStyleBackColor = true;
			// 
			// CheckUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 337);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.alphaGradientPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "CheckUpdateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Проверить обновления";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckUpdateForm_FormClosing);
			this.Load += new System.EventHandler(this.CheckUpdateForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.TabPageCheckUpdate.ResumeLayout(false);
			this.TabPageAvailableUpdate.ResumeLayout(false);
			this.TabPageAvailableUpdate.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.alphaGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Logo;
		private System.Windows.Forms.Label LabelCurrentVersion;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnLoad;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
		private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel VersionChangelog;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LabelLastVersionValue;
		private System.Windows.Forms.Label LabelLastVersion;
		private System.Windows.Forms.Label LabelCurrentVersionValue;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label LabelStatus;
		private System.Windows.Forms.TabPage TabPageCheckUpdate;
		private System.Windows.Forms.TabPage TabPageAvailableUpdate;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label LabelCheckUpdate;
		private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha4;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha3;
		private System.Windows.Forms.CheckBox CheckBoxOpenUpdateWindow;
	}
}