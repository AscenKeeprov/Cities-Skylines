namespace Localizer.Services
{
	public interface ILogger
	{
		string OutputPath { get; }

		void Clear();
		void Log(string message);
	}
}
