using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace tmonadds.Items.Mounts.Lapras
{
	public class LaprasMount : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Lapras");
			Description.SetDefault("Leather seats, 4 cup holders");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(MountType<Lapras>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
