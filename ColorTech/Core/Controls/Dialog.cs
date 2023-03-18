using System.Windows.Forms;
using System.Drawing;
using Krypton.Toolkit;

namespace ColorTech.Forms {
	public static class Dialog {
		public static DialogResult InputBox(string title, string promptText, ref string value) {
			Form form = new Form();
			KryptonLabel label = new KryptonLabel();
			KryptonTextBox textBox = new KryptonTextBox();
			KryptonButton buttonOk = new KryptonButton();
            KryptonButton buttonCancel = new KryptonButton();

			buttonOk.Text = "OK";
			buttonCancel.Text = "Отмена";
			buttonOk.DialogResult = DialogResult.OK;
			buttonCancel.DialogResult = DialogResult.Cancel;

			label.SetBounds(8, 15, 372, 13);
			textBox.SetBounds(12, 35, 278, 30);
			buttonOk.SetBounds(134, 65, 75, 23);
			buttonCancel.SetBounds(214, 65, 75, 23);

			label.AutoSize = true;
			label.Text = promptText;
			label.LabelStyle = LabelStyle.NormalPanel;
			textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
			textBox.Text = value;
			buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

			form.ClientSize = new Size(300, 110);
			form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
			form.StartPosition = FormStartPosition.CenterScreen;
			form.MinimizeBox = false;
			form.MaximizeBox = false;
			form.AcceptButton = buttonOk;
			form.CancelButton = buttonCancel;
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.Text = title;
			form.StartPosition = FormStartPosition.CenterParent;
            form.TopMost = true;

			DialogResult dialogResult = form.ShowDialog();
			value = textBox.Text;
			return dialogResult;
		}
	}
}
