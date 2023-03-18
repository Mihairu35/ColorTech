namespace ColorTech.Forms {
	partial class OptionsForm {
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
            this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
            this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
            this.BtnCancel = new Krypton.Toolkit.KryptonButton();
            this.BtnSave = new Krypton.Toolkit.KryptonButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Option5 = new Krypton.Toolkit.KryptonCheckBox();
            this.Option6 = new Krypton.Toolkit.KryptonCheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Option1 = new Krypton.Toolkit.KryptonCheckBox();
            this.Option4 = new Krypton.Toolkit.KryptonCheckBox();
            this.Option2 = new Krypton.Toolkit.KryptonCheckBox();
            this.Option3 = new Krypton.Toolkit.KryptonCheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.adminWarning = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.colorWithAlpha2.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.colorWithAlpha2.Parent = this.alphaGradientPanel1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.CornerRoundingRadius = -1F;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(276, 15);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Values.Text = "Отмена";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.CornerRoundingRadius = -1F;
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.Location = new System.Drawing.Point(195, 15);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Values.Text = "Сохранить";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Option6);
            this.tabPage2.Controls.Add(this.Option5);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обновления";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Option5
            // 
            this.Option5.Checked = true;
            this.Option5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option5.Location = new System.Drawing.Point(6, 6);
            this.Option5.Name = "Option5";
            this.Option5.Size = new System.Drawing.Size(315, 20);
            this.Option5.TabIndex = 0;
            this.Option5.Values.Text = "Проверять на обновления при запуске программы";
            // 
            // Option6
            // 
            this.Option6.Checked = true;
            this.Option6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option6.Location = new System.Drawing.Point(6, 29);
            this.Option6.Name = "Option6";
            this.Option6.Size = new System.Drawing.Size(296, 20);
            this.Option6.TabIndex = 1;
            this.Option6.Values.Text = "Проверять на обновления в фоновом процессе";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основное";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.Option3);
            this.flowLayoutPanel1.Controls.Add(this.Option2);
            this.flowLayoutPanel1.Controls.Add(this.Option4);
            this.flowLayoutPanel1.Controls.Add(this.adminWarning);
            this.flowLayoutPanel1.Controls.Add(this.Option1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 275);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Option1
            // 
            this.Option1.Checked = true;
            this.Option1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Option1.Location = new System.Drawing.Point(3, 134);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(299, 20);
            this.Option1.TabIndex = 0;
            this.Option1.Values.Text = "Запускать программу при запуске системы";
            // 
            // Option4
            // 
            this.Option4.Checked = true;
            this.Option4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Option4.Location = new System.Drawing.Point(3, 55);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(299, 20);
            this.Option4.TabIndex = 3;
            this.Option4.Values.Text = "Окно программы поверх остальных";
            // 
            // Option2
            // 
            this.Option2.Checked = true;
            this.Option2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Option2.Location = new System.Drawing.Point(3, 29);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(299, 20);
            this.Option2.TabIndex = 1;
            this.Option2.Values.Text = "Отображать иконку в трее";
            // 
            // Option3
            // 
            this.Option3.Checked = true;
            this.Option3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Option3.Location = new System.Drawing.Point(3, 3);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(299, 20);
            this.Option3.TabIndex = 2;
            this.Option3.Values.Text = "Отображать значение цвета в верхнем регистре";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(8, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // adminWarning
            // 
            this.adminWarning.AutoSize = false;
            this.adminWarning.AutoSizeHeightOnly = true;
            this.adminWarning.BackColor = System.Drawing.Color.Transparent;
            this.adminWarning.BaseStylesheet = null;
            this.adminWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminWarning.IsContextMenuEnabled = false;
            this.adminWarning.IsSelectionEnabled = false;
            this.adminWarning.Location = new System.Drawing.Point(3, 98);
            this.adminWarning.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.adminWarning.Name = "adminWarning";
            this.adminWarning.Size = new System.Drawing.Size(299, 30);
            this.adminWarning.TabIndex = 4;
            this.adminWarning.Text = "<small style=\"color:red\">Для изменения параметров ниже требуются права администра" +
    "тора!</p>";
            // 
            // alphaGradientPanel1
            // 
            this.alphaGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel1.Border = false;
            this.alphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha1);
            this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha2);
            this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel1.Controls.Add(this.BtnCancel);
            this.alphaGradientPanel1.Controls.Add(this.BtnSave);
            this.alphaGradientPanel1.CornerRadius = 0;
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
            this.alphaGradientPanel1.Location = new System.Drawing.Point(0, 320);
            this.alphaGradientPanel1.Name = "alphaGradientPanel1";
            this.alphaGradientPanel1.Rounded = false;
            this.alphaGradientPanel1.Size = new System.Drawing.Size(358, 50);
            this.alphaGradientPanel1.TabIndex = 12;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 370);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.alphaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.alphaGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
		private Krypton.Toolkit.KryptonButton BtnCancel;
		private Krypton.Toolkit.KryptonButton BtnSave;
        private System.Windows.Forms.TabPage tabPage2;
        private Krypton.Toolkit.KryptonCheckBox Option6;
        private Krypton.Toolkit.KryptonCheckBox Option5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonCheckBox Option3;
        private Krypton.Toolkit.KryptonCheckBox Option2;
        private Krypton.Toolkit.KryptonCheckBox Option4;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel adminWarning;
        private Krypton.Toolkit.KryptonCheckBox Option1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
    }
}