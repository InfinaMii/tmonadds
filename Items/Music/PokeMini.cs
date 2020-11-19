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
            TAddOns.PokeMini = true;
			TAddOns.MusicTimer += 1;
		}
}
}
