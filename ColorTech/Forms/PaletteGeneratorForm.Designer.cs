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
			AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteGeneratorForm));
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
			this.BtnOK = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
			this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
			this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
			this.animator1 = new AnimatorNS.Animator(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ColorWheelBox)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.alphaGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ColorWheelBox
			// 
			this.animator1.SetDecoration(this.ColorWheelBox, AnimatorNS.DecorationType.None);
			this.ColorWheelBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ColorWheelBox.Location = new System.Drawing.Point(5, 18);
			this.ColorWheelBox.Margin = new System.Windows.Forms.Padding(0);
			this.ColorWheelBox.Name = "ColorWheelBox";
			this.ColorWheelBox.Size = new System.Drawing.Size(259, 232);
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
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.71856F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.28144F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
			this.tableLayoutPanel1.Controls.Add(this.LabelValValue, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelAngleValue, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelHueValue, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.SliderVal, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.SliderAngle, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.SliderHue, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelVal, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelAngle, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelHue, 0, 0);
			this.animator1.SetDecoration(this.tableLayoutPanel1, AnimatorNS.DecorationType.None);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 18);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 80);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// LabelValValue
			// 
			this.LabelValValue.AutoSize = true;
			this.animator1.SetDecoration(this.LabelValValue, AnimatorNS.DecorationType.None);
			this.LabelValValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelValValue.Location = new System.Drawing.Point(190, 52);
			this.LabelValValue.Name = "LabelValValue";
			this.LabelValValue.Size = new System.Drawing.Size(51, 26);
			this.LabelValValue.TabIndex = 50;
			this.LabelValValue.Text = "255";
			this.LabelValValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelAngleValue
			// 
			this.LabelAngleValue.AutoSize = true;
			this.animator1.SetDecoration(this.LabelAngleValue, AnimatorNS.DecorationType.None);
			this.LabelAngleValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAngleValue.Location = new System.Drawing.Point(190, 27);
			this.LabelAngleValue.Name = "LabelAngleValue";
			this.LabelAngleValue.Size = new System.Drawing.Size(51, 23);
			this.LabelAngleValue.TabIndex = 49;
			this.LabelAngleValue.Text = "90";
			this.LabelAngleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelHueValue
			// 
			this.LabelHueValue.AutoSize = true;
			this.animator1.SetDecoration(this.LabelHueValue, AnimatorNS.DecorationType.None);
			this.LabelHueValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelHueValue.Location = new System.Drawing.Point(190, 2);
			this.LabelHueValue.Name = "LabelHueValue";
			this.LabelHueValue.Size = new System.Drawing.Size(51, 23);
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
			this.animator1.SetDecoration(this.SliderVal, AnimatorNS.DecorationType.None);
			this.SliderVal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SliderVal.ElapsedInnerColor = System.Drawing.SystemColors.ControlDark;
			this.SliderVal.ElapsedPenColorBottom = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderVal.ElapsedPenColorTop = System.Drawing.SystemColors.Control;
			this.SliderVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.SliderVal.ForeColor = System.Drawing.Color.White;
			this.SliderVal.LargeChange = ((uint)(1u));
			this.SliderVal.Location = new System.Drawing.Point(81, 55);
			this.SliderVal.Maximum = 255;
			this.SliderVal.MouseWheelBarPartitions = 255;
			this.SliderVal.Name = "SliderVal";
			this.SliderVal.ScaleDivisions = 255;
			this.SliderVal.ScaleSubDivisions = 5;
			this.SliderVal.ShowDivisionsText = true;
			this.SliderVal.ShowSmallScale = false;
			this.SliderVal.Size = new System.Drawing.Size(101, 20);
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
			this.animator1.SetDecoration(this.SliderAngle, AnimatorNS.DecorationType.None);
			this.SliderAngle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SliderAngle.ElapsedInnerColor = System.Drawing.SystemColors.ControlDark;
			this.SliderAngle.ElapsedPenColorBottom = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderAngle.ElapsedPenColorTop = System.Drawing.SystemColors.Control;
			this.SliderAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.SliderAngle.ForeColor = System.Drawing.Color.White;
			this.SliderAngle.LargeChange = ((uint)(1u));
			this.SliderAngle.Location = new System.Drawing.Point(81, 30);
			this.SliderAngle.Maximum = 180;
			this.SliderAngle.MouseWheelBarPartitions = 180;
			this.SliderAngle.Name = "SliderAngle";
			this.SliderAngle.ScaleDivisions = 180;
			this.SliderAngle.ScaleSubDivisions = 5;
			this.SliderAngle.ShowDivisionsText = true;
			this.SliderAngle.ShowSmallScale = false;
			this.SliderAngle.Size = new System.Drawing.Size(101, 17);
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
			this.animator1.SetDecoration(this.SliderHue, AnimatorNS.DecorationType.None);
			this.SliderHue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SliderHue.ElapsedInnerColor = System.Drawing.SystemColors.ControlDark;
			this.SliderHue.ElapsedPenColorBottom = System.Drawing.SystemColors.ControlDarkDark;
			this.SliderHue.ElapsedPenColorTop = System.Drawing.SystemColors.Control;
			this.SliderHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.SliderHue.ForeColor = System.Drawing.Color.White;
			this.SliderHue.LargeChange = ((uint)(1u));
			this.SliderHue.Location = new System.Drawing.Point(81, 5);
			this.SliderHue.Maximum = 360;
			this.SliderHue.MouseWheelBarPartitions = 360;
			this.SliderHue.Name = "SliderHue";
			this.SliderHue.ScaleDivisions = 360;
			this.SliderHue.ScaleSubDivisions = 5;
			this.SliderHue.ShowDivisionsText = true;
			this.SliderHue.ShowSmallScale = false;
			this.SliderHue.Size = new System.Drawing.Size(101, 17);
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
			this.animator1.SetDecoration(this.LabelVal, AnimatorNS.DecorationType.None);
			this.LabelVal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelVal.Location = new System.Drawing.Point(5, 52);
			this.LabelVal.Name = "LabelVal";
			this.LabelVal.Size = new System.Drawing.Size(68, 26);
			this.LabelVal.TabIndex = 19;
			this.LabelVal.Text = "Яркость";
			this.LabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelAngle
			// 
			this.LabelAngle.AutoSize = true;
			this.animator1.SetDecoration(this.LabelAngle, AnimatorNS.DecorationType.None);
			this.LabelAngle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAngle.Location = new System.Drawing.Point(5, 27);
			this.LabelAngle.Name = "LabelAngle";
			this.LabelAngle.Size = new System.Drawing.Size(68, 23);
			this.LabelAngle.TabIndex = 18;
			this.LabelAngle.Text = "Угол";
			this.LabelAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelHue
			// 
			this.LabelHue.AutoSize = true;
			this.animator1.SetDecoration(this.LabelHue, AnimatorNS.DecorationType.None);
			this.LabelHue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelHue.Location = new System.Drawing.Point(5, 2);
			this.LabelHue.Name = "LabelHue";
			this.LabelHue.Size = new System.Drawing.Size(68, 23);
			this.LabelHue.TabIndex = 17;
			this.LabelHue.Text = "Оттенок";
			this.LabelHue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ColorWheelBox);
			this.animator1.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Location = new System.Drawing.Point(12, 108);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox1.Size = new System.Drawing.Size(269, 255);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Цветовой круг";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.PreviewBox);
			this.animator1.SetDecoration(this.groupBox2, AnimatorNS.DecorationType.None);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox2.Location = new System.Drawing.Point(287, 217);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox2.Size = new System.Drawing.Size(256, 146);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Предпросмотр";
			// 
			// PreviewBox
			// 
			this.animator1.SetDecoration(this.PreviewBox, AnimatorNS.DecorationType.None);
			this.PreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PreviewBox.Location = new System.Drawing.Point(5, 18);
			this.PreviewBox.Name = "PreviewBox";
			this.PreviewBox.Size = new System.Drawing.Size(246, 123);
			this.PreviewBox.TabIndex = 0;
			this.PreviewBox.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.CheckBoxColors3);
			this.groupBox3.Controls.Add(this.CheckBoxColors2);
			this.groupBox3.Controls.Add(this.CheckBoxColors1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.TextBoxPaletteName);
			this.groupBox3.Controls.Add(this.BtnReset);
			this.animator1.SetDecoration(this.groupBox3, AnimatorNS.DecorationType.None);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(531, 89);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Свойства";
			// 
			// CheckBoxColors3
			// 
			this.CheckBoxColors3.AutoSize = true;
			this.CheckBoxColors3.Checked = true;
			this.CheckBoxColors3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.animator1.SetDecoration(this.CheckBoxColors3, AnimatorNS.DecorationType.None);
			this.CheckBoxColors3.Location = new System.Drawing.Point(11, 65);
			this.CheckBoxColors3.Name = "CheckBoxColors3";
			this.CheckBoxColors3.Size = new System.Drawing.Size(99, 17);
			this.CheckBoxColors3.TabIndex = 34;
			this.CheckBoxColors3.Text = "Темные цвета";
			this.CheckBoxColors3.UseVisualStyleBackColor = true;
			// 
			// CheckBoxColors2
			// 
			this.CheckBoxColors2.AutoSize = true;
			this.CheckBoxColors2.Checked = true;
			this.CheckBoxColors2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.animator1.SetDecoration(this.CheckBoxColors2, AnimatorNS.DecorationType.None);
			this.CheckBoxColors2.Location = new System.Drawing.Point(11, 42);
			this.CheckBoxColors2.Name = "CheckBoxColors2";
			this.CheckBoxColors2.Size = new System.Drawing.Size(90, 17);
			this.CheckBoxColors2.TabIndex = 33;
			this.CheckBoxColors2.Text = "Яркие цвета";
			this.CheckBoxColors2.UseVisualStyleBackColor = true;
			// 
			// CheckBoxColors1
			// 
			this.CheckBoxColors1.AutoSize = true;
			this.CheckBoxColors1.Checked = true;
			this.CheckBoxColors1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.animator1.SetDecoration(this.CheckBoxColors1, AnimatorNS.DecorationType.None);
			this.CheckBoxColors1.Location = new System.Drawing.Point(11, 19);
			this.CheckBoxColors1.Name = "CheckBoxColors1";
			this.CheckBoxColors1.Size = new System.Drawing.Size(105, 17);
			this.CheckBoxColors1.TabIndex = 32;
			this.CheckBoxColors1.Text = "Обычные цвета";
			this.CheckBoxColors1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.animator1.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
			this.label2.Location = new System.Drawing.Point(151, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "Имя палитры:";
			// 
			// TextBoxPaletteName
			// 
			this.animator1.SetDecoration(this.TextBoxPaletteName, AnimatorNS.DecorationType.None);
			this.TextBoxPaletteName.Location = new System.Drawing.Point(154, 32);
			this.TextBoxPaletteName.Name = "TextBoxPaletteName";
			this.TextBoxPaletteName.Size = new System.Drawing.Size(143, 20);
			this.TextBoxPaletteName.TabIndex = 30;
			this.TextBoxPaletteName.Text = "Новая палитра";
			// 
			// BtnReset
			// 
			this.animator1.SetDecoration(this.BtnReset, AnimatorNS.DecorationType.None);
			this.BtnReset.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnReset.Location = new System.Drawing.Point(153, 59);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(94, 23);
			this.BtnReset.TabIndex = 29;
			this.BtnReset.Text = "По умолчанию";
			this.BtnReset.UseVisualStyleBackColor = true;
			this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tableLayoutPanel1);
			this.animator1.SetDecoration(this.groupBox4, AnimatorNS.DecorationType.None);
			this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox4.Location = new System.Drawing.Point(287, 108);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox4.Size = new System.Drawing.Size(256, 103);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Параметры палитры";
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.animator1.SetDecoration(this.BtnOK, AnimatorNS.DecorationType.None);
			this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnOK.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnOK.Location = new System.Drawing.Point(340, 13);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(124, 25);
			this.BtnOK.TabIndex = 30;
			this.BtnOK.Text = "Добавить в палитру";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.animator1.SetDecoration(this.BtnCancel, AnimatorNS.DecorationType.None);
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnCancel.Location = new System.Drawing.Point(466, 13);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(77, 25);
			this.BtnCancel.TabIndex = 31;
			this.BtnCancel.Text = "Отмена";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
			this.alphaGradientPanel1.Controls.Add(this.BtnOK);
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
			this.alphaGradientPanel1.Location = new System.Drawing.Point(0, 370);
			this.alphaGradientPanel1.Name = "alphaGradientPanel1";
			this.alphaGradientPanel1.Rounded = false;
			this.alphaGradientPanel1.Size = new System.Drawing.Size(555, 50);
			this.alphaGradientPanel1.TabIndex = 32;
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
			// animator1
			// 
			this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
			this.animator1.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			this.animator1.DefaultAnimation = animation1;
			// 
			// PaletteGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 420);
			this.Controls.Add(this.alphaGradientPanel1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PaletteGeneratorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Генератор палитры";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.ColorWheelBox)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.alphaGradientPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
		private AnimatorNS.Animator animator1;
	}
}