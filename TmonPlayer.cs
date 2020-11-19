using System;
using Terraria;
using System.IO;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace tmonadds
{
    public class TmonPlayer : ModPlayer
    {
        int count = 1;
        int previous = -1;
        public bool nullified = false;
        public bool PokeMini = false;
        public bool Pikachu = false;
        public bool PikachuDefault = false;
        bool PikachuActive = false;

        public override void FrameEffects() // As above, same order, happy coding. One of the files needed to get the costume going.
        {

            if (PikachuDefault)
            {
                player.head = mod.GetEquipSlot("PikachuHead", EquipType.Head);
                player.body = mod.GetEquipSlot("PikachuBody", EquipType.Body);
                player.legs = mod.GetEquipSlot("PikachuLegs", EquipType.Legs);
            }

            if (nullified) // This won't ever happen unless you call it, but don't touch this regardless.
            {
                Nullify();
            }
        }

        private void Nullify()
        {
            player.ResetEffects();
            player.head = -1;
            player.body = -1;
            player.legs = -1;
            nullified = true;
        }

        //Playable Character Buffs

        public override void PostUpdateEquips()
        {
            if (Pikachu)
            {
                player.lifeRegen += 2;
                player.autoJump = true;
                player.noFallDmg = true;
                player.buffImmune[BuffID.Venom] = true;
                player.buffImmune[BuffID.Poisoned] = true;
            }
            if (NPC.downedMoonlord)
            {
                player.statLifeMax2 += 1000;
            }
        }

        public override void PostUpdate()
        {
            if (Pikachu && !PikachuActive)
            {
                CombatText.NewText(player.Hitbox, Color.White, "Pika Pika!", true);
                for (int i = 0; i < 10; i++)
                {
                    Dust.NewDust(player.position, player.width, player.height, mod.DustType("SmokeTransformDust"));
                }
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/pika_pika"));
                PikachuActive = true;
            }

            if (!Pikachu)
            {
                PikachuActive = false;
            }

            if (Pikachu)
            {
                if (player.controlJump && player.justJumped && !player.wet)
                {
                    Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/pkmn_jump"));
                }
            }

            if (player.velocity.Y == 0f)
            {
                count = 1;
            }

            if (player.velocity.Y > 0f)// player is falling
            {
                Rectangle rect = player.getRect();
                rect.Offset(0, player.height + 1);
                rect.Height = 2;
                rect.Inflate(12, 6);
                for (int i = 0; i < 200; i++)
                {
                    NPC nPC = Main.npc[i];

                    if (count == 50)
                    {
                        break;
                    }

                    else if (nPC.active && !nPC.dontTakeDamage && !nPC.friendly && nPC.immune[player.whoAmI] == 0)
                    {
                        Rectangle rect2 = nPC.getRect();
                        if (rect.Intersects(rect2) && (nPC.noTileCollide || Terraria.Collision.CanHit(player.position, player.width, player.height, nPC.position, nPC.width, nPC.height)))
                        {
                            float num = ((50f - (count * 10)) * player.meleeDamage);//<------------------ the damage itself

                            float knockback = 2f / count;
                            int direction = player.direction;
                            if (player.velocity.X < 0f)
                            {
                                direction = -1;
                            }
                            if (player.velocity.X > 0f)
                            {
                                direction = 1;
                            }
                            if (player.whoAmI == Main.myPlayer)
                            {
                                player.ApplyDamageToNPC(nPC, (int)num, knockback, direction, false);
                            }

                            nPC.immune[player.whoAmI] = 10;
                            if (player.controlJump == true)
                            {
                                player.velocity.Y = -10f;
                            }
                            if (player.controlJump == false)
                            {
                                player.velocity.Y = -6f;
                            }
                            player.immune = true;          //makes immune upon a stomp, in this case to prevent damage because of collission with a damaging NPC.
                            player.immuneNoBlink = true;  //stops blinking when immune
                            player.immuneTime = 3;       //immunity time after jump

                            Dust.NewDust(player.position, player.width, player.height, mod.DustType("Stars"));

                            count++;

                            break;
                        }
                    }
                }
            }
        }
        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            int currentSound = 0;
            int customSoundType = 0;

            if (Pikachu)
            {
                playSound = false;
                currentSound = mod.GetSoundSlot(SoundType.Custom, "Sounds/pokedie");
                customSoundType = SoundLoader.customSoundType;
                Main.PlaySound(customSoundType, (int)Main.player[Main.myPlayer].position.X, (int)Main.player[Main.myPlayer].position.Y, currentSound, 0.9f, 0f);
            }
            return true;
        }
    }
}