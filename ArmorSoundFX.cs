using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace tmonadds
{

    class ArmorSoundFX : ModPlayer
    {
        public bool isPikachu;

        public override void ResetEffects()// <------------ this is ncessary so that the player will stop making our sweet sounds whenever he/she takes the costume off.
        {
            isPikachu = false;
        }

        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection,
            ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            int currentSound = 0;
            int customSoundType = 0;
            TmonPlayer TmonPlayer = Main.LocalPlayer.GetModPlayer<TmonPlayer>();

            if (TmonPlayer.Pikachu)
            {
                playSound = false;
                currentSound = mod.GetSoundSlot(SoundType.Custom, "Sounds/pokehit");
                customSoundType = SoundLoader.customSoundType;
                Main.PlaySound(customSoundType, (int)Main.player[Main.myPlayer].position.X, (int)Main.player[Main.myPlayer].position.Y, currentSound, 0.32f, 0f);
            }
            return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource);
        }
    }
}
