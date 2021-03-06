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
using Terramon;

namespace tmonadds
{
	public class TAddOns : Mod
	{
		public static string pokeMini;
		public static bool OldMusic = false;
		public static string Region = "Unova";
		public static string Musics;

		public TAddOns()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public void Update(GameTime gameTime)
        {
			if (Terramon.UI.Starter.ChooseStarter.shaderBar1Timer > 0 && !Terramon.UI.Starter.ChooseStarter.playedIntroMusic)
			{
				Terramon.UI.Starter.ChooseStarter.playedIntroMusic = true;
				Terramon.Players.TerramonPlayer p = Main.LocalPlayer.GetModPlayer<Terramon.Players.TerramonPlayer>();
				p.openingSfx = Main.PlaySound(SoundLoader.customSoundType, Style: ModContent.GetInstance<TerramonMod>().GetSoundSlot(SoundType.Custom, "Sounds/Music/Base/Hoenn/Opening"));
			}
		}

		public override void Load()
		{

			/*AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GameBoy/GB_TitleScreen"), ItemType("GameBoyGray"), TileType("TileBoyGray"));
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GameBoy/GB_TrainerBattle"), ItemType("GameBoyRed"), TileType("TileBoyRed"));
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GameBoy/GB_PalletTown"), ItemType("GameBoyBlue"), TileType("TileBoyBlue"));
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GameBoy/GB_FinalBattle"), ItemType("GameBoyYellow"), TileType("TileBoyYellow"));
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GameBoy/GB_PewterCity"), ItemType("GameBoyGreen"), TileType("TileBoyGreen"));
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GameBoy/GB_PokemonCenter" + Ver), ItemType("GameBoyPink"), TileType("TileBoyPink"));
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GameBoy/GB_LavenderTown"), ItemType("GameBoyDark"), TileType("TileBoyDark"));*/
			

			/*if (!Main.dedServ)
			{
				
				AddEquipTexture(new Costumes.Pikachu.PikachuHead(), null, EquipType.Head, "PikachuHead", "tmonadds/Costumes/Pikachu/PikachuTransformation_Head");
				AddEquipTexture(new Costumes.Pikachu.PikachuBody(), null, EquipType.Body, "PikachuBody", "tmonadds/Costumes/Pikachu/PikachuTransformation_Body", "tmonadds/Costumes/Pikachu/PikachuTransformation_Arms", "tmonadds/Costumes/Pikachu/PikachuTransformation_Body");
				AddEquipTexture(new Costumes.Pikachu.PikachuLegs(), null, EquipType.Legs, "PikachuLegs", "tmonadds/Costumes/Pikachu/PikachuTransformation_Legs");

			}*/
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active) return;

			string Ver;
			if (OldMusic)
				Ver = "";
			else
				Ver = "_New";

			string uniVer;
				if (OldMusic || Region == "Sinnoh" || Region == "Unova" || Region == "Kalos" || Region == "Alola" || Region == "Galar")
				uniVer = "";
			else
				uniVer = "_New";

			Player player = Main.LocalPlayer;

			if (TmonPlayer.ZoneGrayGB)
				music = GetSoundSlot(SoundType.Music, $"Sounds/Music/GameBoy/GB_Gray{Ver}");
			else if (TmonPlayer.ZoneRedGB)
				music = GetSoundSlot(SoundType.Music, $"Sounds/Music/GameBoy/GB_Red{Ver}");
			else if (TmonPlayer.ZoneBlueGB)
				music = GetSoundSlot(SoundType.Music, $"Sounds/Music/GameBoy/GB_Blue{Ver}");
			else if (TmonPlayer.ZoneYellowGB)
				music = GetSoundSlot(SoundType.Music, $"Sounds/Music/GameBoy/GB_Yellow{Ver}");
			else if (TmonPlayer.ZoneGreenGB)
				music = GetSoundSlot(SoundType.Music, $"Sounds/Music/GameBoy/GB_Green{Ver}");
			else if (TmonPlayer.ZonePinkGB)
				music = GetSoundSlot(SoundType.Music, $"Sounds/Music/GameBoy/GB_Pink{Ver}");
			else if(TmonPlayer.ZoneDarkGB)
				music = GetSoundSlot(SoundType.Music, $"Sounds/Music/GameBoy/GB_Dark{Ver}");

			var tmonplayer = Main.LocalPlayer.GetModPlayer<Terramon.Players.TerramonPlayer>();

			if (tmonplayer.Battle != null)
			{
				priority = MusicPriority.BossHigh;
				music = GetSoundSlot(SoundType.Music, $"Sounds/Music/Base/{Region}/Wild{uniVer}");
                //return;
            }

            if (player.HasBuff(BuffType("LatiasMount")) && Main.dayTime)
            {
                pokeMini = "Sounds/Music/PokeMini/SoaringDreams";
            }
            else if (player.HasBuff(BuffType("LatiasMount")) && !Main.dayTime)
            {
				pokeMini = "Sounds/Music/PokeMini/SoaringIllusions";
            }
            else if (player.ZoneSnow && !Main.dayTime)
            {
				pokeMini = $"Sounds/Music/PokeMini/{Region}/snowNight";
            }
            else if (player.ZoneBeach && !Main.dayTime)
            {
				pokeMini = $"Sounds/Music/PokeMini/{Region}/beachNight";
            }
        }
	}
}
