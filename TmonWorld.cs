using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tmonadds
{
    public class TmonWorld : ModWorld
    {
        public static int grayGB = 0;
        public static int redGB = 0;
        public static int blueGB = 0;
        public static int yellowGB = 0;
        public static int greenGB = 0;
        public static int pinkGB = 0;
        public static int darkGB = 0;

        public override void TileCountsAvailable(int[] tileCounts)
        {
            grayGB = tileCounts[mod.TileType("TileBoyGray")];
            redGB = tileCounts[mod.TileType("TileBoyRed")];
            blueGB = tileCounts[mod.TileType("TileBoyBlue")];
            yellowGB = tileCounts[mod.TileType("TileBoyYellow")];
            greenGB = tileCounts[mod.TileType("TileBoyGreen")];
            pinkGB = tileCounts[mod.TileType("TileBoyPink")];
            darkGB = tileCounts[mod.TileType("TileBoyDark")];
        }
    }
}
