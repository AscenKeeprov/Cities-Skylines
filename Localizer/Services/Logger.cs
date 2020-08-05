using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Localizer.Services
{
	public class Logger : ILogger
	{
		private readonly string _logFileName;

		public string OutputPath { get; }

		public Logger()
		{
			_logFileName = $"{Application.ProductName}.log";
			OutputPath = Path.GetTempPath();
		}

		public void Clear()
		{
			File.WriteAllText($"{OutputPath}{_logFileName}", string.Empty);
		}

		private string GenerateTimestamp()
		{
			string timestampFormat = "yyyy-MMM-d_HH:mm:ss:ffffff";
			CultureInfo timestampCulture = new CultureInfo("en-GB");
			return DateTime.Now.ToString(timestampFormat, timestampCulture);
		}

		public void Log(string message)
		{
			string timestamp = GenerateTimestamp();
			using (StreamWriter writer = File.AppendText($"{OutputPath}{_logFileName}"))
			{
				writer.WriteLine($"[{timestamp}] {message}");
				writer.Close();
			}
		}
	}
}
