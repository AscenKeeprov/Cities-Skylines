using Localizer.Forms;
using Localizer.Utils;
using System;
using System.Windows.Forms;

namespace Localizer
{
	public partial class Form_InstallPathSelect : Form
	{
		public Form_InstallPathSelect()
		{
			InitializeComponent();
		}

		private void Form_InstallPathSelect_Load(object sender, EventArgs e)
		{
			Logger.Clear();
			Logger.Log("Starting application");
		}

		private void Form_InstallPathSelect_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0) Application.Exit();
		}

		private void Form_InstallPathSelect_FormClosing(object sender, FormClosingEventArgs e)
		{
			Logger.Log("Closing main form");
		}

		private void Button_InstallPathBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.ShowNewFolderButton = false;
			DialogResult result = dialog.ShowDialog();
			if (result == DialogResult.OK) TextBox_InstallPath.Text = dialog.SelectedPath;
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

		private void TextBox_InstallPath_TextChanged(object sender, EventArgs e)
		{
			Button_InstallPathNext.Enabled = !string.IsNullOrEmpty(TextBox_InstallPath.Text);
		}
	}
}
