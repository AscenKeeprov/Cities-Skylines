using Localizer.Utils;
using System;
using System.Windows.Forms;

namespace Localizer
{
	public class LocalizerContext : ApplicationContext
	{
		public LocalizerContext() : base()
		{
			Application.ApplicationExit += new EventHandler(OnApplicationExit);
		}

		private void OnApplicationExit(object sender, EventArgs eventArgs)
		{
			Logger.Log("Exiting application");
		}
	}
}
