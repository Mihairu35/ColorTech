using System;
using System.Windows.Forms;
using System.Diagnostics;

using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace ColorTech.Forms {

	partial class AboutForm: Form {
		public AboutForm() {
			InitializeComponent();
		}

		private void BtnSite_Click(object sender, EventArgs e) {
			Process.Start("https://quadvector.ru/");
		}

		private void BtnOK_Click(object sender, EventArgs e) {
			Close();
		}

		private void BtnCheckUpdate_Click(object sender, EventArgs e) {
			try {
				using(CheckUpdateForm CUForm = new CheckUpdateForm()) {
					CUForm.ShowDialog();
				}
			} catch { }
		}

		private void AboutForm_Load(object sender, EventArgs e) {
			this.Text = String.Format("О программе {0}", AssemblyInfo.AssemblyTitle);
			this.LabelProductName.Text = AssemblyInfo.AssemblyProduct;
			this.LabelVersion.Text = String.Format("Версия {0}", AssemblyInfo.AssemblyVersion);
			this.LabelCopyright.Text = AssemblyInfo.AssemblyCopyright;

			string html = Properties.Resources.about;
			TextBoxDescription.Text = html;
		}
	}
}