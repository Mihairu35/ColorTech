using System;
using System.Windows.Forms;

namespace ColorTech {
	static class Program {
		[STAThread]
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);

			try {
				Application.Run(new MainForm(args[0]));
			} catch {
				Application.Run(new MainForm());
			}
		}
	}
}
