using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tmonadds
{
    public class TGlobalItem : GlobalItem
    {

		public override void UseStyle(Item item, Player player)
		{
            TmonPlayer TmonPlayer = Main.LocalPlayer.GetModPlayer<TmonPlayer>();
            if (TmonPlayer.Pikachu)
            {
                player.itemLocation.Y += 8;
            }
            else
            {
                
            }
        }

	}
}