using Localizer.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Localizer
{
	public static class App
	{
		[STAThread]
		public static void Main()
		{
			ServiceCollection services = new ServiceCollection();
			ConfigureServices(services);
			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				ILogger logger = serviceProvider.GetRequiredService<ILogger>();
				AppContext appContext = new AppContext(logger);
				Application.Run(appContext);
			}
		}

		private static void ConfigureServices(ServiceCollection services)
		{
			services.AddSingleton<ILogger, Logger>();
		}
	}
}
