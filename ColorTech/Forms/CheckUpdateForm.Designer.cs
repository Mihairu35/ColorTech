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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation5 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckUpdateForm));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LabelCurrentVersion = new Krypton.Toolkit.KryptonLabel();
            this.progressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            this.BtnLoad = new Krypton.Toolkit.KryptonButton();
            this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
            this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
            this.VersionChangelog = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.tableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.LabelLastVersionValue = new Krypton.Toolkit.KryptonLabel();
            this.LabelLastVersion = new Krypton.Toolkit.KryptonLabel();
            this.LabelCurrentVersionValue = new Krypton.Toolkit.KryptonLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelStatus = new Krypton.Toolkit.KryptonLabel();
            this.TabPageCheckUpdate = new System.Windows.Forms.TabPage();
            this.LabelCheckUpdate = new Krypton.Toolkit.KryptonWrapLabel();
            this.TabPageAvailableUpdate = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
            this.colorWithAlpha4 = new System.Windows.Forms.ColorWithAlpha();
            this.colorWithAlpha3 = new System.Windows.Forms.ColorWithAlpha();
            this.BtnOK = new System.Windows.Forms.Button();
            this.CheckBoxOpenUpdateWindow = new System.Windows.Forms.CheckBox();
            this.animator1 = new AnimatorNS.Animator(this.components);
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
            this.animator1.SetDecoration(this.Logo, AnimatorNS.DecorationType.None);
            this.Logo.Location = new System.Drawing.Point(5, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(64, 64);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // LabelCurrentVersion
            // 
            this.animator1.SetDecoration(this.LabelCurrentVersion, AnimatorNS.DecorationType.None);
            this.LabelCurrentVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCurrentVersion.Location = new System.Drawing.Point(3, 3);
            this.LabelCurrentVersion.Name = "LabelCurrentVersion";
            this.LabelCurrentVersion.Size = new System.Drawing.Size(128, 14);
            this.LabelCurrentVersion.TabIndex = 1;
            this.LabelCurrentVersion.Values.Text = "Текущая версия: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animator1.SetDecoration(this.progressBar1, AnimatorNS.DecorationType.None);
            this.progressBar1.Location = new System.Drawing.Point(75, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.UseKrypton = true;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoad.CornerRoundingRadius = -1F;
            this.animator1.SetDecoration(this.BtnLoad, AnimatorNS.DecorationType.None);
            this.BtnLoad.Location = new System.Drawing.Point(369, 230);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 5;
            this.BtnLoad.Values.Text = "Обновить";
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
            this.animator1.SetDecoration(this.VersionChangelog, AnimatorNS.DecorationType.None);
            this.VersionChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionChangelog.Location = new System.Drawing.Point(5, 18);
            this.VersionChangelog.Name = "VersionChangelog";
            this.VersionChangelog.Size = new System.Drawing.Size(359, 120);
            this.VersionChangelog.TabIndex = 7;
            this.VersionChangelog.Text = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.92493F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.07507F));
            this.tableLayoutPanel1.Controls.Add(this.LabelLastVersionValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelLastVersion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelCurrentVersionValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelCurrentVersion, 0, 0);
            this.animator1.SetDecoration(this.tableLayoutPanel1, AnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.65217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.34783F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 46);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // LabelLastVersionValue
            // 
            this.animator1.SetDecoration(this.LabelLastVersionValue, AnimatorNS.DecorationType.None);
            this.LabelLastVersionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLastVersionValue.Location = new System.Drawing.Point(137, 23);
            this.LabelLastVersionValue.Name = "LabelLastVersionValue";
            this.LabelLastVersionValue.Size = new System.Drawing.Size(233, 20);
            this.LabelLastVersionValue.TabIndex = 4;
            this.LabelLastVersionValue.Values.Text = "0";
            // 
            // LabelLastVersion
            // 
            this.animator1.SetDecoration(this.LabelLastVersion, AnimatorNS.DecorationType.None);
            this.LabelLastVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLastVersion.Location = new System.Drawing.Point(3, 23);
            this.LabelLastVersion.Name = "LabelLastVersion";
            this.LabelLastVersion.Size = new System.Drawing.Size(128, 20);
            this.LabelLastVersion.TabIndex = 3;
            this.LabelLastVersion.Values.Text = "Последняя версия: ";
            // 
            // LabelCurrentVersionValue
            // 
            this.animator1.SetDecoration(this.LabelCurrentVersionValue, AnimatorNS.DecorationType.None);
            this.LabelCurrentVersionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCurrentVersionValue.Location = new System.Drawing.Point(137, 3);
            this.LabelCurrentVersionValue.Name = "LabelCurrentVersionValue";
            this.LabelCurrentVersionValue.Size = new System.Drawing.Size(233, 14);
            this.LabelCurrentVersionValue.TabIndex = 2;
            this.LabelCurrentVersionValue.Values.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.VersionChangelog);
            this.animator1.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(75, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(369, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Об обновлении";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.animator1.SetDecoration(this.LabelStatus, AnimatorNS.DecorationType.None);
            this.LabelStatus.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.LabelStatus.Location = new System.Drawing.Point(70, 207);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(156, 20);
            this.LabelStatus.TabIndex = 9;
            this.LabelStatus.Values.Text = "Проверка на обновление";
            // 
            // TabPageCheckUpdate
            // 
            this.TabPageCheckUpdate.Controls.Add(this.LabelCheckUpdate);
            this.animator1.SetDecoration(this.TabPageCheckUpdate, AnimatorNS.DecorationType.None);
            this.TabPageCheckUpdate.Location = new System.Drawing.Point(4, 22);
            this.TabPageCheckUpdate.Name = "TabPageCheckUpdate";
            this.TabPageCheckUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageCheckUpdate.Size = new System.Drawing.Size(454, 261);
            this.TabPageCheckUpdate.TabIndex = 1;
            this.TabPageCheckUpdate.Text = "Проверка на обновления";
            this.TabPageCheckUpdate.UseVisualStyleBackColor = true;
            // 
            // LabelCheckUpdate
            // 
            this.LabelCheckUpdate.AutoSize = false;
            this.animator1.SetDecoration(this.LabelCheckUpdate, AnimatorNS.DecorationType.None);
            this.LabelCheckUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCheckUpdate.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.LabelCheckUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.LabelCheckUpdate.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.LabelCheckUpdate.Location = new System.Drawing.Point(3, 3);
            this.LabelCheckUpdate.Name = "LabelCheckUpdate";
            this.LabelCheckUpdate.Size = new System.Drawing.Size(448, 255);
            this.LabelCheckUpdate.Text = "Проверка на обновления...";
            this.LabelCheckUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPageAvailableUpdate
            // 
            this.TabPageAvailableUpdate.Controls.Add(this.LabelStatus);
            this.TabPageAvailableUpdate.Controls.Add(this.progressBar1);
            this.TabPageAvailableUpdate.Controls.Add(this.BtnLoad);
            this.TabPageAvailableUpdate.Controls.Add(this.Logo);
            this.TabPageAvailableUpdate.Controls.Add(this.groupBox1);
            this.TabPageAvailableUpdate.Controls.Add(this.tableLayoutPanel1);
            this.animator1.SetDecoration(this.TabPageAvailableUpdate, AnimatorNS.DecorationType.None);
            this.TabPageAvailableUpdate.Location = new System.Drawing.Point(4, 22);
            this.TabPageAvailableUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.TabPageAvailableUpdate.Name = "TabPageAvailableUpdate";
            this.TabPageAvailableUpdate.Size = new System.Drawing.Size(454, 261);
            this.TabPageAvailableUpdate.TabIndex = 0;
            this.TabPageAvailableUpdate.Text = "Доступно обновление";
            this.TabPageAvailableUpdate.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageCheckUpdate);
            this.tabControl1.Controls.Add(this.TabPageAvailableUpdate);
            this.animator1.SetDecoration(this.tabControl1, AnimatorNS.DecorationType.None);
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
            this.alphaGradientPanel1.Controls.Add(this.BtnOK);
            this.alphaGradientPanel1.Controls.Add(this.CheckBoxOpenUpdateWindow);
            this.alphaGradientPanel1.CornerRadius = 0;
            this.alphaGradientPanel1.Corners = System.Windows.Forms.Corner.None;
            this.animator1.SetDecoration(this.alphaGradientPanel1, AnimatorNS.DecorationType.None);
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
            this.colorWithAlpha4.Color = System.Drawing.SystemColors.Control;
            this.colorWithAlpha4.Parent = this.alphaGradientPanel1;
            // 
            // colorWithAlpha3
            // 
            this.colorWithAlpha3.Alpha = 255;
            this.colorWithAlpha3.Color = System.Drawing.SystemColors.InactiveCaption;
            this.colorWithAlpha3.Parent = this.alphaGradientPanel1;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.animator1.SetDecoration(this.BtnOK, AnimatorNS.DecorationType.None);
            this.BtnOK.Location = new System.Drawing.Point(376, 13);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "ОК";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // CheckBoxOpenUpdateWindow
            // 
            this.CheckBoxOpenUpdateWindow.Checked = true;
            this.CheckBoxOpenUpdateWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.animator1.SetDecoration(this.CheckBoxOpenUpdateWindow, AnimatorNS.DecorationType.None);
            this.CheckBoxOpenUpdateWindow.Location = new System.Drawing.Point(9, 6);
            this.CheckBoxOpenUpdateWindow.Name = "CheckBoxOpenUpdateWindow";
            this.CheckBoxOpenUpdateWindow.Size = new System.Drawing.Size(225, 38);
            this.CheckBoxOpenUpdateWindow.TabIndex = 0;
            this.CheckBoxOpenUpdateWindow.Text = "Открывать данное окно при запуске (при наличии обновления)";
            this.CheckBoxOpenUpdateWindow.UseVisualStyleBackColor = true;
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation5;
            // 
            // CheckUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 337);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.alphaGradientPanel1);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Проверить обновления";
            this.TopMost = true;
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
		private Krypton.Toolkit.KryptonLabel LabelCurrentVersion;
		private Krypton.Toolkit.KryptonProgressBar progressBar1;
		private Krypton.Toolkit.KryptonButton BtnLoad;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
		private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel VersionChangelog;
		private Krypton.Toolkit.KryptonTableLayoutPanel tableLayoutPanel1;
		private Krypton.Toolkit.KryptonLabel LabelLastVersionValue;
		private Krypton.Toolkit.KryptonLabel LabelLastVersion;
		private Krypton.Toolkit.KryptonLabel LabelCurrentVersionValue;
		private System.Windows.Forms.GroupBox groupBox1;
		private Krypton.Toolkit.KryptonLabel LabelStatus;
		private System.Windows.Forms.TabPage TabPageCheckUpdate;
		private System.Windows.Forms.TabPage TabPageAvailableUpdate;
		private System.Windows.Forms.TabControl tabControl1;
		private Krypton.Toolkit.KryptonWrapLabel LabelCheckUpdate;
		private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha4;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha3;
		private System.Windows.Forms.CheckBox CheckBoxOpenUpdateWindow;
		private System.Windows.Forms.Button BtnOK;
		private AnimatorNS.Animator animator1;
	}
}