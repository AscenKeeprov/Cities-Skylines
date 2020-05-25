using Localizer.Core;
using System;
using System.IO;
using System.Windows.Forms;

namespace Localizer
{
	public static class App
	{
		public static DirectoryInfo ProjectDirectory => new DirectoryInfo(AppContext.BaseDirectory).Parent.Parent;

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form mainForm = new Form_Setup();
			mainForm.Show();
			LocalizerContext appContext = new LocalizerContext();
			Application.Run(appContext);
		}
	}
}