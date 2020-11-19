using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using tmonadds;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace tmonadds
{
	public class TAddOns : Mod
	{
		public static bool PokeMini = false;
		public static int MusicTimer;
		public static int MusicCheck;

		public TAddOns()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public override void Load()
		{

			if (!Main.dedServ)
			{
				
				AddEquipTexture(new Costumes.Pikachu.PikachuHead(), null, EquipType.Head, "PikachuHead", "tmonadds/Costumes/Pikachu/PikachuTransformation_Head");
				AddEquipTexture(new Costumes.Pikachu.PikachuBody(), null, EquipType.Body, "PikachuBody", "tmonadds/Costumes/Pikachu/PikachuTransformation_Body", "tmonadds/Costumes/Pikachu/PikachuTransformation_Arms", "tmonadds/Costumes/Pikachu/PikachuTransformation_Body");
				AddEquipTexture(new Costumes.Pikachu.PikachuLegs(), null, EquipType.Legs, "PikachuLegs", "tmonadds/Costumes/Pikachu/PikachuTransformation_Legs");

			}
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active) return;

			Player player = Main.LocalPlayer;
			if (PokeMini == true)
			{
				if (player.ZoneSnow && !Main.dayTime)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/PokeMini/LakeVerity");
					priority = MusicPriority.BiomeHigh;
				}
				else if (player.ZoneBeach && !Main.dayTime)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/PokeMini/UndellaTown");
					priority = MusicPriority.BiomeHigh;
                }

				MusicCheck += 1;
                if (MusicCheck > MusicTimer)
                {
                    PokeMini = false;
                }
            }
        }
    }
}
