using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using System.Net;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using ColorTech.Core;

namespace ColorTech.Forms {
	public partial class CheckUpdateForm :Form {
		private UpdateVersion UpdateInfo { get; set; }
		private string InstallTmpPath { get; set; }

		public CheckUpdateForm() {
			InitializeComponent();
		}

		private void Task_GetUpdateInfo() {
			UpdateInfo = UpdateManager.GetUpdateFullInfo();
			BeginInvoke(new MethodInvoker(delegate {
				if(AssemblyInfo.AssemblyVersion == UpdateInfo.version) {
					LabelCheckUpdate.Text = "Обновления отсутствуют.";
				} else {
					BeginInvoke(new MethodInvoker(delegate {
						VersionChangelog.Text = UpdateInfo.changelog;
						LabelLastVersionValue.Text = UpdateInfo.version;
						tabControl1.SelectedIndex = 1;
					}));

					InstallTmpPath = Path.GetTempPath() + "/" + Path.GetFileName(new Uri(UpdateInfo.download_link).LocalPath);
				}
			}));
		}

		private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
			double bytesIn = double.Parse(e.BytesReceived.ToString());
			double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
			double percentage = bytesIn / totalBytes * 100;

			LabelStatus.Text = "Загрузка (" + bytesIn + " байт / " + totalBytes + " байт) " + "(" + percentage + "%)";

			progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
		}

		private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
			LabelStatus.Text = "Загрузка завершена. Установка обновления...";

			Process.Start(InstallTmpPath, "/S");

			Application.Exit();
		}

		private void CheckUpdateForm_Load(object sender, EventArgs e) {
			animator1.SetDecoration(Logo, AnimatorNS.DecorationType.BottomMirror);

			Task UpdateTask = new Task(Task_GetUpdateInfo);
			UpdateTask.Start();

			LabelCurrentVersionValue.Text = AssemblyInfo.AssemblyVersion;

			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;

			foreach(TabPage tab in tabControl1.TabPages) {
				tab.Text = "";
			}

			CheckBoxOpenUpdateWindow.Checked = Properties.Settings.Default.OpenUpdateWindow;

			GC.Collect();
		}

		private void BtnLoad_Click(object sender, EventArgs e) {
			UpdateManager.DownloadFile(new Uri(UpdateInfo.download_link), InstallTmpPath, client_DownloadProgressChanged, client_DownloadFileCompleted);
		}

		private void CheckUpdateForm_FormClosing(object sender, FormClosingEventArgs e) {
			Properties.Settings.Default.OpenUpdateWindow = CheckBoxOpenUpdateWindow.Checked;
			
		}

		private void BtnOK_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
