using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using ColorTech.Core;
using ColorTech.Core.FormatConverter;
using ColorTech.Forms;
using ColorTech.Core.Drawing;
using FastBitmapLib;
using RamGecTools;

namespace ColorTech {
	/// <summary>
	/// Главная форма программы.
	/// </summary>
	public partial class MainForm: Form {
		#region Переменные класса
		Bitmap PreviewBMP; //битмап для просмотра цвета
		Graphics PreviewGR; //объект для работы с графикой для просмотра цвета
		Bitmap ColorBoxBMP; //битмап для блока выбора цвета
		Graphics ColorBoxGR; //объект для работы с графикой для выбора цвета
		NewMainGRaphics ColorBoxNewMainGR; //объект, расширяющий ColorBoxGR для работы с графиком цветовой палитрой.
		Bitmap ScreenshotBMP; //битмап для экранной пипетки для создания скриншота
		Graphics ScreenshotGR; //объект для работы с графикой экранной пипетки (для работы со скриншотом)


		//для обработки мыши и клавиатуры
		MouseHook mouseHook = new MouseHook();
		KeyboardHook keyboardHook = new KeyboardHook();

		public PaletteColor Color1; //выбранный цвет

		public int ScreenshotScaleIndex = 0; //значение масштабирования скриншота
		public bool IsSelectingScreenshotBox = false; //выбирается ли цвет через скриншот
		public bool IsSelectingScreenshot = false; //выбирается ли скриншот через палитру
		public bool IsSelectingColorBox = false; //выбирается ли цвет через палитру
		public int ColorStringFormatIndex = 0; //значение выбранного формата цвета

		public enum UpdateColorPanelsMode { //режимы обновления цвета
			RGB,
			HSV,
			NONE
		}

		//настройка графики
		public SmoothingMode GlobalSmoothingMode = SmoothingMode.AntiAlias;
		public CompositingMode GlobalCompositingMode = CompositingMode.SourceOver;
		public CompositingQuality GlobalompositingQuality = CompositingQuality.Default;
		public TextRenderingHint GlobalTextRenderingHint = TextRenderingHint.SystemDefault;

		//для хранения истории палитры
		public PaletteOriginator POriginator;
		public PaletteHistory PHistory;

		//для текущей палитры
		public string OpenedFileName;
		public PaletteGridData PGD = new PaletteGridData(); //объект для хранения данных о палитре

		public ColorStringFormatContext ColorStringFormatContext = new ColorStringFormatContext(new HTMLHexStrategy()); //форматирование цвета
		#endregion

		#region Логика управлением формой
		/// <summary>
		/// Инициализация главной формы и программы
		/// </summary>
		/// <param name="FileName">Адрес файла цветовой палитры. Используется, когда программой напрямую надо открыть этот файл.</param>
		public MainForm(string FileName = null) {
			InitializeComponent();

			//инициализируем объекты
			//просмотр цвета
			PreviewBMP = new Bitmap(ColorPreviewMain.Width, ColorPreviewMain.Height);
			PreviewGR = Graphics.FromImage(PreviewBMP);
			PreviewGR.SmoothingMode = GlobalSmoothingMode;
			PreviewGR.CompositingMode = GlobalCompositingMode;
			PreviewGR.CompositingQuality = GlobalompositingQuality;
			PreviewGR.TextRenderingHint = GlobalTextRenderingHint;

			//цветовая палитра
			ColorBoxBMP = new Bitmap(SelectColorBox.Width, SelectColorBox.Height);
			ColorBoxGR = Graphics.FromImage(ColorBoxBMP);
			ColorBoxNewMainGR = new NewMainGRaphics(ColorBoxGR);
			ColorBoxGR.SmoothingMode = GlobalSmoothingMode;
			ColorBoxGR.CompositingMode = GlobalCompositingMode;
			ColorBoxGR.CompositingQuality = GlobalompositingQuality;
			ColorBoxGR.TextRenderingHint = GlobalTextRenderingHint;

			//скриншот для экранной пипетки
			ScreenshotBMP = new Bitmap(ScreenshotBox.Width, ScreenshotBox.Height);
			ScreenshotGR = Graphics.FromImage(ScreenshotBMP);
			ScreenshotGR.SmoothingMode = GlobalSmoothingMode;
			ScreenshotGR.CompositingMode = GlobalCompositingMode;
			ScreenshotGR.CompositingQuality = GlobalompositingQuality;
			ScreenshotGR.TextRenderingHint = GlobalTextRenderingHint; //сглаживание текста

			//первоначальные установки компонентов в форме, значения которых в дальнейшем будут сохраняться
			Color1 = new PaletteColor(Color.Black);

			//выбранные настройки на главной форме, которые будут сохранены после закрытия программы
			ColorFormatComboBox.SelectedIndex = 0; //индекс выбранного цветового формата
			ScreenshotScaleComboBox.SelectedIndex = 0; //индекс выбранного масштабирования для скриншота экранной пипетки

			//специальный хук для мышки, который позволяет перехватывать ее события вне главного окна программы
			mouseHook.LeftButtonUp += new MouseHook.MouseHookCallback(MouseHook_ScreenshotUP);
			mouseHook.Install();

			//загружаем файл цветовой палитры, если он был перетащен на ярлык программы, или если сам файл ассоциируется с запуском данной программы
			if(FileName != null) {
				try {
					PaletteSaver saver = new PaletteSaver(); //объект открытия/сохранения цветовой палитры
					PGD = saver.Open(FileName);

					//выводим всю полученную из файла информацию в окно программы
					ColorGrid.Rows.Clear();
					foreach(PaletteRow row in PGD.PaletteColors) {
						AddColorToPaletteGrid(ColorGrid, row.Name, row.HEX);
					}

					OpenedFileName = FileName;
					StatusFileName.Text = System.IO.Path.GetFileName(FileName);
					StatusPaletteAuthor.Text = PGD.Author;
				} catch { }
			}
		}

