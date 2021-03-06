using Terraria;
using Terraria.ID;

namespace tmonadds.Items.Music.GameBoy
{
    public class GameBoyRed : GameBoy
    {
        public const string TOOLTIP = "It's an 8-bit handheld console." +
                                      "\n[c/33ceff:Equip this to listen to music from Kanto!]" +
                                      "\n[c/FFFF66:Soundtrack: Victory Road]";


        public GameBoyRed() : base("Red", TOOLTIP, Item.sellPrice(gold: 5), ItemRarityID.Orange, "Red")
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