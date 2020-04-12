using Localizer.Core;
using Localizer.Forms;
using Localizer.Utils;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Localizer
{
	public partial class Form_Setup : Form
	{
		public Form_Setup()
		{
			InitializeComponent();
		}

		public Language[] Languages { get; private set; } = new Language[0];
		public DirectoryInfo LocalesDir { get; private set; } = null;
		public Operation SelectedOperation { get; private set; } = Operation.None;

		private void Button_InstallPathBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.ShowNewFolderButton = false;
			DialogResult dr = fbd.ShowDialog();
			if (dr == DialogResult.OK)
			{
				try
				{
					LocalesDir = new DirectoryInfo($@"{fbd.SelectedPath}\Files\Locale");
					if (!File.Exists($@"{fbd.SelectedPath}\Cities.exe")
						|| !File.Exists($@"{LocalesDir.FullName}\en.locale"))
					{
						MessageBox.Show("Invalid folder!\n\nRequisite Cities: Skylines files are not present.");
					}
					else
					{
						TextBox_InstallPath.Text = fbd.SelectedPath;
						GroupBox_ActionRadioButtons.Enabled = true;
						Logger.Log($"C:S install dir set to: {TextBox_InstallPath.Text}");
					}
				}
				catch (Exception exception)
				{
					Logger.Log(exception.Message);
				}
			}
		}

		private void Button_InstallPathNext_Click(object sender, EventArgs e)
		{
			try
			{
				Form_LocaleSelect nextForm = new Form_LocaleSelect(TextBox_InstallPath.Text);
				this.Hide();
				nextForm.Show();
				this.Close();
			}
			catch (Exception exception)
			{
				Logger.Log(exception.Message);
			}
		}

		private void Form_Setup_Load(object sender, EventArgs e)
		{
			Logger.Clear();
			Logger.Log("Starting application");
			LoadLanguageData();
		}

		private void Form_Setup_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0) Application.Exit();
		}

		private void LoadLanguageData()
		{
			try
			{
				string langJsonPath = Path.Combine(App.ProjectDirectory.FullName, @"Data\iso_639-1_language_codes.json");
				string langJson = File.ReadAllText(langJsonPath);
				Languages = JsonSerializer.Deserialize<Language[]>(langJson, new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true
				});
				Array.Sort(Languages);
				Logger.Log("Language data loaded");
			}
			catch (Exception exception)
			{
				Logger.Log(exception.Message);
			}
		}

		private void RadioButton_Operation_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is RadioButton rb && rb.Checked)
			{
				SelectedOperation = (Operation)Enum.Parse(typeof(Operation), rb.Tag.ToString(), true);
				ComboBox_Language.Enabled = true;
				string[] availableLocales = LocalesDir.GetFiles("*.locale")
						.Select(f => Path.GetFileNameWithoutExtension(f.FullName)).ToArray();
				switch (SelectedOperation)
				{
					case Operation.Create:
						ComboBox_Language.DataSource = Array.FindAll(Languages,
						l => Array.IndexOf(availableLocales, l.Code) < 0);
						break;
					case Operation.Edit:
						ComboBox_Language.DataSource = Array.FindAll(Languages,
						l => Array.Exists(availableLocales, al => al == l.Code));
						break;
					default:
						ComboBox_Language.DataSource = Languages;
						break;
				}
			}
		}

		private void TextBox_InstallPath_TextChanged(object sender, EventArgs e)
		{
			Button_InstallPathNext.Enabled = !string.IsNullOrEmpty(TextBox_InstallPath.Text);
		}
	}
}
