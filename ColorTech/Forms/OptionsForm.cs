using System;
using System.Windows.Forms;

namespace ColorTech.Forms {
	public partial class OptionsForm: Form {
		public OptionsForm() {
			InitializeComponent();
		}

		private void BtnSave_Click(object sender, EventArgs e) {
            Properties.Settings.Default.StartProgrammOnStartup = Option1.Checked;
            Properties.Settings.Default.ShowOnTray = Option2.Checked;
            Properties.Settings.Default.ColorFormatUppercase = Option3.Checked;
            Properties.Settings.Default.PopupWindow = Option4.Checked;
            Properties.Settings.Default.OpenUpdateWindow = Option5.Checked;
            Properties.Settings.Default.BackgroundCheckUpdate = Option6.Checked;
			Properties.Settings.Default.Save();
        }

		private void OptionsForm_Load(object sender, EventArgs e) {
			Option1.Checked = Properties.Settings.Default.StartProgrammOnStartup;
			Option2.Checked = Properties.Settings.Default.ShowOnTray;
			Option3.Checked = Properties.Settings.Default.ColorFormatUppercase;
            Option4.Checked = Properties.Settings.Default.PopupWindow;
            Option5.Checked = Properties.Settings.Default.OpenUpdateWindow;
			Option6.Checked = Properties.Settings.Default.BackgroundCheckUpdate;
		}

		private void BtnCancel_Click(object sender, EventArgs e) {

		}
	}
}
