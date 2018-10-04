using System;
using System.Drawing;
using ColorTech.Core.FormatConverter;

namespace ColorTech.Core {
	public interface IColorFormatStrategy {
		string GetColorString(Color color);
		Color GetColorByString(string colorFormat);
	}

	public class HTMLHexStrategy: IColorFormatStrategy {
		public string GetColorString(Color color) {
			return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}

		public Color GetColorByString(string format) {
			return ColorFormatConverter.CreateColorFromHEX(format);
		}
	}

	public class DelphiHexStrategy: IColorFormatStrategy {
		public string GetColorString(Color color) {
			return "$00" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}

		public Color GetColorByString(string format) {
			format = format.Replace("$00", "#");
			return ColorFormatConverter.CreateColorFromHEX(format);
		}
	}

	public class VBHexStrategy: IColorFormatStrategy {
		public string GetColorString(Color color) {
			return "&H" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}

		public Color GetColorByString(string vbhex) {
			vbhex = vbhex.Replace("&H", "#");
			return ColorFormatConverter.CreateColorFromHEX(vbhex);
		}
	}

	public class CPPHexStrategy: IColorFormatStrategy {
		public string GetColorString(Color color) {
			return "0x00" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}

		public Color GetColorByString(string format) {
			format = format.Replace("0x00", "#");
			return ColorFormatConverter.CreateColorFromHEX(format);
		}
	}

	public class RGBStrategy: IColorFormatStrategy {
		public string GetColorString(Color color) {
			return color.R + "," + color.G + "," + color.B;
		}

		public Color GetColorByString(string format) {
			string[] SplitColor = format.Replace(" ", "").Split(',');

			return Color.FromArgb(Int32.Parse(SplitColor[0]), Int32.Parse(SplitColor[1]), Int32.Parse(SplitColor[2]));
		}
	}

	public class RGBPercentStrategy :IColorFormatStrategy {
		public string GetColorString(Color color) {
			return Math.Round(color.R / 255d * 100) + "," + Math.Round(color.G / 255d * 100) + "," + Math.Round(color.B / 255d * 100);
		}

		public Color GetColorByString(string format) {
			string[] SplitColor = format.Replace(" ", "").Split(',');

			int R = Convert.ToInt32(Math.Round(Int32.Parse(SplitColor[0]) / 100d * 255d));
			int G = Convert.ToInt32(Math.Round(Int32.Parse(SplitColor[1]) / 100d * 255d));
			int B = Convert.ToInt32(Math.Round(Int32.Parse(SplitColor[2]) / 100d * 255d));

			return Color.FromArgb(R, G, B);
		}
	}

	public class PowerbuilderStrategy :IColorFormatStrategy {
		public string GetColorString(Color color) {
			return (color.B * 65536 + color.G * 256 + color.R).ToString();
		}

		public Color GetColorByString(string format) {
			int pbuilder = Int32.Parse(format);
			int B = pbuilder / 65536;
			int G = (pbuilder - B * 65536) / 256;
			int R = (pbuilder - B * 65536) - G * 256;
			return Color.FromArgb(R, G, B);
		}
	}

	public class HSBStrategy :IColorFormatStrategy {
		public string GetColorString(Color color) {
			HSV result = ColorFormatConverter.rgb2hsv(color.R, color.G, color.B);

			return Math.Round(result.H) + "," + Math.Round(result.S * 255) + "," + Math.Round(result.V * 255);
		}

		public Color GetColorByString(string format) {
			string[] SplitFormat = format.Replace(" ", "").Split(',');
			double H = Int32.Parse(SplitFormat[0]);
			double S = Int32.Parse(SplitFormat[1]);
			double V = Int32.Parse(SplitFormat[2]);

			return ColorFormatConverter.CreateColorFromHSV(H, S / 255, V / 255);
		}
	}

	public class CMYKStrategy :IColorFormatStrategy {
		public string GetColorString(Color color) {
			CMYK cmyk = ColorFormatConverter.rgb2cmyk(color);

			return Math.Round(cmyk.C * 100) + "," + Math.Round(cmyk.M * 100) + "," + Math.Round(cmyk.Y * 100) + "," + Math.Round(cmyk.K * 100);
		}

		public Color GetColorByString(string format) {
			string[] SplitFormat = format.Replace(" ", "").Split(',');
			double C = Int32.Parse(SplitFormat[0]);
			double M = Int32.Parse(SplitFormat[1]);
			double Y = Int32.Parse(SplitFormat[2]);
			double K = Int32.Parse(SplitFormat[3]);

			return ColorFormatConverter.CreateColorFromCMYK(C / 100, M / 100, Y / 100, K / 100);
		}
	}


	public class HSLStrategy :IColorFormatStrategy {
		public string GetColorString(Color color) {
			HSL hsl = ColorFormatConverter.rgb2hsl(color);

			return Math.Round(hsl.H) + "," + Math.Round(hsl.S * 100) + "%," + Math.Round(hsl.L * 100) + "%";
		}

		public Color GetColorByString(string format) {
			string[] SplitFormat = format.Replace(" ", "").Replace("%", "").Split(',');
			double H = Int32.Parse(SplitFormat[0]);
			double S = Int32.Parse(SplitFormat[1]);
			double L = Int32.Parse(SplitFormat[2]);

			return ColorFormatConverter.CreateColorFromHSL(H, S / 100, L / 100);
		}
	}

	public class CMYStrategy :IColorFormatStrategy {
		public string GetColorString(Color color) {
			CMY cmy = ColorFormatConverter.rgb2cmy(color);

			return cmy.C + "," + cmy.M + "," + cmy.Y;
		}

		public Color GetColorByString(string format) {
			string[] SplitFormat = format.Replace(" ", "").Split(',');
			double C = Int32.Parse(SplitFormat[0]);
			double M = Int32.Parse(SplitFormat[1]);
			double Y = Int32.Parse(SplitFormat[2]);

			return ColorFormatConverter.CreateColorFromCMY((byte)C, (byte)M, (byte)Y);
		}
	}

	public class PhotoshopStrategy :IColorFormatStrategy {
		public string GetColorString(Color color) {
			return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}

		public Color GetColorByString(string hex) {
			if(hex.IndexOf('#') != -1) {
				hex = hex.Replace("#", "");
			}
			return ColorFormatConverter.CreateColorFromHEX(hex);
		}
	}

	public class ColorStringFormatContext {
		public IColorFormatStrategy ContextStrategy { get; set; }

		public ColorStringFormatContext(IColorFormatStrategy _strategy) {
			ContextStrategy = _strategy;
		}

		public void SetStrategy(IColorFormatStrategy _strategy) {
			ContextStrategy = _strategy;
		}

		public Color GetColor(string format) {
			return ContextStrategy.GetColorByString(format);
		}

		public string GetColorFormat(Color color) {
			return ContextStrategy.GetColorString(color);
		}
	}
}
