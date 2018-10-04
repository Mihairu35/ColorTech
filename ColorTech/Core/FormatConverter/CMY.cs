using System.Drawing;

namespace ColorTech.Core.FormatConverter {
	public struct CMY {
		private byte _c;
		private byte _m;
		private byte _y;

		public CMY(byte c, byte m, byte y) {
			_c = c;
			_m = m;
			_y = y;
		}

		public byte C {
			get { return _c; }
			set { _c = value; }
		}

		public byte M {
			get { return _m; }
			set { _m = value; }
		}

		public byte Y {
			get { return _y; }
			set { _y = value; }
		}

		public bool Equals(CMY cmy) {
			return (C == cmy.C) && (M == cmy.M) && (Y == cmy.Y);
		}
	}

	public partial class ColorFormatConverter {
		public static CMY rgb2cmy(RGB rgb) {
			return new CMY((byte)(255 - rgb.R), (byte)(255 - rgb.G), (byte)(255 - rgb.B));
		}

		public static RGB cmy2rgb(CMY cmy) {
			return new RGB((byte)(255 - cmy.C), (byte)(255 - cmy.M), (byte)(255 - cmy.Y));
		}

		public static RGB cmy2rgb(byte C, byte M, byte Y) {
			CMY ccmy = new CMY(C, M, Y);
			return cmy2rgb(ccmy);
		}

		public static CMY rgb2cmy(Color color) {
			RGB crgb = new RGB(color.R, color.G, color.B);
			return rgb2cmy(crgb);
		}

		public static CMY rgb2cmy(byte R, byte G, byte B) {
			RGB crgb = new RGB(R, G, B);
			return rgb2cmy(crgb);
		}

		public static Color CreateColorFromCMY(CMY cmy) {
			RGB ccmy = cmy2rgb(cmy);
			return Color.FromArgb(ccmy.R, ccmy.G, ccmy.B);
		}

		public static Color CreateColorFromCMY(byte C, byte M, byte Y) {
			RGB ccmy = cmy2rgb(C, M, Y);
			return Color.FromArgb(ccmy.R, ccmy.G, ccmy.B);
		}
	}
}