		/// <summary>
		/// Проверка на обновления
		/// </summary>
		private void CheckUpdate() {
			string LastVersion = UpdateManager.GetLastVersion();
			if((AssemblyInfo.AssemblyVersion != LastVersion) && !LastVersion.Equals(null) && !LastVersion.Equals("")) {
				using(CheckUpdateForm CUForm = new CheckUpdateForm()) {
					CUForm.ShowDialog();
				}
			}
		}

		/// <summary>
		/// Обновление истории палитры
		/// </summary>
		/// <param name="IsNewElement">Флаг, указывающий на то, создается ли новый элемент или нет.</param>
		/// <param name="IsCurrentColor">Флаг, указывающий на то, перезаписывать ли текущий цвет в истории или нет.</param>
		private void UpdatePaletteHistory(bool IsNewElement = false, bool IsCurrentColor = false) {
			//Если мы создаем новый элемент, и при этом позиция в истории не является первой, то перезаписываем текущий элемент и удаляем следующие.
			if(IsNewElement == true && IsCurrentColor == false) {
				try {
					if(PHistory.ActiveIndex < PHistory.History.Count - 1) {
						PHistory.History.RemoveRange(PHistory.ActiveIndex + 1, PHistory.History.Count - 1);
					}
				} catch { }

				PHistory.ActiveIndex = PHistory.History.Count;
				PHistory.History.Add(POriginator.SavePaletteState());
			}

			//Если мы хотим перезапаисать текущий цвет, и при этом не создавать новый, то выполняем это.
			if(IsCurrentColor == true && IsNewElement == false) {
				PHistory.History[PHistory.ActiveIndex] = POriginator.SavePaletteState();
			}

			//проверка на отмену и повтор
			if(PHistory.History.Count == 1) {
				MenuItemUndo.Enabled = ToolBtnUndo.Enabled = false;
				MenuItemRedo.Enabled = ToolBtnRedo.Enabled = false;
			} else {
				if(PHistory.ActiveIndex == PHistory.History.Count - 1) {
					MenuItemUndo.Enabled = ToolBtnUndo.Enabled = true;
					MenuItemRedo.Enabled = ToolBtnRedo.Enabled = false;
				} else if(PHistory.ActiveIndex == 0) {
					MenuItemUndo.Enabled = ToolBtnUndo.Enabled = false;
					MenuItemRedo.Enabled = ToolBtnRedo.Enabled = true;
				} else {
					MenuItemUndo.Enabled = ToolBtnUndo.Enabled = true;
					MenuItemRedo.Enabled = ToolBtnRedo.Enabled = true;
				}
			}
		}

		/// <summary>
		/// Обновить таблицу с цветовой палитрой.
		/// </summary>
		private void RefreshPaletteData() {
			//создаем коллекцию из строк таблицы цветов
			List<PaletteRow> data = new List<PaletteRow>();
			foreach(DataGridViewRow dr in ColorGrid.Rows) {
				PaletteRow pl = new PaletteRow();
				pl.Name = dr.Cells[0].Value.ToString();
				pl.HEX = dr.Cells[2].Value.ToString();
				data.Add(pl);
			}

			PGD.PaletteColors = data;
		}

		/// <summary>
		/// Отключение событий у ползунков выбора цвета
		/// </summary>
		private void LockSliders() {
			RedSlider.ValueChanged -= RedSlider_ValueChanged;
			GreenSlider.ValueChanged -= GreenSlider_ValueChanged;
			BlueSlider.ValueChanged -= BlueSlider_ValueChanged;
			HueSlider.ValueChanged -= HueSlider_ValueChanged;
			SatSlider.ValueChanged -= SatSlider_ValueChanged;
			ValSlider.ValueChanged -= ValSlider_ValueChanged;
		}

		/// <summary>
		/// Включение событий у ползунков выбора цвета
		/// </summary>
		private void UnlockSliders() {
			RedSlider.ValueChanged += RedSlider_ValueChanged;
			GreenSlider.ValueChanged += GreenSlider_ValueChanged;
			BlueSlider.ValueChanged += BlueSlider_ValueChanged;
			HueSlider.ValueChanged += HueSlider_ValueChanged;
			SatSlider.ValueChanged += SatSlider_ValueChanged;
			ValSlider.ValueChanged += ValSlider_ValueChanged;
		}

