using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ColorTech.Forms {
	public partial class PaletteInfoForm: Form {
		public PaletteInfoForm() {
			InitializeComponent();
		}

		private void BtnClose_Click(object sender, EventArgs e) {
			Close();
		}

		private void PaletteInfo_Load(object sender, EventArgs e) {
			MainForm main = this.Owner as MainForm;
			LabelAuthorValue.Text = main.PGD.Author;
			LabelSiteValue.Text = main.PGD.SiteLink;
			TextBoxDescription.Text = main.PGD.Description;
		}

		private void LabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			string link = LabelSiteValue.Text;
			if(!link.Contains("http://")) {
				link = "http://" + link;
				Process.Start(link);
			}
		}
	}
}
