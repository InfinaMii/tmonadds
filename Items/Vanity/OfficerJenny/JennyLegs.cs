using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace tmonadds.Items.Vanity.OfficerJenny
{
	[AutoloadEquip(EquipType.Legs)]
	public class JennyLegs : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Jenny Heels");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.vanity = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlackDye, 1);
			recipe.AddIngredient(ItemID.Silk, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}