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
			LocalizerContext appContext = new LocalizerContext(new Main());
			Application.Run(appContext);
		}
	}
}