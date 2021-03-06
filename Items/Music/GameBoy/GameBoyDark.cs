using Terraria;
using Terraria.ID;

namespace tmonadds.Items.Music.GameBoy
{
    public class GameBoyDark : GameBoy
    {
        public const string TOOLTIP = "It's an 8-bit handheld console." +
                                      "\n[c/33ceff:Equip this to listen to music from Kanto!]" +
                                      "\n[c/FFFF66:Soundtrack: Lavender Town]";


        public GameBoyDark() : base("Dark", TOOLTIP, Item.sellPrice(gold: 6, silver: 6, copper: 6), ItemRarityID.Orange, "Dark")
        {
        }
    }

    public class TileBoyDark : TileBoy
    {

        public TileBoyDark() : base("Dark")
        {
        }
    }
}