		/// <summary>
		/// Обновить цветовую панелль
		/// </summary>
		/// <param name="mode">Режим обновления цветовой панели</param>
		private void UpdateColorPanels(UpdateColorPanelsMode mode = UpdateColorPanelsMode.NONE) {
			LockSliders();

			switch(mode) {
				case UpdateColorPanelsMode.RGB:
					RGB crgb = new RGB((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
					Color1.SetColor(crgb);
				break;
				case UpdateColorPanelsMode.HSV:
					HSV chsv = new HSV(HueSlider.Value, SatSlider.Value / 255d, ValSlider.Value / 255d);
					Color1.SetColor(chsv);
				break;
				case UpdateColorPanelsMode.NONE:
					RedSlider.Value = Color1.MainColor.R;
					GreenSlider.Value = Color1.MainColor.G;
					BlueSlider.Value = Color1.MainColor.B;
					crgb = new RGB((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
					Color1.SetColor(crgb);
				break;
			}

			RedSliderValue.Value = Convert.ToDecimal(Color1.rgb.R);
			GreenSliderValue.Value = Convert.ToDecimal(Color1.rgb.G);
			BlueSliderValue.Value = Convert.ToDecimal(Color1.rgb.B);
			HueSliderValue.Value = Convert.ToDecimal(Color1.hsv.H);
			SatSliderValue.Value = Convert.ToDecimal(Color1.hsv.S * 255);
			ValSliderValue.Value = Convert.ToDecimal(Color1.hsv.V * 255);

			//отображаем предпросмотр цвета
			using(Brush Brush1 = new SolidBrush(Color1.MainColor)) {
				PreviewGR.Clear(Color.Transparent); //очищаем холст
				PreviewGR.FillEllipse(Brush1, 0, 0, ColorPreviewMain.Width - 2, ColorPreviewMain.Height - 2);

				using(Font drawFont = new Font("Segoe UI", 10)) {
					using(SolidBrush drawBrush = new SolidBrush(ImageEffects.GetContrastTextColor(Color1.MainColor))) {
						using(StringFormat sf = new StringFormat()) {
							sf.Alignment = StringAlignment.Center;
							sf.LineAlignment = StringAlignment.Center;
							PreviewGR.DrawString("ColorTech", drawFont, drawBrush, PreviewBMP.Width / 2, PreviewBMP.Height / 2, sf);
						}
					}
				}
			}
			ColorPreviewMain.Image = PreviewBMP; //отображаем изображение в PictureBox

			//заполняем информацию о выбранном цвете
			HEXCopyTextBox.Text = ColorStringFormatContext.GetColorFormat(Color1.MainColor);

			UpdateColorBox();
			UnlockSliders();
		}

		/// <summary>
		/// Добавление цвета в цветовую палитру для формы
		/// </summary>
		/// <param name="PaletteGrid">WinForms объект таблицы с цветовой палитры</param>
		/// <param name="ColorName">Название цвета</param>
		/// <param name="HEX">Цвет в формате HEX</param>
		private void AddColorToPaletteGrid(DataGridView PaletteGrid, string ColorName, string HEX) {
			Image ColorImg = new Bitmap(10, 10);
			Graphics ColorGR = Graphics.FromImage(ColorImg);
			using(Brush br = new SolidBrush(ColorFormatConverter.CreateColorFromHEX(HEX))) {
				ColorGR.FillRectangle(br, 0, 0, 10, 10);
			}
			if(ColorName.Replace(" ", "") == "") {
				ColorName = "Цвет " + (ColorGrid.Rows.Count + 1);
			}
			PaletteGrid.Rows.Add(ColorName, ColorImg, HEX);
		}
		#endregion

		#region Логика взаимодействия ползунков выбора цвета

		/// <summary>
		/// Событие изменения ползунка R
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RedSlider_ValueChanged(object sender, EventArgs e) {
			UpdateColorPanels(UpdateColorPanelsMode.RGB);
			UpdatePaletteHistory(false, true);
		}

		/// <summary>
		/// Событие изменения цифрового поля R 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RedSliderValue_ValueChanged(object sender, EventArgs e) {
			RedSlider.Value = Decimal.ToInt32(RedSliderValue.Value);
		}

		/// <summary>
		/// Событие отпускания кнопки цифрового поля R
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RedSliderValue_KeyUp(object sender, KeyEventArgs e) {
			RedSlider.Value = Decimal.ToInt32(RedSliderValue.Value);
		}

		/// <summary>
		/// Событие изменения ползунка G
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GreenSlider_ValueChanged(object sender, EventArgs e) {
			UpdateColorPanels(UpdateColorPanelsMode.RGB);
			UpdatePaletteHistory(false, true);
		}

		/// <summary>
		/// Событие изменения цифрового поля G
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GreenSliderValue_ValueChanged(object sender, EventArgs e) {
			GreenSlider.Value = Decimal.ToInt32(GreenSliderValue.Value);
		}

		/// <summary>
		/// Событие отпускания кнопки цифрового поля G
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GreenSliderValue_KeyUp(object sender, KeyEventArgs e) {
			GreenSlider.Value = Decimal.ToInt32(GreenSliderValue.Value);
		}

		/// <summary>
		/// Событие изменения ползунка B
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BlueSlider_ValueChanged(object sender, EventArgs e) {
			UpdateColorPanels(UpdateColorPanelsMode.RGB);
			UpdatePaletteHistory(false, true);
		}

		/// <summary>
		/// Событие изменения цифрового поля B
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BlueSliderValue_ValueChanged(object sender, EventArgs e) {
			BlueSlider.Value = Decimal.ToInt32(BlueSliderValue.Value);
		}

		/// <summary>
		/// Событие отпускания кнопки цифрового поля B
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BlueSliderValue_KeyUp(object sender, KeyEventArgs e) {
			BlueSlider.Value = Decimal.ToInt32(BlueSliderValue.Value);
		}

		/// <summary>
		/// Событие изменения ползунка H
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HueSlider_ValueChanged(object sender, EventArgs e) {
			UpdateColorPanels(UpdateColorPanelsMode.HSV);
			UpdatePaletteHistory(false, true);
		}

		/// <summary>
		/// Событие изменения цифрового поля H
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HueSliderValue_ValueChanged(object sender, EventArgs e) {
			HueSlider.Value = Decimal.ToInt32(HueSliderValue.Value);
		}

		/// <summary>
		/// Событие отпускания кнопки цифрового поля H
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HueSliderValue_KeyUp(object sender, KeyEventArgs e) {
			HueSlider.Value = Decimal.ToInt32(HueSliderValue.Value);
		}

		/// <summary>
		/// Событие изменения ползунка S
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SatSlider_ValueChanged(object sender, EventArgs e) {
			UpdateColorPanels(UpdateColorPanelsMode.HSV);
			UpdatePaletteHistory(false, true);
		}

		/// <summary>
		/// Событие изменения цифрового поля S
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SatSliderValue_ValueChanged(object sender, EventArgs e) {
			SatSlider.Value = Decimal.ToInt32(SatSliderValue.Value);
		}

		/// <summary>
		/// Событие отпускания кнопки цифрового поля S
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SatSliderValue_KeyUp(object sender, KeyEventArgs e) {
			SatSlider.Value = Decimal.ToInt32(SatSliderValue.Value);
		}

		/// <summary>
		/// Событие изменения ползунка V
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ValSlider_ValueChanged(object sender, EventArgs e) {
			UpdateColorPanels(UpdateColorPanelsMode.HSV);
			UpdatePaletteHistory(false, true);
		}

		/// <summary>
		/// Событие изменения цифрового поля V
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ValSliderValue_ValueChanged(object sender, EventArgs e) {
			ValSlider.Value = Decimal.ToInt32(ValSliderValue.Value);
		}

		/// <summary>
		/// Событие отпускания кнопки цифрового поля V
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ValSliderValue_KeyUp(object sender, KeyEventArgs e) {
			ValSlider.Value = Decimal.ToInt32(ValSliderValue.Value);
		}
		#endregion

		#region Цветовая палитра
		private void UpdateColorBox() {
			ColorBoxNewMainGR.DrawColorWheel(SystemColors.Control, 0, 0, SelectColorBox.Width, SelectColorBox.Height, ValSlider.Value);
			SelectColorBox.Image = ColorBoxBMP;
		}

		/// <summary>
		/// Выбор цвета в круговой палитре цветов
		/// </summary>
		/// <param name="x">Выбранная координата X</param>
		/// <param name="y">Выбранная координата Y</param>
		private void SelectColorFromWheel(int x, int y) {
			if(IsSelectingColorBox) {
				try {
					Color c;
					using(var FBMP = ColorBoxBMP.FastLock()) {
						c = FBMP.GetPixel(x, y);
					}

					//корректировка цвета по яркости (т.к. по каким-то причинам блок с палитрой цветов неравномерно закрашивается по яркости)
					//3.08.18 - почему-то теперь, убирая эти строчки, никакой разницы нет. Оставил на всякий случай
					HSV hsv = ColorFormatConverter.rgb2hsv(c);
					hsv.V = ValSlider.Value / 255d; //яркость всегда равна при выборе указанному значению на ползунке

					Color1.SetColor(ColorFormatConverter.CreateColorFromHSV(hsv));
				} catch {
					IsSelectingColorBox = false;
				}
				UpdateColorPanels(UpdateColorPanelsMode.NONE);
			}
		}

		/// <summary>
		/// Выбор цвета из скриншота для формы
		/// </summary>
		/// <param name="ScreenshotBox">Объект PictureBox со скриншотом</param>
		/// <param name="x">Позиция x</param>
		/// <param name="y">Позиция y</param>
		private void SelectColorFromScreenshot(PictureBox ScreenshotBox, int x, int y) {
			using(Graphics ScreenshotGR = Graphics.FromImage(ScreenshotBMP)) {
				ScreenshotGR.Clear(Color.White);
				ScreenshotGR.CopyFromScreen(x - ScreenshotBox.Width / 2, y - ScreenshotBox.Height / 2, 0, 0, ScreenshotBMP.Size);

				//масштабирование скриншота
				ImageEffects.ResizeImg(ref ScreenshotBMP, -ScreenshotBox.Width * (ScreenshotScaleIndex) / 2, -ScreenshotBox.Height * (ScreenshotScaleIndex) / 2, ScreenshotBox.Width * (ScreenshotScaleIndex + 1), ScreenshotBox.Height * (ScreenshotScaleIndex + 1));

				Color c;
				using(var FBMP = ScreenshotBMP.FastLock()) {
					c = FBMP.GetPixel(ScreenshotBMP.Width / 2, ScreenshotBMP.Height / 2);
				}
				Color1.SetColor(c);

				using(Pen p = new Pen(new SolidBrush(Color.Black))) {
					ScreenshotGR.DrawLine(p, ScreenshotBMP.Width / 2, 50, ScreenshotBMP.Width / 2, ScreenshotBMP.Height - 50);
					ScreenshotGR.DrawLine(p, 91, ScreenshotBMP.Height / 2, ScreenshotBMP.Width - 91, ScreenshotBMP.Height / 2);
				}

				ScreenshotBox.Image = ScreenshotBMP;

				UpdateColorPanels(UpdateColorPanelsMode.NONE);
				LabelScreenshotX.Text = "X: " + Cursor.Position.X.ToString();
				LabelScreenshotY.Text = "Y: " + Cursor.Position.Y.ToString();
			}
		}

		/// <summary>
		/// Получение цвета из скриншота
		/// </summary>
		/// <param name="x">Позиция x</param>
		/// <param name="y">Позиция y</param>
		private void SelectColorFromScreenshotBox(int x, int y) {
			try {
				using(FastBitmap c = ScreenshotBMP.FastLock()) {
					Color1.SetColor(c.GetPixel(x, y));
				}
			} catch { }

			UpdateColorPanels(UpdateColorPanelsMode.NONE);
		}

		/// <summary>
		/// Событие зажатия левой кнопки мыши для получения цвета из скриншота
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectColorBox_MouseDown(object sender, MouseEventArgs e) {
			IsSelectingColorBox = true;
			SelectColorFromWheel(e.X, e.Y);
		}

		/// <summary>
		/// Событие отпускания левой кнопки мыши для получения цвета из скриншота
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectColorBox_MouseUp(object sender, MouseEventArgs e) {
			IsSelectingColorBox = false;
			SelectColorFromWheel(e.X, e.Y);
			UpdatePaletteHistory(true);
		}

		/// <summary>
		/// Событие перемещения мыши при получении цвета из скриншота
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectColorBox_MouseMove(object sender, MouseEventArgs e) {
			if(IsSelectingColorBox) {
				SelectColorFromWheel(e.X, e.Y);
			}
		}
		#endregion

		#region Прочие события

		/// <summary>
		/// Загрузка формы и инициализация объектов
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e) {
			try {
				Color1.SetColor(Properties.Settings.Default.LastColor);
				ColorFormatComboBox.SelectedIndex = Properties.Settings.Default.LastColorStringFormatIndex;
				ScreenshotScaleComboBox.SelectedIndex = Properties.Settings.Default.LastZoom;
			} catch { }

			using(SolidBrush brush = new SolidBrush(SystemColors.Control)) {
				ScreenshotGR.FillRectangle(brush, 0, 0, ScreenshotBMP.Width, ScreenshotBMP.Height);
			}

			//рисуем информационную надпись на панели со скриншотом
			string InfoText = "Зажмите левую кнопку мыши\n и перемещайте курсор,\n чтобы узнать цвет.";
			using(Font drawFont = new Font("Segoe UI", 10)) {
				using(SolidBrush drawBrush = new SolidBrush(SystemColors.ControlText)) {
					using(StringFormat sf = new StringFormat()) {
						sf.Alignment = StringAlignment.Center;
						sf.LineAlignment = StringAlignment.Center;
						ScreenshotGR.DrawString(InfoText, drawFont, drawBrush, ScreenshotBMP.Width / 2, ScreenshotBMP.Height / 2, sf);
					}
				}
			}

			ScreenshotBox.Image = ScreenshotBMP;

			//для хранения истории палитры
			POriginator = new PaletteOriginator(this);
			PHistory = new PaletteHistory();
			PHistory.History.Add(POriginator.SavePaletteState());

			UpdateColorPanels(UpdateColorPanelsMode.NONE); //обновляем все элементы управления цветом в форме
			UpdatePaletteHistory();

			//проверка на обновления
			if(Properties.Settings.Default.OpenUpdateWindow == true) {
				Task CheckUpdateTask = new Task(CheckUpdate);
				CheckUpdateTask.Start();
			}
		}
		/// <summary>
		/// Событие двойного нажатия по строке в таблице цветовой палитры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ColorGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
			if(ColorGrid.Rows.Count != 0) {
				Color c = ColorFormatConverter.CreateColorFromHEX(ColorGrid.SelectedRows[0].Cells[2].Value.ToString());
				Color1.SetColor(c);
				UpdateColorPanels(UpdateColorPanelsMode.NONE);
			}
		}

		/// <summary>
		/// Событие закрытия окна программы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
			Properties.Settings.Default.LastColor = Color1.MainColor;
			Properties.Settings.Default.LastColorStringFormatIndex = ColorFormatComboBox.SelectedIndex;
			Properties.Settings.Default.LastZoom = ScreenshotScaleComboBox.SelectedIndex;
			Properties.Settings.Default.Save();
		}

