namespace ColorTech.Forms {
	partial class PaletteGeneratorForm {
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
			this.ColorWheelBox = new System.Windows.Forms.PictureBox();
			this.DrawTimer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelValValue = new System.Windows.Forms.Label();
			this.LabelAngleValue = new System.Windows.Forms.Label();
			this.LabelHueValue = new System.Windows.Forms.Label();
			this.SliderVal = new ColorSlider.ColorSlider();
			this.SliderAngle = new ColorSlider.ColorSlider();
			this.SliderHue = new ColorSlider.ColorSlider();
			this.LabelVal = new System.Windows.Forms.Label();
			this.LabelAngle = new System.Windows.Forms.Label();
			this.LabelHue = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.PreviewBox = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.CheckBoxColors3 = new System.Windows.Forms.CheckBox();
			this.CheckBoxColors2 = new System.Windows.Forms.CheckBox();
			this.CheckBoxColors1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TextBoxPaletteName = new System.Windows.Forms.TextBox();
			this.BtnReset = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnOK = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ColorWheelBox)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// ColorWheelBox
			// 
			this.ColorWheelBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ColorWheelBox.Location = new System.Drawing.Point(3, 16);
			this.ColorWheelBox.Margin = new System.Windows.Forms.Padding(0);
			this.ColorWheelBox.Name = "ColorWheelBox";
			this.ColorWheelBox.Size = new System.Drawing.Size(291, 295);
			this.ColorWheelBox.TabIndex = 0;
			this.ColorWheelBox.TabStop = false;
			// 
			// DrawTimer
			// 
			this.DrawTimer.Enabled = true;
			this.DrawTimer.Interval = 12;
			this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.71856F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.28144F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
			this.tableLayoutPanel1.Controls.Add(this.LabelValValue, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelAngleValue, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelHueValue, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.SliderVal, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.SliderAngle, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.SliderHue, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelVal, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelAngle, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelHue, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 84);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// LabelValValue
			// 
			this.LabelValValue.AutoSize = true;
			this.LabelValValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelValValue.Location = new System.Drawing.Point(190, 57);
			this.LabelValValue.Name = "LabelValValue";
			this.LabelValValue.Size = new System.Drawing.Size(63, 26);
			this.LabelValValue.TabIndex = 50;
			this.LabelValValue.Text = "255";
			this.LabelValValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelAngleValue
			// 
			this.LabelAngleValue.AutoSize = true;
			this.LabelAngleValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAngleValue.Location = new System.Drawing.Point(190, 29);
			this.LabelAngleValue.Name = "LabelAngleValue";
			this.LabelAngleValue.Size = new System.Drawing.Size(63, 27);
			this.LabelAngleValue.TabIndex = 49;
			this.LabelAngleValue.Text = "90";
			this.LabelAngleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelHueValue
			// 
			this.LabelHueValue.AutoSize = true;
			this.LabelHueValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelHueValue.Location = new System.Drawing.Point(190, 1);
			this.LabelHueValue.Name = "LabelHueValue";
			this.LabelHueValue.Size = new System.Drawing.Size(63, 27);
			this.LabelHueValue.TabIndex = 48;
			this.LabelHueValue.Text = "0";
			this.LabelHueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SliderVal
			// 
			this.SliderVal.BackColor = System.Drawing.SystemColors.Control;
			this.SliderVal.BarInnerColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderVal.BarPenColorBottom = System.Drawing.SystemColors.ControlLight;
			this.SliderVal.BarPenColorTop = System.Drawing.SystemColors.ControlDark;
			this.SliderVal.BorderRoundRectSize = new System.Drawing.Size(5, 5);
			this.SliderVal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SliderVal.ElapsedInnerColor = System.Drawing.SystemColors.ControlDark;
			this.SliderVal.ElapsedPenColorBottom = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderVal.ElapsedPenColorTop = System.Drawing.SystemColors.Control;
			this.SliderVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.SliderVal.ForeColor = System.Drawing.Color.White;
			this.SliderVal.LargeChange = ((uint)(5u));
			this.SliderVal.Location = new System.Drawing.Point(80, 60);
			this.SliderVal.Maximum = 255;
			this.SliderVal.MouseWheelBarPartitions = 30;
			this.SliderVal.Name = "SliderVal";
			this.SliderVal.ScaleDivisions = 30;
			this.SliderVal.ScaleSubDivisions = 5;
			this.SliderVal.ShowDivisionsText = true;
			this.SliderVal.ShowSmallScale = false;
			this.SliderVal.Size = new System.Drawing.Size(103, 20);
			this.SliderVal.SmallChange = ((uint)(1u));
			this.SliderVal.TabIndex = 47;
			this.SliderVal.ThumbInnerColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderVal.ThumbOuterColor = System.Drawing.SystemColors.ControlLightLight;
			this.SliderVal.ThumbPenColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderVal.ThumbRoundRectSize = new System.Drawing.Size(10, 10);
			this.SliderVal.ThumbSize = new System.Drawing.Size(10, 10);
			this.SliderVal.TickAdd = 0F;
			this.SliderVal.TickColor = System.Drawing.Color.White;
			this.SliderVal.TickDivide = 0F;
			this.SliderVal.TickStyle = System.Windows.Forms.TickStyle.None;
			this.SliderVal.Value = 255;
			this.SliderVal.ValueChanged += new System.EventHandler(this.SliderVal_ValueChanged);
			// 
			// SliderAngle
			// 
			this.SliderAngle.BackColor = System.Drawing.SystemColors.Control;
			this.SliderAngle.BarInnerColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderAngle.BarPenColorBottom = System.Drawing.SystemColors.ControlLight;
			this.SliderAngle.BarPenColorTop = System.Drawing.SystemColors.ControlDark;
			this.SliderAngle.BorderRoundRectSize = new System.Drawing.Size(5, 5);
			this.SliderAngle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SliderAngle.ElapsedInnerColor = System.Drawing.SystemColors.ControlDark;
			this.SliderAngle.ElapsedPenColorBottom = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderAngle.ElapsedPenColorTop = System.Drawing.SystemColors.Control;
			this.SliderAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.SliderAngle.ForeColor = System.Drawing.Color.White;
			this.SliderAngle.LargeChange = ((uint)(5u));
			this.SliderAngle.Location = new System.Drawing.Point(80, 32);
			this.SliderAngle.Maximum = 180;
			this.SliderAngle.MouseWheelBarPartitions = 45;
			this.SliderAngle.Name = "SliderAngle";
			this.SliderAngle.ScaleDivisions = 30;
			this.SliderAngle.ScaleSubDivisions = 5;
			this.SliderAngle.ShowDivisionsText = true;
			this.SliderAngle.ShowSmallScale = false;
			this.SliderAngle.Size = new System.Drawing.Size(103, 21);
			this.SliderAngle.SmallChange = ((uint)(1u));
			this.SliderAngle.TabIndex = 46;
			this.SliderAngle.ThumbInnerColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderAngle.ThumbOuterColor = System.Drawing.SystemColors.ControlLightLight;
			this.SliderAngle.ThumbPenColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderAngle.ThumbRoundRectSize = new System.Drawing.Size(10, 10);
			this.SliderAngle.ThumbSize = new System.Drawing.Size(10, 10);
			this.SliderAngle.TickAdd = 0F;
			this.SliderAngle.TickColor = System.Drawing.Color.White;
			this.SliderAngle.TickDivide = 0F;
			this.SliderAngle.TickStyle = System.Windows.Forms.TickStyle.None;
			this.SliderAngle.Value = 90;
			this.SliderAngle.ValueChanged += new System.EventHandler(this.SliderAngle_ValueChanged);
			// 
			// SliderHue
			// 
			this.SliderHue.BackColor = System.Drawing.SystemColors.Control;
			this.SliderHue.BarInnerColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderHue.BarPenColorBottom = System.Drawing.SystemColors.ControlLight;
			this.SliderHue.BarPenColorTop = System.Drawing.SystemColors.ControlDark;
			this.SliderHue.BorderRoundRectSize = new System.Drawing.Size(5, 5);
			this.SliderHue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SliderHue.ElapsedInnerColor = System.Drawing.SystemColors.ControlDark;
			this.SliderHue.ElapsedPenColorBottom = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderHue.ElapsedPenColorTop = System.Drawing.SystemColors.Control;
			this.SliderHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.SliderHue.ForeColor = System.Drawing.Color.White;
			this.SliderHue.LargeChange = ((uint)(5u));
			this.SliderHue.Location = new System.Drawing.Point(80, 4);
			this.SliderHue.Maximum = 360;
			this.SliderHue.MouseWheelBarPartitions = 90;
			this.SliderHue.Name = "SliderHue";
			this.SliderHue.ScaleDivisions = 30;
			this.SliderHue.ScaleSubDivisions = 5;
			this.SliderHue.ShowDivisionsText = true;
			this.SliderHue.ShowSmallScale = false;
			this.SliderHue.Size = new System.Drawing.Size(103, 21);
			this.SliderHue.SmallChange = ((uint)(1u));
			this.SliderHue.TabIndex = 45;
			this.SliderHue.ThumbInnerColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderHue.ThumbOuterColor = System.Drawing.SystemColors.ControlLightLight;
			this.SliderHue.ThumbPenColor = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderHue.ThumbRoundRectSize = new System.Drawing.Size(10, 10);
			this.SliderHue.ThumbSize = new System.Drawing.Size(10, 10);
			this.SliderHue.TickAdd = 0F;
			this.SliderHue.TickColor = System.Drawing.Color.White;
			this.SliderHue.TickDivide = 0F;
			this.SliderHue.TickStyle = System.Windows.Forms.TickStyle.None;
			this.SliderHue.Value = 0;
			this.SliderHue.ValueChanged += new System.EventHandler(this.SliderHue_ValueChanged);
			// 
			// LabelVal
			// 
			this.LabelVal.AutoSize = true;
			this.LabelVal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelVal.Location = new System.Drawing.Point(4, 57);
			this.LabelVal.Name = "LabelVal";
			this.LabelVal.Size = new System.Drawing.Size(69, 26);
			this.LabelVal.TabIndex = 19;
			this.LabelVal.Text = "Яркость";
			this.LabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelAngle
			// 
			this.LabelAngle.AutoSize = true;
			this.LabelAngle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAngle.Location = new System.Drawing.Point(4, 29);
			this.LabelAngle.Name = "LabelAngle";
			this.LabelAngle.Size = new System.Drawing.Size(69, 27);
			this.LabelAngle.TabIndex = 18;
			this.LabelAngle.Text = "Угол";
			this.LabelAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelHue
			// 
			this.LabelHue.AutoSize = true;
			this.LabelHue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelHue.Location = new System.Drawing.Point(4, 1);
			this.LabelHue.Name = "LabelHue";
			this.LabelHue.Size = new System.Drawing.Size(69, 27);
			this.LabelHue.TabIndex = 17;
			this.LabelHue.Text = "Оттенок";
			this.LabelHue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ColorWheelBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 156);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(297, 314);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Цветовой круг";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.PreviewBox);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox2.Location = new System.Drawing.Point(319, 265);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(263, 205);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Предпросмотр";
			// 
			// PreviewBox
			// 
			this.PreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PreviewBox.Location = new System.Drawing.Point(3, 16);
			this.PreviewBox.Name = "PreviewBox";
			this.PreviewBox.Size = new System.Drawing.Size(257, 186);
			this.PreviewBox.TabIndex = 0;
			this.PreviewBox.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.CheckBoxColors3);
			this.groupBox3.Controls.Add(this.CheckBoxColors2);
			this.groupBox3.Controls.Add(this.CheckBoxColors1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.TextBoxPaletteName);
			this.groupBox3.Controls.Add(this.BtnReset);
			this.groupBox3.Location = new System.Drawing.Point(12, 58);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(570, 92);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Свойства";
			// 
			// CheckBoxColors3
			// 
			this.CheckBoxColors3.AutoSize = true;
			this.CheckBoxColors3.Checked = true;
			this.CheckBoxColors3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxColors3.Location = new System.Drawing.Point(11, 67);
			this.CheckBoxColors3.Name = "CheckBoxColors3";
			this.CheckBoxColors3.Size = new System.Drawing.Size(98, 17);
			this.CheckBoxColors3.TabIndex = 34;
			this.CheckBoxColors3.Text = "Темные цвета";
			this.CheckBoxColors3.UseVisualStyleBackColor = true;
			// 
			// CheckBoxColors2
			// 
			this.CheckBoxColors2.AutoSize = true;
			this.CheckBoxColors2.Checked = true;
			this.CheckBoxColors2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxColors2.Location = new System.Drawing.Point(11, 44);
			this.CheckBoxColors2.Name = "CheckBoxColors2";
			this.CheckBoxColors2.Size = new System.Drawing.Size(89, 17);
			this.CheckBoxColors2.TabIndex = 33;
			this.CheckBoxColors2.Text = "Яркие цвета";
			this.CheckBoxColors2.UseVisualStyleBackColor = true;
			// 
			// CheckBoxColors1
			// 
			this.CheckBoxColors1.AutoSize = true;
			this.CheckBoxColors1.Checked = true;
			this.CheckBoxColors1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxColors1.Location = new System.Drawing.Point(11, 21);
			this.CheckBoxColors1.Name = "CheckBoxColors1";
			this.CheckBoxColors1.Size = new System.Drawing.Size(104, 17);
			this.CheckBoxColors1.TabIndex = 32;
			this.CheckBoxColors1.Text = "Обычные цвета";
			this.CheckBoxColors1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(151, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "Имя палитры:";
			// 
			// TextBoxPaletteName
			// 
			this.TextBoxPaletteName.Location = new System.Drawing.Point(154, 34);
			this.TextBoxPaletteName.Name = "TextBoxPaletteName";
			this.TextBoxPaletteName.Size = new System.Drawing.Size(143, 20);
			this.TextBoxPaletteName.TabIndex = 30;
			this.TextBoxPaletteName.Text = "Новая палитра";
			// 
			// BtnReset
			// 
			this.BtnReset.Location = new System.Drawing.Point(154, 61);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(94, 23);
			this.BtnReset.TabIndex = 29;
			this.BtnReset.Text = "По умолчанию";
			this.BtnReset.UseVisualStyleBackColor = true;
			this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.tableLayoutPanel1);
			this.groupBox4.Location = new System.Drawing.Point(319, 156);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(263, 103);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Параметры палитры";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(571, 49);
			this.label1.TabIndex = 29;
			this.label1.Text = "Изменяйте параметры ниже, чтобы выбрать цвет и получить соответствующую цветовую " +
    "палитру";
			// 
			// BtnOK
			// 
			this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnOK.Location = new System.Drawing.Point(375, 479);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(124, 25);
			this.BtnOK.TabIndex = 30;
			this.BtnOK.Text = "Добавить в палитру";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnCancel.Location = new System.Drawing.Point(505, 479);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(77, 25);
			this.BtnCancel.TabIndex = 31;
			this.BtnCancel.Text = "Отменить";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// PaletteGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 516);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "PaletteGeneratorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Генератор палитры";
			((System.ComponentModel.ISupportInitialize)(this.ColorWheelBox)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ColorWheelBox;
		private System.Windows.Forms.Timer DrawTimer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox PreviewBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.CheckBox CheckBoxColors3;
		private System.Windows.Forms.CheckBox CheckBoxColors2;
		private System.Windows.Forms.CheckBox CheckBoxColors1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TextBoxPaletteName;
		private System.Windows.Forms.Label LabelVal;
		private System.Windows.Forms.Label LabelAngle;
		private System.Windows.Forms.Label LabelHue;
		private ColorSlider.ColorSlider SliderVal;
		private ColorSlider.ColorSlider SliderAngle;
		private ColorSlider.ColorSlider SliderHue;
		private System.Windows.Forms.Label LabelValValue;
		private System.Windows.Forms.Label LabelAngleValue;
		private System.Windows.Forms.Label LabelHueValue;
	}
}