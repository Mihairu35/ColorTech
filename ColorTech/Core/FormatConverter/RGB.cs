namespace ColorTech.Core.FormatConverter {
	/// <summary>
	///		Структура модели цвета RGB
	/// </summary>
	public struct RGB {
		private byte _r;
		private byte _g;
		private byte _b;

		public RGB(byte r, byte g, byte b) {
			_r = r;
			_g = g;
			_b = b;
		}

		public byte R {
			get { return _r; }
			set { _r = value; }
		}

		public byte G {
			get { return _g; }
			set { _g = value; }
		}

		public byte B {
			get { return _b; }
			set { _b = value; }
		}

		public bool Equals(RGB rgb) {
			return (R == rgb.R) && (G == rgb.G) && (B == rgb.B);
		}
	}
}
