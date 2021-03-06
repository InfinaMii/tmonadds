using Terraria;
using Terraria.ID;

namespace tmonadds.Items.Music.GameBoy
{
    public class GameBoyYellow : GameBoy
    {
        public const string TOOLTIP = "It's an 8-bit handheld console." +
                                      "\n[c/33ceff:Equip this to listen to music from Kanto!]" +
                                      "\n[c/FFFF66:Soundtrack: Team Rocket Hideout]";


        public GameBoyYellow() : base("Yellow", TOOLTIP, Item.sellPrice(gold: 5), ItemRarityID.Orange, "Yellow")
        {
        }
    }

    public class TileBoyYellow : TileBoy
    {

        public TileBoyYellow() : base("Yellow")
        {
        }
    }
}