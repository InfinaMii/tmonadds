using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terramon.Pokemon.SpawnRates;

namespace Terramon.Pokemon.Originals.Normal.Coolotad
{
    public class CoolotadNPC : ParentPokemonNPC
    { public override string Texture => "Terramon/Pokemon/Originals/Normal/Coolotad/Coolotad";
        public override Type HomeClass()
        {
            return typeof(Coolotad);
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.width = 20;
            npc.height = 20;
            npc.scale = 1f;
        }



        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = Main.LocalPlayer;
            if (PlayerIsInForest(player))
                return 0f;
            return 0f;
        }
    }
}
