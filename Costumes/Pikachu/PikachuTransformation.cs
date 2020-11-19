using Terraria;
using Terraria.ModLoader;

namespace tmonadds.Costumes.Pikachu
{
    public class PikachuTransformation : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pikachu Plush Doll");
            Tooltip.SetDefault("Transforms you into a Pikachu!");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 56;
			item.rare = 5;
            item.value = 0;
            item.accessory = true;     
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            TmonPlayer modPlayer = player.GetModPlayer<TmonPlayer>();
            modPlayer.PikachuDefault = true;
            modPlayer.Pikachu = true;
            player.GetModPlayer<ArmorSoundFX>().isPikachu = true;
        }
    }

    public class PikachuHead : EquipTexture
    {
        public override bool DrawHead()
        {
            return false;
        }
    }

    public class PikachuBody : EquipTexture
    {
        public override bool DrawBody()
        {
            return false;
        }
    }

    public class PikachuLegs : EquipTexture
    {
        public override bool DrawLegs()
        {
            return false;		
		}
	}
}