		/// <summary>
		/// Событие отпускания левой кнопки мыши при выбора цвета из скриншота
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnColorScreenshot_MouseDown(object sender, MouseEventArgs e) {
			IsSelectingScreenshot = true;
			Timer_GetScreenshot.Enabled = true;
			Cursor.Current = Cursors.Hand;
			SelectColorFromScreenshot(ScreenshotBox, Cursor.Position.X, Cursor.Position.Y);
		}

		/// <summary>
		/// Событие-хук отпускания левой кнопки мыши при выборе цвета из скриншота
		/// </summary>
		/// <param name="mouseStruct"></param>
		void MouseHook_ScreenshotUP(MouseHook.MSLLHOOKSTRUCT mouseStruct) {
			IsSelectingScreenshot = false;
			Timer_GetScreenshot.Enabled = false;
		}

		/// <summary>
		/// Событие таймера при выборе цвета из скриншота
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Timer_GetScreenshot_Tick(object sender, EventArgs e) {
			SelectColorFromScreenshot(ScreenshotBox, Cursor.Position.X, Cursor.Position.Y);
			UpdateColorPanels(UpdateColorPanelsMode.NONE);
		}

		/// <summary>
		/// Событие выбора значения выпадающего меню масштаба экранной пипетки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScreenshotScaleComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			ScreenshotScaleIndex = ScreenshotScaleComboBox.SelectedIndex;
		}

