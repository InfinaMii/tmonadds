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
using tmonadds.Items.Music;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace tmonadds
{
	class TAddOns : Mod
	{

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
			if (MusicBoy.MusicEquipped == true)
			{
				if (player.ZoneSnow && !Main.dayTime)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/LakeVerity");
					priority = MusicPriority.BiomeHigh;
				}
				else if (player.ZoneBeach && !Main.dayTime)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndellaTown");
					priority = MusicPriority.BiomeHigh;
				}
			}
		}
	}
}
