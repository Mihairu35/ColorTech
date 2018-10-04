using System.Drawing;
using System.Collections.Generic;

namespace ColorTech.Core {

	//originator
	public class PaletteOriginator {
		private MainForm MainForm { get; set; }

		public PaletteOriginator(MainForm _MainForm) {
			MainForm = _MainForm;
		}

		public PaletteMemento SavePaletteState() {
			return new PaletteMemento(MainForm.Color1.MainColor);
		}

		public void LoadColorState(PaletteMemento memento) {
			MainForm.Color1.SetColor(memento.Color);
		}
	}

	//memento
	public class PaletteMemento {
		public Color Color { get; private set; }

		public PaletteMemento(Color _Color) {
			Color = _Color;
		}
	}

	//caretaker
	public class PaletteHistory {
		public List<PaletteMemento> History { get; set; }
		public int ActiveIndex { get; set; }

		public PaletteHistory() {
			History = new List<PaletteMemento>();
			ActiveIndex = 0;
		}
	}
}
