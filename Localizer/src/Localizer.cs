using ColossalFramework.Plugins;
using ICities;

namespace Localizer
{
	public class Localizer : IUserMod
	{
		public string Name => "Localizer";

		public string Description => "Cities Skylines Localization Mod";
	}

	public class Loader : LoadingExtensionBase
	{
		public override void OnCreated(ILoading loading)
		{
			DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "[Localizer] Mod is loading...");
			base.OnCreated(loading);
		}
	}
}
