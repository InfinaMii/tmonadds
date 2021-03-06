using Terraria;
using Terraria.ID;

namespace tmonadds.Items.Music.GameBoy
{
    public class GameBoyGray : GameBoy
    {
        public const string TOOLTIP = "It's an 8-bit handheld console." +
                                      "\n[c/33ceff:Equip this to listen to music from Kanto!]" +
                                      "\n[c/FFFF66:Soundtrack: Oak's Lab]";


        public GameBoyGray() : base("Gray", TOOLTIP, Item.sellPrice(gold: 5), ItemRarityID.Orange, "Gray")
        {
        }
    }

    public class TileBoyGray : TileBoy
    {

        public TileBoyGray() : base("Gray")
        {
        }
    }
}