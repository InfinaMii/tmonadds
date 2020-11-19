using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria;


namespace tmonadds.Items.Music
{
	public class MusicBoy : ModItem
	{
		public static bool MusicEquipped = false;

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Music Boy");
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
			MusicEquipped = true;
		}
	}
}
