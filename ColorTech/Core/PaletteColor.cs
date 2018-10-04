using System.Drawing;
using ColorTech.Core.FormatConverter;
using System.Windows.Forms;

namespace ColorTech.Core {
	public class PaletteColor {
		public Color MainColor { get; private set; }
		public RGB rgb { get; private set; }
		public HSV hsv { get; private set; }

		public PaletteColor(Color _MainColor) {
			SetColor(_MainColor);
		}

		public void SetColor(Color _MainColor) {
			MainColor = _MainColor;
			rgb = new RGB(_MainColor.R, _MainColor.G, _MainColor.B);
			hsv = ColorFormatConverter.rgb2hsv(_MainColor);
		}

		public void SetColor(RGB RGB) {
			SetColor(Color.FromArgb(RGB.R, RGB.G, RGB.B));
		}

		public void SetColor(HSV HSV) {
			hsv = HSV;
			rgb = ColorFormatConverter.hsv2rgb(HSV);
			MainColor = Color.FromArgb(rgb.R, rgb.G, rgb.B);
		}

		//интерполяция цветов
		public static void InterpolateColors(Color[] surround_colors,
			ref int index, float stop_pt,
			int from_a, int from_r, int from_g, int from_b,
			int to_a, int to_r, int to_g, int to_b) {
			int num_pts = (int)stop_pt - index;
			float a = from_a, r = from_r, g = from_g, b = from_b;
			float da = (to_a - from_a) / (num_pts - 1);
			float dr = (to_r - from_r) / (num_pts - 1);
			float dg = (to_g - from_g) / (num_pts - 1);
			float db = (to_b - from_b) / (num_pts - 1);

			for(int i = 0; i < num_pts; i++) {
				surround_colors[index++] =
					Color.FromArgb((int)a, (int)r, (int)g, (int)b);
				a += da;
				r += dr;
				g += dg;
				b += db;
			}
		}

		public static Color GetDarkerColor(Color color) {
			return ControlPaint.Dark(color);
		}

		public static Color GetLighterColor(Color color) {
			return ControlPaint.Light(color);
		}
	}

}
