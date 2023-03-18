using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Collections.Generic;
using FastBitmapLib;
using ColorTech.Core;
using ColorTech.Core.Drawing;
using System.Windows.Forms;

namespace ColorTech.Forms {

	public partial class PaletteGeneratorForm: Form {
		Bitmap MainBMP;
		Graphics MainGR;
		NewMainGRaphics NewMainGR;

		Bitmap PreviewBMP;
		Graphics PreviewGR;

		List<RotateCircle> RotateHueCircles = new List<RotateCircle>();
		List<RotateCircle> RotateAngleCircles = new List<RotateCircle>();

		Circle MainCircle;
		int ColorWheelRadius;
		int PreviewCellsCount = 4;

		public List<Color> SelectedColors { get; set; }
		public string PaletteName { get; set; }

		public PaletteGeneratorForm() {
			InitializeComponent();

			MainBMP = new Bitmap(ColorWheelBox.Width, ColorWheelBox.Height);
			MainGR = Graphics.FromImage(MainBMP);
			NewMainGR = new NewMainGRaphics(MainGR);
			MainGR.SmoothingMode = SmoothingMode.AntiAlias;
			MainGR.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

			PreviewBMP = new Bitmap(PreviewBox.Width, PreviewBox.Height);
			PreviewGR = Graphics.FromImage(PreviewBMP);
			PreviewGR.SmoothingMode = SmoothingMode.HighSpeed;
			PreviewGR.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

			SelectedColors = new List<Color>();

			MainCircle = new Circle() {
				radius = 100,
				BorderColor = Color.Black
			};

			RotateHueCircles.Add(new RotateCircle() { circle = new Circle() { radius = 10 * ColorWheelBox.Height / 363, BorderColor = Color.White, FillColor = Color.FromArgb(127, 0, 0, 0) } });
			RotateHueCircles.Add(new RotateCircle() { circle = new Circle() { radius = 10 * ColorWheelBox.Height / 363, BorderColor = Color.White, FillColor = Color.FromArgb(127, 0, 0, 0) } });

			RotateAngleCircles.Add(new RotateCircle() { circle = new Circle() { radius = 10 * ColorWheelBox.Height / 363, BorderColor = Color.Black, FillColor = Color.FromArgb(127, 255, 255, 255) } });
			RotateAngleCircles.Add(new RotateCircle() { circle = new Circle() { radius = 10 * ColorWheelBox.Height / 363, BorderColor = Color.Black, FillColor = Color.FromArgb(127, 255, 255, 255) } });

			ColorWheelRadius = 150 * ColorWheelBox.Height / 363;

			tableLayoutPanel1.SuspendLayout();

			SliderAngle.Value = 90;
			SliderHue.Value = 0;
			SliderVal.Value = 255;
		}

		private void UpdateColors() {
			using(FastBitmap FBMP = MainBMP.FastLock()) {
				if(CheckBoxColors1.Checked) {
					for(int i = 0; i < RotateHueCircles.Count; i++) {
						SelectedColors.Add(FBMP.GetPixel(RotateHueCircles[i].circle.x - 10, RotateHueCircles[i].circle.y));
					}

					for(int i = 0; i < RotateAngleCircles.Count; i++) {
						SelectedColors.Add(FBMP.GetPixel(RotateAngleCircles[i].circle.x - 10, RotateAngleCircles[i].circle.y));
					}
				}

				if(CheckBoxColors2.Checked) {
					for(int i = 0; i < RotateHueCircles.Count; i++) {
						SelectedColors.Add(PaletteColor.GetLighterColor(FBMP.GetPixel(RotateHueCircles[i].circle.x - 10, RotateHueCircles[i].circle.y)));
					}

					for(int i = 0; i < RotateAngleCircles.Count; i++) {
						SelectedColors.Add(PaletteColor.GetLighterColor(FBMP.GetPixel(RotateAngleCircles[i].circle.x - 10, RotateAngleCircles[i].circle.y)));
					}
				}

				if(CheckBoxColors3.Checked) {
					for(int i = 0; i < RotateHueCircles.Count; i++) {
						SelectedColors.Add(PaletteColor.GetDarkerColor(FBMP.GetPixel(RotateHueCircles[i].circle.x - 10, RotateHueCircles[i].circle.y)));
					}

					for(int i = 0; i < RotateAngleCircles.Count; i++) {
						SelectedColors.Add(PaletteColor.GetDarkerColor(FBMP.GetPixel(RotateAngleCircles[i].circle.x - 10, RotateAngleCircles[i].circle.y)));
					}
				}
			}
		}

