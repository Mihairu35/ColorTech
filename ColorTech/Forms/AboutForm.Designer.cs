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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.BtnSite = new System.Windows.Forms.Button();
			this.BtnOK = new System.Windows.Forms.Button();
			this.LabelCopyright = new System.Windows.Forms.Label();
			this.TextBoxDescription = new System.Windows.Forms.TextBox();
			this.LabelProductName = new System.Windows.Forms.Label();
			this.LabelVersion = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = global::ColorTech.Properties.Resources.colortechlogo;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(354, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(49, 50);
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackgroundImage = global::ColorTech.Properties.Resources.logo;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(246, 20);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.TabIndex = 30;
			this.pictureBox2.TabStop = false;
			// 
			// BtnSite
			// 
			this.BtnSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSite.Image = global::ColorTech.Properties.Resources.if_tree_64927;
			this.BtnSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnSite.Location = new System.Drawing.Point(187, 243);
			this.BtnSite.Name = "BtnSite";
			this.BtnSite.Size = new System.Drawing.Size(135, 23);
			this.BtnSite.TabIndex = 31;
			this.BtnSite.Text = "Сайт разработчика";
			this.BtnSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnSite.UseVisualStyleBackColor = true;
			this.BtnSite.Click += new System.EventHandler(this.BtnSite_Click);
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.Location = new System.Drawing.Point(328, 243);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(75, 23);
			this.BtnOK.TabIndex = 32;
			this.BtnOK.Text = "ОК";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// LabelCopyright
			// 
			this.LabelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelCopyright.Location = new System.Drawing.Point(19, 217);
			this.LabelCopyright.Name = "LabelCopyright";
			this.LabelCopyright.Size = new System.Drawing.Size(384, 21);
			this.LabelCopyright.TabIndex = 33;
			this.LabelCopyright.Text = "Копирайт";
			this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TextBoxDescription
			// 
			this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxDescription.Location = new System.Drawing.Point(19, 76);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxDescription.Size = new System.Drawing.Size(384, 138);
			this.TextBoxDescription.TabIndex = 34;
			this.TextBoxDescription.Text = "Подробное описание программы";
			// 
			// LabelProductName
			// 
			this.LabelProductName.AutoSize = true;
			this.LabelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelProductName.Location = new System.Drawing.Point(15, 20);
			this.LabelProductName.Name = "LabelProductName";
			this.LabelProductName.Size = new System.Drawing.Size(190, 20);
			this.LabelProductName.TabIndex = 35;
			this.LabelProductName.Text = "Название программы";
			// 
			// LabelVersion
			// 
			this.LabelVersion.AutoSize = true;
			this.LabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelVersion.Location = new System.Drawing.Point(16, 48);
			this.LabelVersion.Name = "LabelVersion";
			this.LabelVersion.Size = new System.Drawing.Size(55, 16);
			this.LabelVersion.TabIndex = 36;
			this.LabelVersion.Text = "Версия";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 273);
			this.Controls.Add(this.LabelVersion);
			this.Controls.Add(this.LabelProductName);
			this.Controls.Add(this.TextBoxDescription);
			this.Controls.Add(this.LabelCopyright);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.BtnSite);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "О программе";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button BtnSite;
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.Label LabelCopyright;
		private System.Windows.Forms.TextBox TextBoxDescription;
		private System.Windows.Forms.Label LabelProductName;
		private System.Windows.Forms.Label LabelVersion;
	}
}
