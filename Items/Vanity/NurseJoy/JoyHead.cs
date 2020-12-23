using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace tmonadds.Items.Vanity.NurseJoy
{
	[AutoloadEquip(EquipType.Head)]
	public class JoyHead : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Joy Hat");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.vanity = true;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<JoyTorso>() && legs.type == ItemType<JoyLegs>();
		}

		public override void UpdateArmorSet(Player player) {
			/* Here are the individual weapon class bonuses.
			player.allDamage -= 0.2f;
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkDye, 1);
			recipe.AddIngredient(ItemID.Silk, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}