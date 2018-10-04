using System;
using System.Drawing;

namespace ColorTech.Core.FormatConverter {
	/// <summary>
	/// Структура модели цвета HSL
	/// </summary>
	public struct HSL {
		private double _h;
		private double _s;
		private double _l;

		public HSL(double h, double s, double l) {
			_h = h;
			_s = s;
			_l = l;
		}

		public double H {
			get { return _h; }
			set { _h = value; }
		}

		public double S {
			get { return _s; }
			set { _s = value; }
		}

		public double L {
			get { return _l; }
			set { _l = value; }
		}

		public bool Equals(HSL hsl) {
			return (H == hsl.H) && (S == hsl.S) && (L == hsl.L);
		}
	}

	public partial class ColorFormatConverter {
		private static double HueToRGB(double v1, double v2, double vH) {
			if(vH < 0)
				vH += 1;

			if(vH > 1)
				vH -= 1;

			if((6 * vH) < 1)
				return (v1 + (v2 - v1) * 6 * vH);

			if((2 * vH) < 1)
				return v2;

			if((3 * vH) < 2)
				return (v1 + (v2 - v1) * ((2.0f / 3) - vH) * 6);

			return v1;
		}

		public static HSL rgb2hsl(RGB rgb) {
			HSL hsl = new HSL();

			double r = (rgb.R / 255d);
			double g = (rgb.G / 255d);
			double b = (rgb.B / 255d);

			double min = Math.Min(Math.Min(r, g), b);
			double max = Math.Max(Math.Max(r, g), b);
			double delta = max - min;

			hsl.L = (max + min) / 2;

			if(delta == 0) {
				hsl.H = 0;
				hsl.S = 0.0f;
			} else {
				hsl.S = (hsl.L <= 0.5) ? (delta / (max + min)) : (delta / (2 - max - min));

				double hue;

				if(r == max) {
					hue = ((g - b) / 6) / delta;
				} else if(g == max) {
					hue = (1.0f / 3) + ((b - r) / 6) / delta;
				} else {
					hue = (2.0f / 3) + ((r - g) / 6) / delta;
				}

				if(hue < 0)
					hue += 1;
				if(hue > 1)
					hue -= 1;

				hsl.H = (int)(hue * 360);
			}

			return hsl;
		}

		public static RGB hsl2rgb(HSL hsl) {
			byte r = 0;
			byte g = 0;
			byte b = 0;


			if(hsl.S == 0) {
				r = g = b = (byte)(hsl.L * 255);
			} else {
				double v1, v2;
				double hue = (double)hsl.H / 360;

				v2 = (hsl.L < 0.5) ? (hsl.L * (1 + hsl.S)) : ((hsl.L + hsl.S) - (hsl.L * hsl.S));
				v1 = 2 * hsl.L - v2;

				r = (byte)(255 * HueToRGB(v1, v2, hue + (1.0f / 3)));
				g = (byte)(255 * HueToRGB(v1, v2, hue));
				b = (byte)(255 * HueToRGB(v1, v2, hue - (1.0f / 3)));
			}

			return new RGB(r, g, b);
		}

		public static RGB hsl2rgb(double H, double S, double L) {
			HSL chsl = new HSL(H, S, L);
			return hsl2rgb(chsl);
		}

		public static HSL rgb2hsl(Color color) {
			RGB crgb = new RGB(color.R, color.G, color.B);
			return rgb2hsl(crgb);
		}

		public static HSL rgb2hsl(byte R, byte G, byte B) {
			RGB crgb = new RGB(R, G, B);
			return rgb2hsl(crgb);
		}

		public static Color CreateColorFromHSL(HSL hsl) {
			RGB crgb = hsl2rgb(hsl);
			return Color.FromArgb(crgb.R, crgb.G, crgb.B);
		}

		public static Color CreateColorFromHSL(double H, double S, double L) {
			RGB crgb = hsl2rgb(H, S, L);
			return Color.FromArgb(crgb.R, crgb.G, crgb.B);
		}
	}
}
