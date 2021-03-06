using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria;


namespace tmonadds.Items.Music
{
	public class PokeMini : ModItem
	{

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pokemon Mini");
		}

		public override void SetDefaults() {
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.LightRed;
			item.value = 100000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			base.UpdateAccessory(player, hideVisual);
			//TAddOns.Musics = MusicPath;
			string Ver;
			if (TAddOns.OldMusic)
				Ver = "_Old";
			else
				Ver = "_New";
			Main.musicBox2 = mod.GetSoundSlot(SoundType.Music, $"Sounds/Music/{TAddOns.pokeMini}");
		}
	}
}
