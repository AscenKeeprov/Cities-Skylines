using System;
using System.Windows.Forms;

namespace Localizer
{
	public static class Program
	{
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form mainForm = new Form_InstallPathSelect();
			mainForm.Show();
			LocalizerContext appContext = new LocalizerContext();
			Application.Run(appContext);
		}
	}
}