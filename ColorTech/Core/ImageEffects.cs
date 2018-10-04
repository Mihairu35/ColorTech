using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ColorTech.Core {
	class ImageEffects {
		public static void ResizeImg(ref Bitmap b, int nWidth, int nHeight) {
			using(Graphics g = Graphics.FromImage(b)) {
				g.InterpolationMode = InterpolationMode.NearestNeighbor;
				g.DrawImage(b, 0, 0, nWidth, nHeight);
				g.Dispose();
			}
		}

		public static void ResizeImg(ref Bitmap b, int x, int y, int nWidth, int nHeight) {
			using(Graphics g = Graphics.FromImage(b)) {
				g.InterpolationMode = InterpolationMode.NearestNeighbor;
				g.DrawImage(b, x, y, nWidth, nHeight);
				g.Dispose();
			}
		}

		public static Color GetContrastTextColor(Color bg) {
			int nThreshold = 105;
			int bgDelta = Convert.ToInt32((bg.R * 0.299) + (bg.G * 0.587) +
										  (bg.B * 0.114));

			Color foreColor = (255 - bgDelta < nThreshold) ? Color.Black : Color.White;
			return foreColor;
		}
	}
}
