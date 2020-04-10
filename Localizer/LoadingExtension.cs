using ColossalFramework.Plugins;
using ICities;
using System.Reflection;

namespace Localizer
{
	public sealed class LoadingExtension : LoadingExtensionBase
	{
		private string ModName => Assembly.GetExecutingAssembly().GetName().Name;

		public override void OnCreated(ILoading loading)
		{
			base.OnCreated(loading);
			DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, $"[{ModName}] Mod is loading...");
		}
	}
}
