using Terraria;
using Terraria.ID;

namespace tmonadds.Items.Music.GameBoy
{
    public class GameBoyPink : GameBoy
    {
        public const string TOOLTIP = "It's an 8-bit handheld console." +
                                      "\n[c/33ceff:Equip this to listen to music from Kanto!]" +
                                      "\n[c/FFFF66:Soundtrack: Route 1]";


        public GameBoyPink() : base("Pink", TOOLTIP, Item.sellPrice(gold: 5), ItemRarityID.Orange, "Pink")
        {
        }
    }

    public class TileBoyPink : TileBoy
    {

        public TileBoyPink() : base("Pink")
        {
        }
    }
}