		/// <summary>
		/// Событие выбора значения выпадающего меню формата вывода цвета
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ColorFormatComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			ColorStringFormatIndex = ColorFormatComboBox.SelectedIndex;

			switch(ColorFormatComboBox.SelectedIndex) {
				case 0:
					ColorStringFormatContext.SetStrategy(new HTMLHexStrategy());
				break;
				case 1:
					ColorStringFormatContext.SetStrategy(new DelphiHexStrategy());
				break;
				case 2:
					ColorStringFormatContext.SetStrategy(new VBHexStrategy());
				break;
				case 3:
					ColorStringFormatContext.SetStrategy(new CPPHexStrategy());
				break;
				case 4:
					ColorStringFormatContext.SetStrategy(new RGBStrategy());
				break;
				case 5:
					ColorStringFormatContext.SetStrategy(new RGBPercentStrategy());
				break;
				case 6:
					ColorStringFormatContext.SetStrategy(new HSLStrategy());
				break;
				case 7:
					ColorStringFormatContext.SetStrategy(new HSBStrategy());
				break;
				case 8:
					ColorStringFormatContext.SetStrategy(new CMYStrategy());
				break;
				case 9:
					ColorStringFormatContext.SetStrategy(new CMYKStrategy());
				break;
				case 10:
					ColorStringFormatContext.SetStrategy(new PhotoshopStrategy());
				break;
				case 11:
					ColorStringFormatContext.SetStrategy(new PowerbuilderStrategy());
				break;
			}

