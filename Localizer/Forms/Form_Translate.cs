using ColossalFramework.Globalization;
using ColossalFramework.IO;
using Localizer.Core;
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
		public Form_Translate(DirectoryInfo localesDir, Language targetLocale, Mode translateMode, bool compareToEnglish = true)
		{
			CompareToEnglish = compareToEnglish && targetLocale.Code != "en";
			LocalesDir = localesDir;
			TargetLocale = targetLocale;
			TranslateMode = translateMode;
			InitializeComponent();
		}

		private bool CompareToEnglish { get; }
		private Dictionary<Locale.Key, string> LocaleDataEN { get; set; }
		private Dictionary<Locale.Key, string> LocaleDataTarget { get; set; }
		private DirectoryInfo LocalesDir { get; }
		private Language TargetLocale { get; }
		private Mode TranslateMode { get; }

		private void Form_Translate_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0) Application.Exit();
		}

		private void Form_Translate_Load(object sender, EventArgs e)
		{
			Logger.Log($"Target locale set to: {TargetLocale}");
			try
			{
				LocaleDataEN = UnpackLocaleFile($@"{LocalesDir.FullName}\en.{Constants.LocaleFileExtension}");
				switch (TranslateMode)
				{
					case Mode.Edit:
						LocaleDataTarget = UnpackLocaleFile($@"{LocalesDir.FullName}\{TargetLocale.Code}.{Constants.LocaleFileExtension}");
						break;
					default:
						LocaleDataTarget = LocaleDataEN.ToDictionary(kvp => kvp.Key, kvp => string.Empty);
						break;
				}
				DataTable localeDataTable = new DataTable();
				DataColumn columnID = new DataColumn
				{
					ColumnName = "Identifier",
					ReadOnly = true
				};
				localeDataTable.Columns.Add(columnID);
				DataColumn columnDescriptionTarget = new DataColumn($"Description [{TargetLocale.Code.ToUpper()}]");
				localeDataTable.Columns.Add(columnDescriptionTarget);
				DataColumn columnDescriptionEN = new DataColumn()
				{
					ColumnName = "Description [EN]",
					ReadOnly = true
				};
				if (CompareToEnglish) localeDataTable.Columns.Add(columnDescriptionEN);
				foreach (KeyValuePair<Locale.Key, string> entry in LocaleDataEN)
				{
					DataRow row = localeDataTable.NewRow();
					row[columnID] = entry.Key.ToString();
					row[columnDescriptionTarget] = LocaleDataTarget.ContainsKey(entry.Key) ? LocaleDataTarget[entry.Key] : string.Empty;
					if (CompareToEnglish) row[columnDescriptionEN] = entry.Value;
					localeDataTable.Rows.Add(row);
					//TODO: DELETE AFTER TESTING
					//if (localeDataTable.Rows.Count >= 21) break;
				}
				DataGridView_Translation.DataSource = localeDataTable;
				foreach (DataGridViewColumn column in DataGridView_Translation.Columns)
				{
					if (column.Name == columnID.ColumnName) column.DefaultCellStyle = new DataGridViewCellStyle()
					{
						BackColor = Color.FromArgb(240, 242, 244)
					};
					//TODO: DELETE IF Cities: Skylines CAN LOAD CUSTOM SORTED LOCALES
					column.SortMode = DataGridViewColumnSortMode.NotSortable;
				}
				//DataGridView_Translation.Columns[columnID.ColumnName].DefaultCellStyle = new DataGridViewCellStyle()
				//{
				//	BackColor = Color.FromArgb(240, 242, 244)
				//};
			}
			catch (Exception exception)
			{
				MessageBox.Show($"An error has occured!\n\nLog file available at {Logger.OutputPath}");
				Logger.Log(exception.Message);
				Logger.Log(exception.StackTrace);
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
