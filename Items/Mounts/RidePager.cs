using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace tmonadds.Items.Mounts
{
	public class RidePager : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Summons a Pokemon to ride.");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 30000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = MountType<Latis.Latias>();
		}
	}
}