			UpdateColorPanels(UpdateColorPanelsMode.NONE);
		}

		/// <summary>
		/// Событие зажатия левой кнопки мыши при выборе цвета скриншота
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScreenshotBox_MouseDown(object sender, MouseEventArgs e) {
			IsSelectingScreenshotBox = true;
			SelectColorFromScreenshotBox(e.Location.X, e.Location.Y);
		}

		/// <summary>
		/// Событие движения мыши при выборе цвета скриншота
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScreenshotBox_MouseMove(object sender, MouseEventArgs e) {
			if(IsSelectingScreenshotBox == true) {
				SelectColorFromScreenshotBox(e.Location.X, e.Location.Y);
			}
		}

		/// <summary>
		/// Событие отпускания левой кнопки мыши при выборе цвета скриншота
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScreenshotBox_MouseUp(object sender, MouseEventArgs e) {
			IsSelectingScreenshotBox = false;
		}

		/// <summary>
		/// Событие зажатия клавиши в специальном поле значения выбранного цвета
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HEXCopyTextBox_KeyPress(object sender, KeyPressEventArgs e) {
			if(e.KeyChar == (char)13) {
				BtnSetColorCode.PerformClick();
				e.Handled = true;
			}
		}

		/// <summary>
		/// Событие нажатия по специальной ссылке в статус-баре для открытия окна с информацией о текущей цветовой палитре
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StatusPaletteAuthor_Click(object sender, EventArgs e) {
			using(PaletteInfoForm InfoDialog = new PaletteInfoForm()) {
				InfoDialog.Owner = this;
				InfoDialog.ShowDialog();
			}
		}

		#endregion

		#region События кнопок
		/// <summary>
		/// Событие нажатия кнопки изменения названия выбранного цвета в цветовой-палитре
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnEditColorName_Click(object sender, EventArgs e) {
			if(ColorGrid.SelectedRows.Count != 0) {
				string ColorName = "";
				Forms.Dialog.InputBox("Редактировать цвет", "Название цвета:", ref ColorName);
				ColorGrid.Rows[ColorGrid.SelectedRows[0].Index].Cells[0].Value = ColorName;
			} else {
				MessageBox.Show("Выберите цвет", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		/// <summary>
		/// Событие нажатия кнопки изменения выбранного цвета в цветовой-палитре
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnChangeSelectedColor_Click(object sender, EventArgs e) {
			if(ColorGrid.SelectedRows.Count != 0) {
				Image ColorImg = new Bitmap(10, 10);
				Graphics ColorGR = Graphics.FromImage(ColorImg);
				using(Brush br = new SolidBrush(Color1.MainColor)) {
					ColorGR.FillRectangle(br, 0, 0, 10, 10);
				}
				ColorGrid.Rows[ColorGrid.SelectedRows[0].Index].Cells[1].Value = ColorImg;
				ColorGrid.Rows[ColorGrid.SelectedRows[0].Index].Cells[2].Value = "#" + ColorFormatConverter.GetHEX(Color1.MainColor);
			} else {
				MessageBox.Show("Выберите цвет", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		/// <summary>
		/// Событие нажатия кнопки удаления цвета из цветовой палитры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnDeletePaletteColor_Click(object sender, EventArgs e) {
			if(ColorGrid.Rows.Count != 0) {
				ColorGrid.Rows.Remove(ColorGrid.SelectedRows[0]);
			} else {
				MessageBox.Show("Выберите цвет", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		/// <summary>
		/// Событие нажатие кнопки добавления цвета в цветовую палитру
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAddPaletteColor_Click(object sender, EventArgs e) {
			string ColorName = "";
			if(Dialog.InputBox("Добавить цвет", "Название цвета:", ref ColorName) == DialogResult.OK) {
				AddColorToPaletteGrid(ColorGrid, ColorName, ColorFormatConverter.GetHEX(Color1.MainColor));
			}
		}

		/// <summary>
		/// Событие нажатия кнопки копирования значения выбранного цвета из специального поля
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCopyColorCode_Click(object sender, EventArgs e) {
			Clipboard.SetText(HEXCopyTextBox.Text);
		}

		/// <summary>
		/// Событие нажатия кнопки выбора цвета, введенного в специальное поле ввода
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSetColorCode_Click(object sender, EventArgs e) {
			try {
				Color1.SetColor(ColorStringFormatContext.GetColor(HEXCopyTextBox.Text));
				UpdateColorPanels(UpdateColorPanelsMode.NONE);
				UpdatePaletteHistory(true);
			} catch {
				Color1.SetColor(Color.Black);
			}
		}

		/// <summary>
		/// Событие нажатия кнопки отмены
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnUndo_Click(object sender, EventArgs e) {
			if(PHistory.ActiveIndex != 0) {
				PHistory.ActiveIndex--;
			}
			POriginator.LoadColorState(PHistory.History[PHistory.ActiveIndex]);

			UpdateColorPanels(UpdateColorPanelsMode.NONE);
			UpdatePaletteHistory();
		}

		/// <summary>
		/// Событие нажатия кнопки повтора
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnRedo_Click(object sender, EventArgs e) {
			if(PHistory.ActiveIndex != PHistory.History.Count - 1) {
				PHistory.ActiveIndex++;
			}
			POriginator.LoadColorState(PHistory.History[PHistory.ActiveIndex]);

			UpdateColorPanels(UpdateColorPanelsMode.NONE);
			UpdatePaletteHistory();
		}

		/// <summary>
		/// Событие нажатия кнопки открытия цветовой палитры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnOpen_Click(object sender, EventArgs e) {
			using(OpenFileDialog OpenDialog = new OpenFileDialog()) {
				OpenDialog.Title = "Открыть цветовую схему";
				OpenDialog.Filter = "Цветовые схемы (*.ctcg)|*.ctcg";

				if(OpenDialog.ShowDialog() == DialogResult.OK) {
					PaletteSaver saver = new PaletteSaver();
					PGD = saver.Open(OpenDialog.FileName);

					ColorGrid.Rows.Clear();
					foreach(PaletteRow row in PGD.PaletteColors) {
						AddColorToPaletteGrid(ColorGrid, row.Name, row.HEX);
					}

					OpenedFileName = OpenDialog.FileName;
					StatusFileName.Text = System.IO.Path.GetFileName(OpenDialog.FileName);
					StatusPaletteAuthor.Text = PGD.Author;
				}
			}
			GC.Collect();
		}

		/// <summary>
		/// Событие нажатия кнопки сохранения цветовой палитры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnSave_Click(object sender, EventArgs e) {
			using(SaveFileDialog SaveDialog = new SaveFileDialog()) {
				SaveDialog.Title = "Сохранить цветовую схему";
				SaveDialog.Filter = "Цветовые схемы (*.ctcg)|*.ctcg";
				if(SaveDialog.ShowDialog() == DialogResult.OK) {

					RefreshPaletteData();

					PaletteSaver saver = new PaletteSaver();
					saver.Save(SaveDialog.FileName, PGD);

					OpenedFileName = SaveDialog.FileName;
					StatusFileName.Text = System.IO.Path.GetFileName(SaveDialog.FileName);
				}
			}
			GC.Collect();
		}

		/// <summary>
		/// Событие нажатия кнопки закрытия программы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnClose_Click(object sender, EventArgs e) {
			Close();
		}

		/// <summary>
		/// Событие нажатия кнопки очистки цветовой палитры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolBtnClearColorGrid_Click(object sender, EventArgs e) {
			if(MessageBox.Show("Очистить цветовую палитру?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				ColorGrid.Rows.Clear();
			}
		}
		#endregion

		#region События пунктов меню
		/// <summary>
		/// Событие нажатия пункта меню открытия стандартного диалога выбора цвета
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemColorDialog_Click(object sender, EventArgs e) {
			using(ColorDialog CDialog = new ColorDialog()) {
				if(CDialog.ShowDialog() == DialogResult.OK) {
					Color1.SetColor(CDialog.Color);
					UpdateColorPanels(UpdateColorPanelsMode.NONE);
					UpdatePaletteHistory(true);
				}
			}
		}

		/// <summary>
		/// Событие нажатия пункта меню редактирования информации о цветовой палитре
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemPaletteInfo_Click(object sender, EventArgs e) {
			using(EditInfoForm EditDialog = new EditInfoForm()) {
				EditDialog.Owner = this;
				if(EditDialog.ShowDialog() == DialogResult.OK) {
					PGD.Author = EditDialog.Author;
					PGD.SiteLink = EditDialog.SiteLink;
					PGD.Description = EditDialog.Description;
					StatusPaletteAuthor.Text = PGD.Author;
				}
			}
		}

		/// <summary>
		/// Событие нажатия пункта меню для открытия окна генератора палитры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemPaletteGenerator_Click(object sender, EventArgs e) {
			using(PaletteGeneratorForm PGForm = new PaletteGeneratorForm()) {
				if(PGForm.ShowDialog() == DialogResult.OK) {
					int num = 1;
					foreach(Color color in PGForm.SelectedColors) {
						AddColorToPaletteGrid(ColorGrid, PGForm.PaletteName + " " + "#" + num, ColorFormatConverter.GetHEX(color));
						num++;
					}
				}
			}
		}

		/// <summary>
		/// Событие нажатия пункта меню закрытия программы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemClose_Click(object sender, EventArgs e) {
			Close();
		}

		/// <summary>
		/// Событие нажатия пункта меню открытия окна "О программе"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemAbout_Click(object sender, EventArgs e) {
			using(AboutForm about = new AboutForm()) {
				about.ShowDialog();
			}
		}

		/// <summary>
		/// Событие нажатия пункта меню открытия цветовой палитры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemOpen_Click(object sender, EventArgs e) {
			ToolBtnOpen.PerformClick();
		}

		/// <summary>
		/// Событие нажатия пункта меню сохранения цветовой палитры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemSave_Click(object sender, EventArgs e) {
			if(OpenedFileName != null) {
				RefreshPaletteData();
				PaletteSaver saver = new PaletteSaver();
				saver.Save(OpenedFileName, PGD);
			} else {
				ToolBtnSave.PerformClick();
			}
			GC.Collect();
		}

		/// <summary>
		/// Событие нажатия пункта меню отмены
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemUndo_Click(object sender, EventArgs e) {
			ToolBtnUndo.PerformClick();
		}

		/// <summary>
		/// Событие нажатия пункта меню повторения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemRedo_Click(object sender, EventArgs e) {
			ToolBtnRedo.PerformClick();
		}

		/// <summary>
		/// Событие нажатия пункта меню инвентирования выбранного цвета
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemInvertColor_Click(object sender, EventArgs e) {
			byte R = (byte)Math.Abs(RedSlider.Value - 255);
			byte G = (byte)Math.Abs(GreenSlider.Value - 255);
			byte B = (byte)Math.Abs(BlueSlider.Value - 255);

			Color1.SetColor(new RGB(R, G, B));
			UpdateColorPanels(UpdateColorPanelsMode.NONE);
			UpdatePaletteHistory(true);
		}

		/// <summary>
		/// Событие нажатия пункта меню выбора случайного цвета
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemRandomColor_Click(object sender, EventArgs e) {
			Random r = new Random();
			Color1.SetColor(new RGB((byte)r.Next(0, 255), (byte)r.Next(0, 255), (byte)r.Next(0, 255)));
			UpdateColorPanels(UpdateColorPanelsMode.NONE);
			UpdatePaletteHistory(true);
		}

		/// <summary>
		/// Событие нажатия пункта меню преобразования цвета в черно-белый
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemBlackAndWhite_Click(object sender, EventArgs e) {
			Color1.SetColor(ColorFormatConverter.GetBlackAndWhite(Color1.MainColor));
			UpdateColorPanels(UpdateColorPanelsMode.NONE);
			UpdatePaletteHistory(true);
		}

		/// <summary>
		/// Событие нажатия пункта меню "Сохранить как..."
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemSaveAs_Click(object sender, EventArgs e) {
			ToolBtnSave.PerformClick();
		}

		/// <summary>
		/// Событие нажатия пункта меню закрытия программы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainMenuClose_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		/// <summary>
		/// Событие нажатия пункта меню проверки на обновления
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItemCheckUpdate_Click(object sender, EventArgs e) {
			try {
				using(CheckUpdateForm CUForm = new CheckUpdateForm()) {
					CUForm.ShowDialog();
				}
			} catch { }
		}
	}
	#endregion
}