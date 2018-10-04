using System.Drawing;

namespace ColorTech.Core.FormatConverter {
	public partial class ColorFormatConverter {
		public static Color GetBlackAndWhite(Color color) {
			int rgb = (int)((color.R + color.G + color.B) / 3);
			return Color.FromArgb(rgb, rgb, rgb);
		}

		public static string GetHEX(Color color) {
			return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}

		public static Color CreateColorFromHEX(string hex) {
			hex.Replace("##", "#"); //во избежание ошибки убираем лишние решетки
									//если решетки нет, до добавляем одну для форматирования
			if(hex.IndexOf("#") == -1) {
				hex = "#" + hex;
			}

			try {
				return ColorTranslator.FromHtml(hex);
			} catch {
				return Color.White; //если произошла ошибка получения цвета, то возвращаем белый
			}
		}
	}
}
