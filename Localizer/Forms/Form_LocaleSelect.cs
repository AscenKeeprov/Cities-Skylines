using Localizer.Utils;
using System;
using System.Windows.Forms;

namespace Localizer.Forms
{
	public partial class Form_LocaleSelect : Form
	{
		public Form_LocaleSelect(string installPath)
		{
			InstallPath = installPath;
			InitializeComponent();
		}

		private string InstallPath { get; set; }

		private void Form_LocaleSelect_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0) Application.Exit();
		}

		private void Form_LocaleSelect_Load(object sender, EventArgs e)
		{
			Logger.Log($"C:S install dir set to: {InstallPath}");
		}
	}
}
