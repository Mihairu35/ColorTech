using System;
using System.Drawing;

namespace ColorTech.Core.FormatConverter {
	/// <summary>
	/// Структура модели цвета HSV
	/// </summary>
	public struct HSV {
		private double _h;
		private double _s;
		private double _v;

		public HSV(double h, double s, double v) {
			_h = h;
			_s = s;
			_v = v;
		}

		public double H {
			get { return _h; }
			set { _h = value; }
		}

		public double S {
			get { return _s; }
			set { _s = value; }
		}

		public double V {
			get { return _v; }
			set { _v = value; }
		}

		public bool Equals(HSV hsv) {
			return (H == hsv.H) && (S == hsv.S) && (V == hsv.V);
		}
	}

	public partial class ColorFormatConverter {
		public static HSV rgb2hsv(RGB rgb) {
			double delta, min;
			double h = 0, s, v;

			min = Math.Min(Math.Min(rgb.R, rgb.G), rgb.B);
			v = Math.Max(Math.Max(rgb.R, rgb.G), rgb.B);
			delta = v - min;

			if(v == 0.0)
				s = 0;
			else
				s = delta / v;

			if(s == 0)
				h = 0.0;

			else {
				if(rgb.R == v)
					h = (rgb.G - rgb.B) / delta;
				else if(rgb.G == v)
					h = 2 + (rgb.B - rgb.R) / delta;
				else if(rgb.B == v)
					h = 4 + (rgb.R - rgb.G) / delta;

				h *= 60;

				if(h < 0.0)
					h = h + 360;
			}

			return new HSV(h, s, (v / 255));
		}

		public static RGB hsv2rgb(HSV hsv) {
			double r = 0, g = 0, b = 0;

			if(hsv.S == 0) {
				r = hsv.V;
				g = hsv.V;
				b = hsv.V;
			} else {
				int i;
				double f, p, q, t;

				if(hsv.H == 360)
					hsv.H = 0;
				else
					hsv.H = hsv.H / 60;

				i = (int)Math.Truncate(hsv.H);
				f = hsv.H - i;

				p = hsv.V * (1.0 - hsv.S);
				q = hsv.V * (1.0 - (hsv.S * f));
				t = hsv.V * (1.0 - (hsv.S * (1.0 - f)));

				switch(i) {
					case 0:
					r = hsv.V;
					g = t;
					b = p;
					break;

					case 1:
					r = q;
					g = hsv.V;
					b = p;
					break;

					case 2:
					r = p;
					g = hsv.V;
					b = t;
					break;

					case 3:
					r = p;
					g = q;
					b = hsv.V;
					break;

					case 4:
					r = t;
					g = p;
					b = hsv.V;
					break;

					default:
					r = hsv.V;
					g = p;
					b = q;
					break;
				}

			}

			return new RGB((byte)(r * 255), (byte)(g * 255), (byte)(b * 255));
		}

		public static RGB hsv2rgb(double H, double S, double V) {
			HSV chsv = new HSV(H, S, V);
			return hsv2rgb(chsv);
		}

		public static HSV rgb2hsv(Color color) {
			RGB crgb = new RGB(color.R, color.G, color.B);
			return rgb2hsv(crgb);
		}

		public static HSV rgb2hsv(byte R, byte G, byte B) {
			RGB crgb = new RGB(R, G, B);
			return rgb2hsv(crgb);
		}

		public static Color CreateColorFromHSV(HSV hsv) {
			RGB crgb = hsv2rgb(hsv);
			return Color.FromArgb(crgb.R, crgb.G, crgb.B);
		}

		public static Color CreateColorFromHSV(double H, double S, double V) {
			RGB crgb = hsv2rgb(H, S, V);
			return Color.FromArgb(crgb.R, crgb.G, crgb.B);
		}
	}

}