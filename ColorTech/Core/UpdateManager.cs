using System.Net;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace ColorTech.Core {
	public class UpdateVersion {
		public string id { get; set; }
		public string version { get; set; }
		public string changelog { get; set; }
		public string release_date { get; set; }
		public string product_id { get; set; }
		public string product_name { get; set; }
		public string download_link { get; set; }
	}

	static class UpdateManager {
		public static UpdateVersion GetUpdateFullInfo() {
			using(WebClient client = new WebClient()) {
				string LastVersionJSON = client.DownloadString("https://update.quadvector.ru/?action=getproductlastversion&productid=1&full=1");
				UpdateVersion LastVersionInfo = JsonConvert.DeserializeObject<UpdateVersion>(LastVersionJSON);

				return LastVersionInfo;
			}
		}

		public static string GetLastVersion() {
			using(WebClient client = new WebClient()) {
				string LastVersionJSON = client.DownloadString("https://update.quadvector.ru/?action=getproductlastversion&productid=1&full=0");
				UpdateVersion LastVersionInfo = JsonConvert.DeserializeObject<UpdateVersion>(LastVersionJSON);

				return LastVersionInfo.version;
			}
		}

		public static void DownloadFile(
			Uri DownloadUri,
			string InstallTmpPath,
			Action<object, DownloadProgressChangedEventArgs> ProgressChanged,
			Action<object, AsyncCompletedEventArgs> DownloadCompleted) {
			using(WebClient client = new WebClient()) {
				client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
				client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);

				client.DownloadFileAsync(DownloadUri, InstallTmpPath);
			}
		}
	}
}
