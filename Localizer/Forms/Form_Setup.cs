using Localizer.Core;
using Localizer.Forms;
using Localizer.Services;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Localizer
{
	public partial class Form_Setup : Form
	{
		private readonly ILogger _logger;

		public Form_Setup(ILogger logger)
		{
			_logger = logger;
			InitializeComponent();
		}

		private Color ColorBackLight => Color.FromArgb(232, 238, 242);
		private Color ColorDarkEmerald => Color.FromArgb(0, 80, 105);
		private Color ColorPaleGreyn => Color.FromArgb(150, 152, 152);

		private Language[] Languages { get; set; } = new Language[0];
		private DirectoryInfo LocalesDir { get; set; } = null;
		private Mode TranslateMode { get; set; } = Mode.None;

		private void Button_InstallPathBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog { ShowNewFolderButton = false };
			DialogResult dr = fbd.ShowDialog();
			if (dr == DialogResult.OK)
			{
				try
				{
					string localesPath = $@"{fbd.SelectedPath}\Files\Locale";
					if (!File.Exists($@"{fbd.SelectedPath}\Cities.exe")
						|| !File.Exists($@"{localesPath}\en.{Constants.LocaleFileExtension}"))
					{
						MessageBox.Show("Invalid folder!\n\nRequisite Cities: Skylines files are not present.");
					}
					else
					{
						TextBox_InstallPath.Text = fbd.SelectedPath;
						LocalesDir = new DirectoryInfo(localesPath);
						_logger.Log($"Locales dir set to: {LocalesDir.FullName}");
					}
				}
				catch (Exception exception)
				{
					_logger.Log(exception.Message);
				}
			}
		}

		private void Button_MouseEnter(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				button.FlatAppearance.MouseOverBackColor = ColorBackLight;
				button.FlatAppearance.BorderColor = ColorDarkEmerald;
				button.ForeColor = ColorDarkEmerald;
			}
		}

		private void Button_MouseHover(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				button.FlatAppearance.MouseOverBackColor = ColorBackLight;
				button.FlatAppearance.BorderColor = ColorDarkEmerald;
				button.ForeColor = ColorDarkEmerald;
			}
		}

		private void Button_MouseLeave(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				button.FlatAppearance.BorderColor = ColorPaleGreyn;
				button.ForeColor = SystemColors.ControlText;
			}
		}

		private void Button_Start_Click(object sender, EventArgs e)
		{
			try
			{
				Language selectedLanguage = ComboBox_Language.SelectedItem as Language;
				bool compareToEnglish = CheckBox_CompareToEN.Checked;
				Form_Translate translateForm = new Form_Translate(LocalesDir, selectedLanguage, TranslateMode, _logger, compareToEnglish);
				this.Hide();
				translateForm.Show();
			}
			catch (Exception exception)
			{
				_logger.Log(exception.Message);
			}
		}

		private void Form_Setup_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0) Application.Exit();
		}

		private void Form_Setup_Load(object sender, EventArgs e)
		{
			_logger.Clear();
			_logger.Log("Starting application");
			LoadLanguageData();
		}

		private void LoadLanguageData()
		{
			//TODO: CLEAN UP
			//var cultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures)
			//	.Where(ci => !string.IsNullOrEmpty(ci.Name)
			//	 && string.IsNullOrEmpty(ci.Parent.Name)
			//	 && ci.TextInfo.ANSICodePage != 0)
			//	.ToArray();
			try
			{
				Languages = CultureInfo.GetCultures(CultureTypes.NeutralCultures)
					.Where(ci => !string.IsNullOrEmpty(ci.Name)
					 && string.IsNullOrEmpty(ci.Parent.Name)
					 && ci.TextInfo.ANSICodePage != 0)
					.Select(ci => new Language(ci.TwoLetterISOLanguageName,
					 Regex.Replace(ci.DisplayName, @"^isi(?=\p{L}+)", string.Empty)))
					.ToArray();
				_logger.Log("Language data loaded");
			}
			catch (Exception exception)
			{
				_logger.Log(exception.Message);
			}
		}

		private void RadioButton_Operation_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is RadioButton rb && rb.Checked)
			{
				ComboBox_Language.Enabled = true;
				Button_Start.Enabled = true;
				TranslateMode = (Mode)Enum.Parse(typeof(Mode), rb.Tag.ToString(), true);
				string[] availableLocales = LocalesDir.GetFiles($"*.{Constants.LocaleFileExtension}")
					.Select(fi => Path.GetFileNameWithoutExtension(fi.FullName)).ToArray();
				switch (TranslateMode)
				{
					case Mode.Create:
						ComboBox_Language.DataSource = Array.FindAll(Languages,
							l => Array.IndexOf(availableLocales, l.Code) < 0);
						CheckBox_CompareToEN.Checked = true;
						CheckBox_CompareToEN.Enabled = false;
						break;
					case Mode.Edit:
						ComboBox_Language.DataSource = Array.FindAll(Languages,
							l => Array.Exists(availableLocales, al => al == l.Code));
						CheckBox_CompareToEN.Enabled = true;
						CheckBox_CompareToEN.Checked = false;
						break;
					default:
						ComboBox_Language.DataSource = Languages;
						break;
				}
			}
		}

		private void TextBox_InstallPath_TextChanged(object sender, EventArgs e)
		{
			GroupBox_ActionRadioButtons.Enabled = true;
		}
	}
}
