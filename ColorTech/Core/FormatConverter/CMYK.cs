using System;
using System.Drawing;

namespace ColorTech.Core.FormatConverter {
	/// <summary>
	/// Структура модели цвета HSL
	/// </summary>
	public struct CMYK {
		private double _c;
		private double _m;
		private double _y;
		private double _k;

		public CMYK(double c, double m, double y, double k) {
			_c = c;
			_m = m;
			_y = y;
			_k = k;
		}

		public double C {
			get { return _c; }
			set { _c = value; }
		}

		public double M {
			get { return _m; }
			set { _m = value; }
		}

		public double Y {
			get { return _y; }
			set { _y = value; }
		}

		public double K {
			get { return _k; }
			set { _k = value; }
		}

		public bool Equals(CMYK cmyk) {
			return (C == cmyk.C) && (M == cmyk.M) && (Y == cmyk.Y) && (K == cmyk.K);
		}
	}

	public partial class ColorFormatConverter {
		public static CMYK rgb2cmyk(RGB rgb) {
			double dr = (double)rgb.R / 255;
			double dg = (double)rgb.G / 255;
			double db = (double)rgb.B / 255;
			double k = 1 - Math.Max(Math.Max(dr, dg), db);
			double c = (1 - dr - k) / (1 - k);
			double m = (1 - dg - k) / (1 - k);
			double y = (1 - db - k) / (1 - k);

			return new CMYK(c, m, y, k);
		}

		public static RGB cmyk2rgb(CMYK cmyk) {
			byte r = (byte)(255 * (1 - cmyk.C) * (1 - cmyk.K));
			byte g = (byte)(255 * (1 - cmyk.M) * (1 - cmyk.K));
			byte b = (byte)(255 * (1 - cmyk.Y) * (1 - cmyk.K));

			return new RGB(r, g, b);
		}

		public static RGB cmyk2rgb(double C, double M, double Y, double K) {
			CMYK ccmyk = new CMYK(C, M, Y, K);
			return cmyk2rgb(ccmyk);
		}

		public static CMYK rgb2cmyk(Color color) {
			RGB crgb = new RGB(color.R, color.G, color.B);
			return rgb2cmyk(crgb);
		}

		public static CMYK rgb2cmyk(byte R, byte G, byte B) {
			RGB crgb = new RGB(R, G, B);
			return rgb2cmyk(crgb);
		}

		public static Color CreateColorFromCMYK(CMYK cmyk) {
			RGB ccmyk = cmyk2rgb(cmyk);
			return Color.FromArgb(ccmyk.R, ccmyk.G, ccmyk.B);
		}

		public static Color CreateColorFromCMYK(double C, double M, double Y, double K) {
			RGB ccmyk = cmyk2rgb(C, M, Y, K);
			return Color.FromArgb(ccmyk.R, ccmyk.G, ccmyk.B);
		}
	}
}
