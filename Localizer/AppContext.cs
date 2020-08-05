using Localizer.Services;
using System;
using System.Windows.Forms;

namespace Localizer
{
	public class AppContext : ApplicationContext
	{
		private readonly ILogger _logger;

		public AppContext(ILogger logger) : base()
		{
			_logger = logger;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ApplicationExit += new EventHandler(OnApplicationExit);
			MainForm = new Form_Setup(logger);
		}

		private void OnApplicationExit(object sender, EventArgs eventArgs)
		{
			_logger.Log("Exiting application");
		}
	}
}
