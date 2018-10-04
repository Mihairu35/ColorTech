namespace ColorTech.Forms {
	partial class PaletteInfoForm {
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
			this.BtnOK = new System.Windows.Forms.Button();
			this.TextBoxDescription = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelDescription = new System.Windows.Forms.Label();
			this.LabelSite = new System.Windows.Forms.Label();
			this.LabelAuthor = new System.Windows.Forms.Label();
			this.LabelAuthorValue = new System.Windows.Forms.Label();
			this.LabelSiteValue = new System.Windows.Forms.LinkLabel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnOK
			// 
			this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnOK.Location = new System.Drawing.Point(237, 262);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(75, 23);
			this.BtnOK.TabIndex = 16;
			this.BtnOK.Text = "ОК";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// TextBoxDescription
			// 
			this.TextBoxDescription.BackColor = System.Drawing.SystemColors.Control;
			this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxDescription.Location = new System.Drawing.Point(96, 55);
			this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(5);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ReadOnly = true;
			this.TextBoxDescription.Size = new System.Drawing.Size(202, 179);
			this.TextBoxDescription.TabIndex = 14;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.43038F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.56962F));
			this.tableLayoutPanel1.Controls.Add(this.LabelDescription, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelSite, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxDescription, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelAuthor, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelAuthorValue, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelSiteValue, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 14);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 241);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// LabelDescription
			// 
			this.LabelDescription.AutoSize = true;
			this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelDescription.Location = new System.Drawing.Point(5, 50);
			this.LabelDescription.Name = "LabelDescription";
			this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
			this.LabelDescription.Size = new System.Drawing.Size(81, 189);
			this.LabelDescription.TabIndex = 19;
			this.LabelDescription.Text = "Описание";
			// 
			// LabelSite
			// 
			this.LabelSite.AutoSize = true;
			this.LabelSite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelSite.Location = new System.Drawing.Point(5, 26);
			this.LabelSite.Name = "LabelSite";
			this.LabelSite.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
			this.LabelSite.Size = new System.Drawing.Size(81, 22);
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
			this.LabelAuthor.Size = new System.Drawing.Size(81, 22);
			this.LabelAuthor.TabIndex = 15;
			this.LabelAuthor.Text = "Автор";
			this.LabelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelAuthorValue
			// 
			this.LabelAuthorValue.AutoSize = true;
			this.LabelAuthorValue.BackColor = System.Drawing.SystemColors.Control;
			this.LabelAuthorValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAuthorValue.Location = new System.Drawing.Point(94, 2);
			this.LabelAuthorValue.Name = "LabelAuthorValue";
			this.LabelAuthorValue.Padding = new System.Windows.Forms.Padding(5);
			this.LabelAuthorValue.Size = new System.Drawing.Size(206, 22);
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
			this.LabelSiteValue.Location = new System.Drawing.Point(94, 26);
			this.LabelSiteValue.Name = "LabelSiteValue";
			this.LabelSiteValue.Padding = new System.Windows.Forms.Padding(5);
			this.LabelSiteValue.Size = new System.Drawing.Size(206, 22);
			this.LabelSiteValue.TabIndex = 17;
			this.LabelSiteValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelSiteValue.VisitedLinkColor = System.Drawing.SystemColors.InfoText;
			// 
			// PaletteInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 290);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "PaletteInfoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Свойства палитры";
			this.Load += new System.EventHandler(this.PaletteInfo_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.TextBox TextBoxDescription;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LabelDescription;
		private System.Windows.Forms.Label LabelSite;
		private System.Windows.Forms.Label LabelAuthor;
		private System.Windows.Forms.Label LabelAuthorValue;
		private System.Windows.Forms.LinkLabel LabelSiteValue;
	}
}