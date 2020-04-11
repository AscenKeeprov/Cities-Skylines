using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Localizer.Utils
{
	public static class Logger
	{
		private static string LogFileName => $"{Application.ProductName}.log";
		private static string TempPath => Path.GetTempPath();

		public static void Clear()
		{
			File.WriteAllText($"{TempPath}{LogFileName}", string.Empty);
		}

		private static string GenerateTimestamp()
		{
			string timestampFormat = "yyyy-MMM-d_HH:mm:ss:ffffff";
			CultureInfo timestampCulture = new CultureInfo("en-GB");
			return DateTime.Now.ToString(timestampFormat, timestampCulture);
		}

		public static void Log(string message)
		{
			string timestamp = GenerateTimestamp();
			using (StreamWriter writer = File.AppendText($"{TempPath}{LogFileName}"))
			{
				writer.WriteLine($"[{timestamp}] {message}");
				writer.Close();
			}
		}
	}
}
