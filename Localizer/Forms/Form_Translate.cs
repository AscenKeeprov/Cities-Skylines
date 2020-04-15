using Localizer.Core;
using Localizer.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace Localizer.Forms
{
	public partial class Form_Translate : Form
	{
		public Form_Translate(DirectoryInfo localesDir, Language targetLocale, bool compareToEnglish = true)
		{
			CompareToEnglish = compareToEnglish && targetLocale.Code != "en";
			LocalesDir = localesDir;
			TargetLocale = targetLocale;
			InitializeComponent();
		}

		private bool CompareToEnglish { get; }
		private DirectoryInfo LocalesDir { get; }
		private Language TargetLocale { get; }

		private void Form_Translate_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0) Application.Exit();
		}

		private void Form_Translate_Load(object sender, EventArgs e)
		{
			Logger.Log($"Target locale set to: {TargetLocale}");
		}
	}
}
