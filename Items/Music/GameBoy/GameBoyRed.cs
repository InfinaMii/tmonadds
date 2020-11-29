using Terraria;
using Terraria.ID;

namespace tmonadds.Items.Music.GameBoy
{
    public class GameBoyRed : GameBoy
    {
        public const string TOOLTIP = "It's an 8-bit handheld console." +
                                      "\n[c/33ceff:Equip this to listen to music from Pokémon Fire Red!]" +
                                      "\n[c/FFFF66:Soundtrack: Trainer Battle]";


        public GameBoyRed() : base("Red", TOOLTIP, Item.sellPrice(gold: 5), ItemRarityID.Orange)
        {
        }
    }

    public class TileBoyRed : TileBoy
    {

        public TileBoyRed() : base("Red")
        {
        }
    }
}