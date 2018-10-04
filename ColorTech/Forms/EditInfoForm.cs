using System;
using System.Windows.Forms;

namespace ColorTech.Forms {
	public partial class EditInfoForm: Form {
		public string Author { get; set; }
		public string SiteLink { get; set; }
		public string Description { get; set; }

		public EditInfoForm(bool ReadOnly = false) {
			InitializeComponent();
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void BtnSave_Click(object sender, EventArgs e) {
			Author = TextBoxAuthor.Text;
			SiteLink = TextBoxSite.Text;
			Description = TextBoxDescription.Text;

			Close();
		}

		private void EditInfo_Load(object sender, EventArgs e) {
			MainForm main = this.Owner as MainForm;
			TextBoxAuthor.Text = main.PGD.Author;
			TextBoxSite.Text = main.PGD.SiteLink;
			TextBoxDescription.Text = main.PGD.Description;
		}
	}
}
