using ColossalFramework.Globalization;
using ColossalFramework.IO;
using Localizer.Core;
using Localizer.Services;
using Localizer.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Localizer.Forms
{
	public partial class Form_Translate : Form
	{
		private readonly ILogger _logger;
		private bool CompareToEnglish { get; }
		private Dictionary<Locale.Key, string> LocaleDataEN { get; set; }
		private Dictionary<Locale.Key, string> LocaleDataTarget { get; set; }
		private DirectoryInfo LocalesDir { get; }
		private Language TargetLanguage { get; }
		private Mode TranslateMode { get; }

		public Form_Translate(DirectoryInfo localesDir, Language targetLanguage, Mode translateMode, ILogger logger, bool compareToEnglish = true)
		{
			_logger = logger;
			CompareToEnglish = compareToEnglish && targetLanguage.Code != "en";
			LocalesDir = localesDir;
			TargetLanguage = targetLanguage;
			TranslateMode = translateMode;
			InitializeComponent();
		}

		private void DataGridView_Translation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			//TODO: HANDLE CELL VALUE CHANGE
			MessageBox.Show("Handle cell value change!");
		}

		private void Form_Translate_FormClosed(object sender, FormClosedEventArgs e)
		{
			Form_Setup setupForm = Application.OpenForms.OfType<Form_Setup>()
				.FirstOrDefault() ?? new Form_Setup(_logger);
			setupForm.Show();
		}

		private void Form_Translate_FormClosing(object sender, FormClosedEventArgs e)
		{
			this.Hide();
		}

		private void Form_Translate_Load(object sender, EventArgs e)
		{
			_logger.Log($"Target locale set to: {TargetLanguage}");
			try
			{
				LocaleDataEN = UnpackLocaleFile($@"{LocalesDir.FullName}\en.{Constants.LocaleFileExtension}");
				switch (TranslateMode)
				{
					case Mode.Edit:
						LocaleDataTarget = UnpackLocaleFile($@"{LocalesDir.FullName}\{TargetLanguage.Code}.{Constants.LocaleFileExtension}");
						break;
					default:
						LocaleDataTarget = LocaleDataEN.ToDictionary(kvp => kvp.Key, kvp => string.Empty);
						break;
				}
				DataTable localeDataTable = new DataTable();
				DataColumn idColumn = new DataColumn
				{
					ColumnName = "Identifier",
					ReadOnly = true
				};
				localeDataTable.Columns.Add(idColumn);
				DataColumn targetDescriptionColumn = new DataColumn()
				{
					ColumnName = $"Description - {TargetLanguage.Name} [{TargetLanguage.Code.ToUpper()}]"
				};
				localeDataTable.Columns.Add(targetDescriptionColumn);
				DataColumn enDescriptionColumn = new DataColumn()
				{
					ColumnName = "Description - English [EN]",
					ReadOnly = true
				};
				if (CompareToEnglish) localeDataTable.Columns.Add(enDescriptionColumn);
				foreach (KeyValuePair<Locale.Key, string> entry in LocaleDataEN)
				{
					DataRow row = localeDataTable.NewRow();
					row[idColumn] = entry.Key.ToString();
					row[targetDescriptionColumn] = LocaleDataTarget.ContainsKey(entry.Key) ? LocaleDataTarget[entry.Key] : string.Empty;
					if (CompareToEnglish) row[enDescriptionColumn] = entry.Value;
					localeDataTable.Rows.Add(row);
					//TODO: DELETE AFTER TESTING
					//if (localeDataTable.Rows.Count >= 21) break;
				}
				DataGridView_Translation.DataSource = localeDataTable;
				foreach (DataGridViewColumn column in DataGridView_Translation.Columns)
				{
					if (column.Name == idColumn.ColumnName) column.DefaultCellStyle = new DataGridViewCellStyle()
					{
						BackColor = Color.FromArgb(240, 242, 244)
					};
					//TODO: DELETE IF Cities: Skylines CAN LOAD CUSTOM SORTED LOCALES
					column.SortMode = DataGridViewColumnSortMode.NotSortable;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show($"An error has occured!\n\nLog file available at {_logger.OutputPath}");
				_logger.Log(exception.Message);
				_logger.Log(exception.StackTrace);
			}
		}
		private Dictionary<Locale.Key, string> UnpackLocaleFile(string localePath)
		{
			using (FileStream fs = new FileStream(localePath, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				Locale locale = DataSerializer.Deserialize<Locale>(fs, DataSerializer.Mode.File);
				return ObjectManager.GetPrivateField(locale, "m_LocalizedStrings") as Dictionary<Locale.Key, string>;
			}
		}
	}
}
