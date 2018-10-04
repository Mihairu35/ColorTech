using System.Drawing;
using System.Drawing.Drawing2D;
using ColorTech.Core.FormatConverter;

namespace ColorTech.Core.Drawing {
	public class Circle {
		public int x { get; set; }
		public int y { get; set; }
		public float radius { get; set; }
		public Color FillColor { get; set; }
		public Color BorderColor { get; set; }
	}


	class NewMainGRaphics {
		private Graphics GR;

		public NewMainGRaphics(Graphics _graphics) {
			GR = _graphics;
		}

		public void DrawCircle(Circle circle) {
			using(Pen p1 = new Pen(circle.BorderColor)) {
				GR.DrawEllipse(p1, circle.x, circle.y, circle.radius * 2, circle.radius * 2);
			}
		}

		public void FillCircle(Circle circle) {
			using(SolidBrush b1 = new SolidBrush(circle.FillColor)) {
				GR.FillEllipse(b1, circle.x, circle.y, circle.radius * 2, circle.radius * 2);
			}
		}

		public void FillDrawCircle(Circle circle) {
			FillCircle(circle);
			DrawCircle(circle);
		}

		public void DrawColorWheel(Color outline_color, int x = 0, int y = 0, int wid = 100, int hgt = 100, int value = 255) {
			Rectangle rect = new Rectangle(x, y, wid, hgt);
			GraphicsPath wheel_path = new GraphicsPath();
			wheel_path.AddEllipse(rect);
			wheel_path.Flatten();

			float num_pts = (wheel_path.PointCount - 1) / 7;
			Color[] surround_colors = new Color[wheel_path.PointCount];
			//цвета палитры (цвета радуги)
			Color[] PaletteColors = new Color[7] {
				Color.Red,
				Color.Orange,
				Color.Yellow,
				Color.Green,
				Color.Aqua,
				Color.Blue,
				Color.Purple
			};

			//преобразуем RGB цвета в HSV для изменения яркости
			double colorV = value / 255d;
			for(int i = 0; i < 7; i++) {
				HSV hsv = ColorFormatConverter.rgb2hsv(PaletteColors[i]);
				hsv.V = colorV;

				PaletteColors[i] = ColorFormatConverter.CreateColorFromHSV(hsv);
			}

			//также обрабатываем центральный белый цвет
			HSV WhiteHSV = ColorFormatConverter.rgb2hsv(Color.White);
			WhiteHSV.V = colorV;
			Color WhiteColor = ColorFormatConverter.CreateColorFromHSV(WhiteHSV);

			//интерполяция цветов
			int index = 0;
			for(int i = 0; i < 6; i++) {
				Color c1 = PaletteColors[i];
				Color c2 = PaletteColors[i + 1];
				PaletteColor.InterpolateColors(surround_colors, ref index, (i + 1) * num_pts, 255, c1.R, c1.G, c1.B, 255, c2.R, c2.G, c2.B);
			}
			PaletteColor.InterpolateColors(surround_colors, ref index, wheel_path.PointCount, 255, PaletteColors[6].R, PaletteColors[6].G, PaletteColors[6].B, 255, PaletteColors[0].R, PaletteColors[0].G, PaletteColors[0].B);

			//рисуем круговую палитру
			using(PathGradientBrush path_brush = new PathGradientBrush(wheel_path)) {
				path_brush.CenterColor = WhiteColor; //центральный белый цвет
				path_brush.SurroundColors = surround_colors; //список цветов для кругового градиента
				GR.Clear(Color.Transparent);

				GR.FillPath(path_brush, wheel_path);
				using(Pen thick_pen = new Pen(outline_color, 2)) {
					GR.DrawPath(thick_pen, wheel_path);
				}
			}
		}
	}
}
