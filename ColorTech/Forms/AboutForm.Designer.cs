namespace ColorTech.Forms {
	partial class AboutForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
            this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
            this.BtnOK = new Krypton.Toolkit.KryptonButton();
            this.BtnCheckUpdate = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.TextBoxDescription = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.LabelVersion = new Krypton.Toolkit.KryptonLabel();
            this.LabelProductName = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelCopyright = new Krypton.Toolkit.KryptonLabel();
            this.alphaGradientPanel2 = new System.Windows.Forms.AlphaGradientPanel();
            this.colorWithAlpha3 = new System.Windows.Forms.ColorWithAlpha();
            this.colorWithAlpha4 = new System.Windows.Forms.ColorWithAlpha();
            this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.alphaGradientPanel2.SuspendLayout();
            this.alphaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorWithAlpha1
            // 
            this.colorWithAlpha1.Alpha = 255;
            this.colorWithAlpha1.Color = System.Drawing.SystemColors.Control;
            this.colorWithAlpha1.Parent = this.alphaGradientPanel1;
            // 
            // colorWithAlpha2
            // 
            this.colorWithAlpha2.Alpha = 255;
            this.colorWithAlpha2.Color = System.Drawing.SystemColors.InactiveCaption;
            this.colorWithAlpha2.Parent = this.alphaGradientPanel1;
            // 
            // BtnOK
            // 
            this.BtnOK.CornerRoundingRadius = -1F;
            this.animator1.SetDecoration(this.BtnOK, AnimatorNS.DecorationType.None);
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(393, 13);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(65, 25);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Values.Text = "ОК";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCheckUpdate
            // 
            this.BtnCheckUpdate.CornerRoundingRadius = -1F;
            this.animator1.SetDecoration(this.BtnCheckUpdate, AnimatorNS.DecorationType.None);
            this.BtnCheckUpdate.Location = new System.Drawing.Point(197, 13);
            this.BtnCheckUpdate.Name = "BtnCheckUpdate";
            this.BtnCheckUpdate.Size = new System.Drawing.Size(190, 25);
            this.BtnCheckUpdate.TabIndex = 1;
            this.BtnCheckUpdate.Values.Image = global::ColorTech.Properties.Resources.if_update_64935;
            this.BtnCheckUpdate.Values.Text = "Проверить на обновления";
            this.BtnCheckUpdate.Click += new System.EventHandler(this.BtnCheckUpdate_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.animator1.SetDecoration(this.kryptonButton1, AnimatorNS.DecorationType.None);
            this.kryptonButton1.Location = new System.Drawing.Point(50, 13);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(141, 25);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Image = global::ColorTech.Properties.Resources.if_tree_64927;
            this.kryptonButton1.Values.Text = "Сайт разработчика";
            this.kryptonButton1.Click += new System.EventHandler(this.BtnSite_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.AutoScroll = true;
            this.TextBoxDescription.AutoScrollMinSize = new System.Drawing.Size(449, 20);
            this.TextBoxDescription.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxDescription.BaseStylesheet = null;
            this.TextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TextBoxDescription, AnimatorNS.DecorationType.None);
            this.TextBoxDescription.IsContextMenuEnabled = false;
            this.TextBoxDescription.IsSelectionEnabled = false;
            this.TextBoxDescription.Location = new System.Drawing.Point(10, 105);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(449, 139);
            this.TextBoxDescription.TabIndex = 40;
            this.TextBoxDescription.Text = "Описание программы (файл about.html)";
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation4;
            this.animator1.Interval = 12;
            this.animator1.MaxAnimationTime = 1000;
            // 
            // LabelVersion
            // 
            this.animator1.SetDecoration(this.LabelVersion, AnimatorNS.DecorationType.None);
            this.LabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVersion.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.LabelVersion.Location = new System.Drawing.Point(80, 36);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(53, 20);
            this.LabelVersion.TabIndex = 36;
            this.LabelVersion.Values.Text = "Версия";
            // 
            // LabelProductName
            // 
            this.animator1.SetDecoration(this.LabelProductName, AnimatorNS.DecorationType.None);
            this.LabelProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductName.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.LabelProductName.Location = new System.Drawing.Point(78, 8);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(212, 29);
            this.LabelProductName.TabIndex = 35;
            this.LabelProductName.Values.Text = "Название программы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ColorTech.Properties.Resources.colortechlogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animator1.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.BottomMirror);
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // LabelCopyright
            // 
            this.animator1.SetDecoration(this.LabelCopyright, AnimatorNS.DecorationType.None);
            this.LabelCopyright.LabelStyle = Krypton.Toolkit.LabelStyle.ItalicPanel;
            this.LabelCopyright.Location = new System.Drawing.Point(80, 58);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(69, 20);
            this.LabelCopyright.TabIndex = 33;
            this.LabelCopyright.Values.Text = "Копирайт";
            // 
            // alphaGradientPanel2
            // 
            this.alphaGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel2.Border = false;
            this.alphaGradientPanel2.BorderColor = System.Drawing.SystemColors.Control;
            this.alphaGradientPanel2.Colors.Add(this.colorWithAlpha3);
            this.alphaGradientPanel2.Colors.Add(this.colorWithAlpha4);
            this.alphaGradientPanel2.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel2.Controls.Add(this.LabelCopyright);
            this.alphaGradientPanel2.Controls.Add(this.pictureBox1);
            this.alphaGradientPanel2.Controls.Add(this.LabelProductName);
            this.alphaGradientPanel2.Controls.Add(this.LabelVersion);
            this.alphaGradientPanel2.CornerRadius = 0;
            this.alphaGradientPanel2.Corners = System.Windows.Forms.Corner.None;
            this.animator1.SetDecoration(this.alphaGradientPanel2, AnimatorNS.DecorationType.None);
            this.alphaGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.alphaGradientPanel2.Gradient = true;
            this.alphaGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel2.GradientOffset = 0F;
            this.alphaGradientPanel2.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel2.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel2.Grayscale = false;
            this.alphaGradientPanel2.Image = null;
            this.alphaGradientPanel2.ImageAlpha = 75;
            this.alphaGradientPanel2.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel2.ImagePosition = System.Windows.Forms.ImagePosition.BottomRight;
            this.alphaGradientPanel2.ImageSize = new System.Drawing.Size(48, 48);
            this.alphaGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.alphaGradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel2.Name = "alphaGradientPanel2";
            this.alphaGradientPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel2.Rounded = false;
            this.alphaGradientPanel2.Size = new System.Drawing.Size(470, 99);
            this.alphaGradientPanel2.TabIndex = 41;
            // 
            // colorWithAlpha3
            // 
            this.colorWithAlpha3.Alpha = 255;
            this.colorWithAlpha3.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.colorWithAlpha3.Parent = this.alphaGradientPanel2;
            // 
            // colorWithAlpha4
            // 
            this.colorWithAlpha4.Alpha = 255;
            this.colorWithAlpha4.Color = System.Drawing.SystemColors.Control;
            this.colorWithAlpha4.Parent = this.alphaGradientPanel2;
            // 
            // alphaGradientPanel1
            // 
            this.alphaGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel1.Border = false;
            this.alphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha1);
            this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha2);
            this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel1.Controls.Add(this.BtnOK);
            this.alphaGradientPanel1.Controls.Add(this.BtnCheckUpdate);
            this.alphaGradientPanel1.Controls.Add(this.kryptonButton1);
            this.alphaGradientPanel1.CornerRadius = 0;
            this.alphaGradientPanel1.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
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
            this.alphaGradientPanel1.Location = new System.Drawing.Point(0, 256);
            this.alphaGradientPanel1.Name = "alphaGradientPanel1";
            this.alphaGradientPanel1.Rounded = false;
            this.alphaGradientPanel1.Size = new System.Drawing.Size(470, 50);
            this.alphaGradientPanel1.TabIndex = 38;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 306);
            this.Controls.Add(this.alphaGradientPanel2);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.alphaGradientPanel1);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.alphaGradientPanel2.ResumeLayout(false);
            this.alphaGradientPanel2.PerformLayout();
            this.alphaGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
		private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel TextBoxDescription;
		private AnimatorNS.Animator animator1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton BtnCheckUpdate;
        private Krypton.Toolkit.KryptonLabel LabelVersion;
        private Krypton.Toolkit.KryptonLabel LabelProductName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel LabelCopyright;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel2;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha3;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha4;
        private Krypton.Toolkit.KryptonButton BtnOK;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
    }
}
