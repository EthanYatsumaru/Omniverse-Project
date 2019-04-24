using Terraria.ModLoader;

namespace OmniverseProject
{
	class OmniverseProject : Mod
	{
		public OmniverseProject()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
