using Terraria;
using Terraria.ID;

namespace tmonadds.Items.Music.GameBoy
{
    public class GameBoyGreen : GameBoy
    {
        public const string TOOLTIP = "It's an 8-bit handheld console." +
                                      "\n[c/33ceff:Equip this to listen to music from Pokémon Fire Red!]" +
                                      "\n[c/FFFF66:Soundtrack: Pewter City]";


        public GameBoyGreen() : base("Green", TOOLTIP, Item.sellPrice(gold: 5), ItemRarityID.Orange)
        {
        }
    }

    public class TileBoyGreen : TileBoy
    {

        public TileBoyGreen() : base("Green")
        {
        }
    }
}