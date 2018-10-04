namespace ColorTech.Forms {
	partial class EditInfoForm {
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
			this.BtnSave = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TextBoxSite = new System.Windows.Forms.TextBox();
			this.LabelDescription = new System.Windows.Forms.Label();
			this.LabelSite = new System.Windows.Forms.Label();
			this.TextBoxDescription = new System.Windows.Forms.TextBox();
			this.LabelAuthor = new System.Windows.Forms.Label();
			this.TextBoxAuthor = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnSave
			// 
			this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnSave.Location = new System.Drawing.Point(156, 262);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 13;
			this.BtnSave.Text = "Сохранить";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnCancel.Location = new System.Drawing.Point(237, 262);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(75, 23);
			this.BtnCancel.TabIndex = 14;
			this.BtnCancel.Text = "Отмена";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.43038F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.56962F));
			this.tableLayoutPanel1.Controls.Add(this.TextBoxSite, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelDescription, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelSite, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxDescription, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelAuthor, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxAuthor, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 14);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 241);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// TextBoxSite
			// 
			this.TextBoxSite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxSite.Location = new System.Drawing.Point(94, 29);
			this.TextBoxSite.Name = "TextBoxSite";
			this.TextBoxSite.Size = new System.Drawing.Size(206, 20);
			this.TextBoxSite.TabIndex = 21;
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
			// TextBoxDescription
			// 
			this.TextBoxDescription.BackColor = System.Drawing.SystemColors.Window;
			this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxDescription.Location = new System.Drawing.Point(94, 53);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ReadOnly = true;
			this.TextBoxDescription.Size = new System.Drawing.Size(206, 183);
			this.TextBoxDescription.TabIndex = 14;
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
			// TextBoxAuthor
			// 
			this.TextBoxAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxAuthor.Location = new System.Drawing.Point(94, 5);
			this.TextBoxAuthor.Name = "TextBoxAuthor";
			this.TextBoxAuthor.Size = new System.Drawing.Size(206, 20);
			this.TextBoxAuthor.TabIndex = 20;
			// 
			// EditInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 290);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.BtnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "EditInfoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Изменение свойств палитры";
			this.Load += new System.EventHandler(this.EditInfo_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LabelDescription;
		private System.Windows.Forms.Label LabelSite;
		private System.Windows.Forms.TextBox TextBoxDescription;
		private System.Windows.Forms.Label LabelAuthor;
		private System.Windows.Forms.TextBox TextBoxSite;
		private System.Windows.Forms.TextBox TextBoxAuthor;
	}
}