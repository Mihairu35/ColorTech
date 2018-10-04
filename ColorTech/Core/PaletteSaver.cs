using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ColorTech.Core {
	public class PaletteGridData {

		public string Author { get; set; }
		public string Description { get; set; }
		public string SiteLink { get; set; }

		public List<PaletteRow> PaletteColors { get; set; }
	}

	public class PaletteRow {
		public string Name { get; set; }
		public string HEX { get; set; }
	}

	public static class BitConverter {
		public static byte[] ToBytes(this string the_string) {
			char separator = the_string[2];
			string[] pairs = the_string.Split(separator);
			byte[] bytes = new byte[pairs.Length];
			for(int i = 0; i < pairs.Length; i++)
				bytes[i] = Convert.ToByte(pairs[i], 16);
			return bytes;
		}
	}
	
	public class PaletteSaver {
		public void Save(string FileName, PaletteGridData data) {
			string json = JsonConvert.SerializeObject(data, Formatting.Indented); //генерируем JSON из коллекции
			File.WriteAllText(FileName, System.BitConverter.ToString(UTF8Encoding.UTF8.GetBytes(json), 0).Replace('-', ' ')); //сохраняем JSON, закодированный в поток битов, в файл

			//очищаем память
			GC.Collect();
		}

		public PaletteGridData Open(string FileName) {
			string content = File.ReadAllText(FileName); //считываем данные из файла (в файле записан поток байтов)
			byte[] bytes = content.ToBytes(); //преобразуем данные в массив байтов
	
			//декодируем поток байтов (UTF8 кодировка)
			UTF8Encoding UTF8_Encoder = new UTF8Encoding();
			content = UTF8_Encoder.GetString(bytes);

			//полученные данные находятся в JSON формате. Парсим их.
			PaletteGridData PGD = JsonConvert.DeserializeObject<PaletteGridData>(content);
			
			GC.Collect();
			return PGD;
		}
	}
}