		private void DrawTimer_Tick(object sender, EventArgs e) {
			MainGR.Clear(Color.White);

			NewMainGR.DrawColorWheel(SystemColors.Control, ColorWheelBox.Width / 2 - ColorWheelRadius, ColorWheelBox.Height / 2 - ColorWheelRadius, (int)ColorWheelRadius * 2, ColorWheelRadius * 2, SliderVal.Value);

			MainCircle.radius = 100 * ColorWheelBox.Height / 363;
			MainCircle.x = (int)(ColorWheelBox.Width / 2 - MainCircle.radius);
			MainCircle.y = (int)(ColorWheelBox.Height / 2 - MainCircle.radius);
			NewMainGR.DrawCircle(MainCircle);

			for(int i = 0; i < RotateHueCircles.Count; i++) {
				RotateHueCircles[i].circle.x = (int)(MainCircle.x + MainCircle.radius - RotateHueCircles[i].circle.radius + (float)(MainCircle.radius * Math.Cos(Math.PI / 180 * (RotateHueCircles[i].angle + (360 / (RotateHueCircles.Count)) * i))));
				RotateHueCircles[i].circle.y = (int)(MainCircle.y + MainCircle.radius - RotateHueCircles[i].circle.radius + (float)(MainCircle.radius * Math.Sin(Math.PI / 180 * (RotateHueCircles[i].angle + (360 / (RotateHueCircles.Count)) * i))));
				NewMainGR.FillDrawCircle(RotateHueCircles[i].circle);
			}


			for(int i = 0; i < RotateAngleCircles.Count; i++) {
				RotateAngleCircles[i].circle.x = (int)(MainCircle.x + MainCircle.radius - RotateAngleCircles[i].circle.radius + (float)(MainCircle.radius * Math.Cos(Math.PI / 180 * (RotateAngleCircles[i].angle + SliderHue.Value + (360 / (RotateAngleCircles.Count)) * i))));
				RotateAngleCircles[i].circle.y = (int)(MainCircle.y + MainCircle.radius - RotateAngleCircles[i].circle.radius + (float)(MainCircle.radius * Math.Sin(Math.PI / 180 * (RotateAngleCircles[i].angle + SliderHue.Value + (360 / (RotateAngleCircles.Count)) * i))));
				NewMainGR.FillDrawCircle(RotateAngleCircles[i].circle);
			}

			ColorWheelBox.Image = MainBMP;

			UpdateColors();

			//рисуем просмотр цвета
			PreviewGR.Clear(Color.Transparent);
			float SquareWidth = 40;
			int PreviewRowsCount = 0;
			int StartCellPosition = 0;
			for(int i = 0; i < SelectedColors.Count; i++) {
				if((i % PreviewCellsCount == 0) && i != 0) {
					PreviewRowsCount++;
					StartCellPosition = 0;
				}
				using(SolidBrush b1 = new SolidBrush(SelectedColors[i])) {
					PreviewGR.FillRectangle(b1, StartCellPosition * SquareWidth, PreviewRowsCount * SquareWidth, SquareWidth, SquareWidth);
				}
				StartCellPosition++;
			}
			PreviewBox.Image = PreviewBMP;

			SelectedColors.Clear();
		}

		private void SliderHue_ValueChanged(object sender, EventArgs e) {
			for(int i = 0; i < RotateHueCircles.Count; i++) {
				RotateHueCircles[i].angle = SliderHue.Value;
			}
			LabelHueValue.Text = SliderHue.Value.ToString();
		}

		private void SliderAngle_ValueChanged(object sender, EventArgs e) {
			for(int i = 0; i < RotateAngleCircles.Count; i++) {
				RotateAngleCircles[i].angle = SliderAngle.Value;
			}

			LabelAngleValue.Text = SliderAngle.Value.ToString();
		}

		private void SliderVal_ValueChanged(object sender, EventArgs e) {
			LabelValValue.Text = SliderVal.Value.ToString();
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void BtnOK_Click(object sender, EventArgs e) {
			this.PaletteName = TextBoxPaletteName.Text;
			UpdateColors();
			Close();
		}

		private void BtnReset_Click(object sender, EventArgs e) {
			CheckBoxColors1.Checked = true;
			CheckBoxColors2.Checked = true;
			CheckBoxColors3.Checked = true;

			SliderHue.Value = 0;
			SliderAngle.Value = 90;
			SliderVal.Value = 255;

			TextBoxPaletteName.Text = "Новая палитра";
		}
	}

	public class RotateCircle {
		public Circle circle { get; set; }
		public float angle { get; set; }
	}

}
