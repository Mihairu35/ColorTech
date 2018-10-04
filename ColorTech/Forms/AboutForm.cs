using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ColorTech.Forms {
	partial class AboutForm: Form {
		public AboutForm() {
			InitializeComponent();
			this.Text = String.Format("О программе {0}", AssemblyInfo.AssemblyTitle);
			this.LabelProductName.Text = AssemblyInfo.AssemblyProduct;
			this.LabelVersion.Text = String.Format("Версия {0}", AssemblyInfo.AssemblyVersion);
			this.LabelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			this.TextBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}

		private void BtnSite_Click(object sender, EventArgs e) {
			Process.Start("https://quadvector.ru/");
		}

		private void BtnOK_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
