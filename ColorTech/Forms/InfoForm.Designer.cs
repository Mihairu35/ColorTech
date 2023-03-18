namespace ColorTech.Forms {
	partial class InfoForm {
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
			this.TextBoxDescription = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelDescription = new System.Windows.Forms.Label();
			this.LabelSite = new System.Windows.Forms.Label();
			this.LabelAuthor = new System.Windows.Forms.Label();
			this.LabelAuthorValue = new System.Windows.Forms.Label();
			this.LabelSiteValue = new System.Windows.Forms.LinkLabel();
			this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
			this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
			this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
			this.BtnOK = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.alphaGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TextBoxDescription
			// 
			this.TextBoxDescription.BackColor = System.Drawing.SystemColors.Control;
			this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxDescription.Location = new System.Drawing.Point(109, 68);
			this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(5);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ReadOnly = true;
			this.TextBoxDescription.Size = new System.Drawing.Size(232, 179);
			this.TextBoxDescription.TabIndex = 14;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.43038F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.56962F));
			this.tableLayoutPanel1.Controls.Add(this.LabelDescription, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelSite, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxDescription, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelAuthor, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelAuthorValue, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelSiteValue, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 8);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 254);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// LabelDescription
			// 
			this.LabelDescription.AutoSize = true;
			this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelDescription.Location = new System.Drawing.Point(5, 63);
			this.LabelDescription.Name = "LabelDescription";
			this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
			this.LabelDescription.Size = new System.Drawing.Size(94, 189);
			this.LabelDescription.TabIndex = 19;
			this.LabelDescription.Text = "Описание";
			// 
			// LabelSite
			// 
			this.LabelSite.AutoSize = true;
			this.LabelSite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelSite.Location = new System.Drawing.Point(5, 32);
			this.LabelSite.Name = "LabelSite";
			this.LabelSite.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
			this.LabelSite.Size = new System.Drawing.Size(94, 29);
			this.LabelSite.TabIndex = 18;
			this.LabelSite.Text = "Сайт";
			this.LabelSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelAuthor
			// 
			this.LabelAuthor.AutoSize = true;
			this.LabelAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAuthor.Location = new System.Drawing.Point(5, 2);
			this.LabelAuthor.Name = "LabelAuthor";
			this.LabelAuthor.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
			this.LabelAuthor.Size = new System.Drawing.Size(94, 28);
			this.LabelAuthor.TabIndex = 15;
			this.LabelAuthor.Text = "Автор";
			this.LabelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelAuthorValue
			// 
			this.LabelAuthorValue.AutoSize = true;
			this.LabelAuthorValue.BackColor = System.Drawing.SystemColors.Control;
			this.LabelAuthorValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAuthorValue.Location = new System.Drawing.Point(107, 2);
			this.LabelAuthorValue.Name = "LabelAuthorValue";
			this.LabelAuthorValue.Padding = new System.Windows.Forms.Padding(5);
			this.LabelAuthorValue.Size = new System.Drawing.Size(236, 28);
			this.LabelAuthorValue.TabIndex = 16;
			this.LabelAuthorValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelSiteValue
			// 
			this.LabelSiteValue.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.LabelSiteValue.AutoSize = true;
			this.LabelSiteValue.BackColor = System.Drawing.SystemColors.Control;
			this.LabelSiteValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelSiteValue.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LabelSiteValue.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.LabelSiteValue.Location = new System.Drawing.Point(107, 32);
			this.LabelSiteValue.Name = "LabelSiteValue";
			this.LabelSiteValue.Padding = new System.Windows.Forms.Padding(5);
			this.LabelSiteValue.Size = new System.Drawing.Size(236, 29);
			this.LabelSiteValue.TabIndex = 17;
			this.LabelSiteValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelSiteValue.VisitedLinkColor = System.Drawing.SystemColors.InfoText;
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
			this.alphaGradientPanel1.CornerRadius = 0;
			this.alphaGradientPanel1.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
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
			this.alphaGradientPanel1.Location = new System.Drawing.Point(0, 269);
			this.alphaGradientPanel1.Name = "alphaGradientPanel1";
			this.alphaGradientPanel1.Rounded = false;
			this.alphaGradientPanel1.Size = new System.Drawing.Size(362, 50);
			this.alphaGradientPanel1.TabIndex = 39;
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
			this.colorWithAlpha2.Color = System.Drawing.SystemColors.ControlDark;
			this.colorWithAlpha2.Parent = this.alphaGradientPanel1;
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.Location = new System.Drawing.Point(275, 13);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(75, 23);
			this.BtnOK.TabIndex = 32;
			this.BtnOK.Text = "ОК";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// InfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 319);
			this.Controls.Add(this.alphaGradientPanel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InfoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Свойства палитры";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.PaletteInfo_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.alphaGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox TextBoxDescription;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LabelDescription;
		private System.Windows.Forms.Label LabelSite;
		private System.Windows.Forms.Label LabelAuthor;
		private System.Windows.Forms.Label LabelAuthorValue;
		private System.Windows.Forms.LinkLabel LabelSiteValue;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
    }
}