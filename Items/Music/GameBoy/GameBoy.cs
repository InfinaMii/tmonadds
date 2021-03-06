using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace tmonadds.Items.Music.GameBoy
{
    public abstract class GameBoy : TerramonItem
    {
        /// <summary></summary>
        /// <param name="color"></param>
        /// <param name="tooltip"></param>
        /// <param name="value"></param>
        /// <param name="rarity"></param>
        protected GameBoy(string color, string tooltip, int value, int rarity, string musicPath) : base(
            $"Game Boy ({color})", tooltip, 22, 32, value, 0, rarity)
        {
            MusicPath = musicPath;
            colour = color;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();

            item.maxStack = 1;
            item.useStyle = 1;
            item.useTime = 34;
            item.useAnimation = 34;
            item.useStyle = 4;
            item.consumable = true;
            item.accessory = true;
            item.autoReuse = true;
            item.createTile = mod.TileType($"TileBoy{colour}");
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
            Main.musicBox2 = mod.GetSoundSlot(SoundType.Music, $"Sounds/Music/GameBoy/GB_{MusicPath}{Ver}");
        }

        public string colour { get; }
        public string MusicPath { get; }
    }

    public abstract class TileBoy : ModTile
    {
        /// <summary></summary>
        /// <param name="color"></param>
        /// <param name="tooltip"></param>
        /// <param name="value"></param>
        /// <param name="rarity"></param>
        protected TileBoy(string color) : base()
        { colour = color; }

        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType($"GameBoy{colour}"));
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];

            if (tile.frameX > 18)
            {
                // We can support different light colors for different styles here: switch (tile.frameY / 54)
                r = 1f;
                g = 0.6f;
                b = 0.6f;
            }
        }

        /*public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            Tile tile = Main.tile[i, j];

            if (tile.frameX > 18)
            {
                player.showItemIcon2 = mod.ItemType("switchIcon");
            }
            else
            {
                player.showItemIcon2 = mod.ItemType("switchIcon2");
            }
        }*/

        public string colour { get; }
    }
}