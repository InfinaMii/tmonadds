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

namespace YoshisIslandMod
{
    public class TmonPlayer : ModPlayer
    {
        int count    =  1;
        int previous = -1;
        public bool nullified       = false;
        public bool examplePet      = false;
        public bool exampleLightPet = false;

        //Yoshi 

        public bool Yoshi = false;  // Each Yoshi gets this check, since they're Yoshi.
        //public bool YoshiMount = false;        
        public bool YoshiGreen      = false;    
        public bool YoshiPink       = false;
        public bool YoshiLightBlue  = false;
        public bool YoshiYellow     = false;
        public bool YoshiPurple     = false;
        public bool YoshiLightBrown = false;    
        public bool YoshiOrange   = false;   
        public bool YoshiRed        = false;
        public bool YoshiBlue       = false;   
        public bool YoshiDarkBlue = false;   
        public bool YoshiGray       = false;    
        public bool YoshiBlack      = false;
		
        public bool Booshi          = false;
        public bool TJYoshi         = false;		
        public bool YoshiDry        = false;

        //Mario
		
		public bool Mario = false;
		public bool MarioRed = false;
		public bool GrandDad = false;
		public bool PaperMario = false;
		//public bool MarioSunshine = false;
		
		// Luigi
		
		public bool Luigi = false;
		public bool LuigiGreen = false;
		public bool GooigiGreen = false;
		//public bool GooigiPink = false;
		//public bool GooigiLightBlue = false;
		//public bool GooigiYellow = false;
		//public bool GooigiPurple = false;
		//public bool GooigiLightBrown= false;
		//public bool GooigiOrange = false;
		//public bool GooigiRed = false;
		//public bool GooigiBlue = false;
		//public bool GooigiDarkBlue = false;
		//public bool GooigiGray = false;
		//public bool GooigiBlack = false;
		
		//Princess Daisy
		
		public bool Daisy = false;
		public bool DaisyYellow = false;
		
		//Princess Peach
		
		public bool Peach = false;
		public bool PeachPink = false;
		
		//Princess Bowsette
		
		public bool Bowsette = false;

        //Toad
		
		public bool Toad = false;
		public bool ToadDefault    = false;
		public bool ToadRed        = false;
		public bool ToadPink       = false;
		public bool ToadBlue       = false; 
		public bool ToadGray       = false;
		public bool ToadBrown       = false;
		public bool ToadGreen      = false;
		public bool ToadBlack      = false;
        public bool ToadYellow     = false;
        public bool ToadPurple     = false;
        public bool ToadOrange     = false;    
        public bool ToadDarkBlue   = false;   		
        public bool ToadLightBlue  = false;
        public bool ToadLightBrown = false;        
           
        //Waluigi
		
		public bool Waluigi = false;
		public bool WaluigiPurple = false;
		
		//Wario
		
		public bool Wario = false;
		public bool WarioYellow = false;
		
		//Enemies
		
		public bool Pikachu = false;
		public bool PikachuDefault = false;
		
		//Memes 
		
		public bool DiagonalMario = false;
		
		public bool DiagonalLuigi = false;
		
		public bool DiagonalWario   = false;

		public bool DiagonalWaluigi = false;
		
		///----------------ACTIVES----------------///
		
		//--Yoshi--//
		
		bool YoshiActive = false;
		
		//--Mario--//
		bool MarioActive = false;
		
		//--Luigi--//
		bool LuigiActive = false;
		
		//--Waluigi--//
		bool WaluigiActive = false;
		
		//--Wario--//
		bool WarioActive = false;
		
		//--Peach--//
		bool PeachActive = false;
		
		//--Toad--//
		bool ToadActive = false;
		
		//--Bowsette--//
		bool BowsetteActive = false;
		
		//--Memes--//
		
		bool DiagonalMarioActive = false;
		
		bool DiagonalLuigiActive = false;
		
		bool DiagonalWarioActive   = false;
		
		bool DiagonalWaluigiActive = false;
		  
        public override void ResetEffects()
        {
            examplePet = false;
            exampleLightPet = false;

        //Yoshi's

        Yoshi           = false;
        YoshiGreen      = false; // Just like above, in ResetEffects to reset their effects upon unequipping I'm betting.
        YoshiPink       = false; 
        YoshiLightBlue  = false;
        YoshiYellow     = false;
        YoshiPurple     = false;
        YoshiLightBrown = false;
        YoshiOrange     = false;
        YoshiRed        = false;
        YoshiBlue       = false;
        YoshiDarkBlue   = false;
        YoshiGray       = false;
        YoshiBlack      = false;
		
		TJYoshi         = false;
        Booshi          = false;
        YoshiDry        = false;

        //Mario
		Mario = false;
		MarioRed = false;
		GrandDad = false;
		PaperMario = false;
		//public bool MarioSunshine = false;
		
		// Luigi
		
		Luigi = false;
        LuigiGreen = false;
		GooigiGreen = false;
		//GooigiPink = false;
		//GooigiLightBlue = false;
		//GooigiYellow = false;
		//GooigiPurple = false;
		//GooigiLightBrown= false;
		//GooigiOrange = false;
		//GooigiRed = false;
		//GooigiBlue = false;
		//GooigiDarkBlue = false;
		//GooigiGray = false;
		//GooigiBlack = false;
		
		// Daisy
		Daisy = false;
		DaisyYellow = false;
		
		// Peach 
		Peach = false;
		PeachPink = false;
		
		// Bowsette 
		Bowsette = false;

        //Toad
			
		Toad = false;
		ToadDefault    = false;
		ToadRed        = false;
		ToadPink       = false;
		ToadBlue       = false;
        ToadGray       = false;
        ToadBrown      = false; 		
		ToadGreen      = false;
        ToadBlack      = false;		
		ToadYellow     = false;
		ToadPurple     = false;
		ToadOrange     = false;
		ToadDarkBlue   = false;
        ToadLightBlue  = false;        
        ToadLightBrown = false;    

        //Waluigi

        Waluigi = false;
		WaluigiPurple = false;	
		
		//Wario

        Wario = false;
		WarioYellow = false;	
		
		//Enemies 
		
		Pikachu = false;
		PikachuDefault = false;
		
		//Meme Costumes
		
		DiagonalMario = false;
		
		DiagonalLuigi = false;
		
		DiagonalWario   = false;
		
		DiagonalWaluigi = false;
		
        }
        public override void FrameEffects() // As above, same order, happy coding. One of the files needed to get the costume going.
        {
            if (YoshiGreen == true)
            {
                player.legs = mod.GetEquipSlot("GreenYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("GreenYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("GreenYoshiHead", EquipType.Head);
            }

            if (YoshiPink == true)
            {
                player.legs = mod.GetEquipSlot("PinkYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("PinkYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("PinkYoshiHead", EquipType.Head);
            }

            if (YoshiLightBlue == true)
            {
                player.legs = mod.GetEquipSlot("LightBlueYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("LightBlueYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("LightBlueYoshiHead", EquipType.Head);
            }

            if (YoshiYellow == true)
            {
                player.legs = mod.GetEquipSlot("YellowYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("YellowYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("YellowYoshiHead", EquipType.Head);
            }

            if (YoshiPurple == true)
            {
                player.legs = mod.GetEquipSlot("PurpleYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("PurpleYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("PurpleYoshiHead", EquipType.Head);
            }

            if (YoshiLightBrown == true)
            {
                player.legs = mod.GetEquipSlot("LightBrownYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("LightBrownYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("LightBrownYoshiHead", EquipType.Head);
            }

            if (YoshiOrange == true)
            {
                player.legs = mod.GetEquipSlot("OrangeYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("OrangeYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("OrangeYoshiHead", EquipType.Head);
            }

            if (YoshiRed == true)
            {
                player.legs = mod.GetEquipSlot("RedYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("RedYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("RedYoshiHead", EquipType.Head);
            }

            if (YoshiBlue == true)
            {
                player.legs = mod.GetEquipSlot("BlueYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("BlueYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("BlueYoshiHead", EquipType.Head);
            }

            if (YoshiDarkBlue == true)
            {
                player.legs = mod.GetEquipSlot("DarkBlueYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("DarkBlueYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("DarkBlueYoshiHead", EquipType.Head);
            }

            if (YoshiBlack == true)
            {
                player.legs = mod.GetEquipSlot("BlackYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("BlackYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("BlackYoshiHead", EquipType.Head);
            }
			
			if (TJYoshi == true)
            {
                player.legs = mod.GetEquipSlot("TJYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("TJYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("TJYoshiHead", EquipType.Head);
            }

            if (YoshiGray == true)
            {
                player.legs = mod.GetEquipSlot("GrayYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("GrayYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("GrayYoshiHead", EquipType.Head);
            }

            if (Booshi == true)
            {
                player.legs = mod.GetEquipSlot("BooshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("BooshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("BooshiHead", EquipType.Head);
            }

            if (YoshiDry == true)
            {
                player.legs = mod.GetEquipSlot("DryYoshiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("DryYoshiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("DryYoshiHead", EquipType.Head);
            }
			
			//Mario Costumes
			
			if (MarioRed == true)
            {
                player.legs = mod.GetEquipSlot("MarioLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("MarioBody", EquipType.Body);
                player.head = mod.GetEquipSlot("MarioHead", EquipType.Head);
            }
			
			if (PaperMario == true)
            {
                player.legs = mod.GetEquipSlot("PaperMarioLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("PaperMarioBody", EquipType.Body);
                player.head = mod.GetEquipSlot("PaperMarioHead", EquipType.Head);
            }
			
			if (DiagonalMario == true)
            {
                player.legs = mod.GetEquipSlot("DiagonalMarioLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("DiagonalMarioBody", EquipType.Body);
                player.head = mod.GetEquipSlot("DiagonalMarioHead", EquipType.Head);
            }
			
            if (GrandDad == true)
            {
                player.legs = mod.GetEquipSlot("GrandDadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("GrandDadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("GrandDadHead", EquipType.Head);
            }
			
			//Luigi Costumes		
			
			if (LuigiGreen == true)
            {
                player.legs = mod.GetEquipSlot("LuigiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("LuigiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("LuigiHead", EquipType.Head);
            }

            if (GooigiGreen == true)
            {
                player.legs = mod.GetEquipSlot("GooigiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("GooigiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("GooigiHead", EquipType.Head);
            }
			
			if (DiagonalLuigi == true)
            {
                player.legs = mod.GetEquipSlot("DiagonalLuigiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("DiagonalLuigiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("DiagonalLuigiHead", EquipType.Head);
            }
			
			//Princess Daisy Costumes		
			
			if (DaisyYellow == true)
            {
                player.legs = mod.GetEquipSlot("DaisyLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("DaisyBody", EquipType.Body);
                player.head = mod.GetEquipSlot("DaisyHead", EquipType.Head);
            }
			
			//Princess Peach Costumes		
			
			if (PeachPink == true)
            {
                player.legs = mod.GetEquipSlot("PeachLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("PeachBody", EquipType.Body);
                player.head = mod.GetEquipSlot("PeachHead", EquipType.Head);
            }
			
			//Princess Bowsette Costumes		
			
			if (Bowsette == true)
            {
                player.legs = mod.GetEquipSlot("BowsetteLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("BowsetteBody", EquipType.Body);
                player.head = mod.GetEquipSlot("BowsetteHead", EquipType.Head);
            }
			
			//Waluigi Costumes
			
			if (WaluigiPurple == true)
            {
                player.legs = mod.GetEquipSlot("WaluigiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("WaluigiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("WaluigiHead", EquipType.Head);
            }
			
			if (DiagonalWaluigi == true)
            {
                player.legs = mod.GetEquipSlot("DiagonalWaluigiLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("DiagonalWaluigiBody", EquipType.Body);
                player.head = mod.GetEquipSlot("DiagonalWaluigiHead", EquipType.Head);
            }
			
			//Wario Costumes
			
			if (WarioYellow == true)
            {
                player.legs = mod.GetEquipSlot("WarioLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("WarioBody", EquipType.Body);
                player.head = mod.GetEquipSlot("WarioHead", EquipType.Head);
            }
			
			if (DiagonalWario == true)
            {
                player.legs = mod.GetEquipSlot("DiagonalWarioLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("DiagonalWarioBody", EquipType.Body);
                player.head = mod.GetEquipSlot("DiagonalWarioHead", EquipType.Head);
            }
			
			//Toad Costumes
			
			if (ToadDefault == true)
            {
                player.legs = mod.GetEquipSlot("ToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("ToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("ToadHead", EquipType.Head);
            }
			
			//Pikachu Costumes
			
			if (PikachuDefault == true)
            {
                player.legs = mod.GetEquipSlot("PikachuLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("PikachuBody", EquipType.Body);
                player.head = mod.GetEquipSlot("PikachuHead", EquipType.Head);
            }

			if (ToadGreen == true)
            {
                player.legs = mod.GetEquipSlot("GreenToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("GreenToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("GreenToadHead", EquipType.Head);
            }
			
			if (ToadBrown == true)
            {
                player.legs = mod.GetEquipSlot("BrownToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("BrownToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("BrownToadHead", EquipType.Head);
            }

            if (ToadPink == true)
            {
                player.legs = mod.GetEquipSlot("PinkToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("PinkToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("PinkToadHead", EquipType.Head);
            }

            if (ToadLightBlue == true)
            {
                player.legs = mod.GetEquipSlot("LightBlueToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("LightBlueToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("LightBlueToadHead", EquipType.Head);
            }

            if (ToadYellow == true)
            {
                player.legs = mod.GetEquipSlot("YellowToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("YellowToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("YellowToadHead", EquipType.Head);
			}
			
            if (ToadPurple == true)
            {
                player.legs = mod.GetEquipSlot("PurpleToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("PurpleToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("PurpleToadHead", EquipType.Head);
            }

            if (ToadLightBrown == true)
            {
                player.legs = mod.GetEquipSlot("LightBrownToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("LightBrownToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("LightBrownToadHead", EquipType.Head);
            }

            if (ToadOrange == true)
            {
                player.legs = mod.GetEquipSlot("OrangeToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("OrangeToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("OrangeToadHead", EquipType.Head);
            }

            if (ToadRed == true)
            {
                player.legs = mod.GetEquipSlot("RedToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("RedToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("RedToadHead", EquipType.Head);
            }

            if (ToadBlue == true)
            {
                player.legs = mod.GetEquipSlot("BlueToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("BlueToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("BlueToadHead", EquipType.Head);
            }

            if (ToadDarkBlue == true)
            {
                player.legs = mod.GetEquipSlot("DarkBlueToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("DarkBlueToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("DarkBlueToadHead", EquipType.Head);
            }

            if (ToadBlack == true)
            {
                player.legs = mod.GetEquipSlot("BlackToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("BlackToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("BlackToadHead", EquipType.Head);
            }

            if (ToadGray == true)
            {
                player.legs = mod.GetEquipSlot("GrayToadLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("GrayToadBody", EquipType.Body);
                player.head = mod.GetEquipSlot("GrayToadHead", EquipType.Head);
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
			if (Mario)
            {
				player.lifeRegen += 2;
				player.moveSpeed += 0.1f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 1.0f;
                player.autoJump = true;				
            }
			
			if (Luigi)
            {
				player.lifeRegen += 2;
                player.moveSpeed += 0.4f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 3.0f;
				player.autoJump = true;
                player.waterWalk = true;			
            }
			
			if (Wario)
            {
				player.dash = 2;
				player.lifeRegen += 2;
				player.moveSpeed += 0.1f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 1.0f;

                player.coins = true;
				player.kbGlove = true;
                player.autoJump = true;
                player.doubleJumpFart = true;				
            }
			
			if (Waluigi)
            {
				player.lifeRegen += 2;
                player.moveSpeed += 0.1f;
                player.meleeDamage += 0.2f;			
			    player.jumpSpeedBoost += 2.40f;		
				player.autoJump = true;
				player.buffImmune[BuffID.Poisoned] = true;
				player.buffImmune[BuffID.Sunflower] = true;                  
            }
			
			if (Toad)
            {
				player.lifeRegen += 2;
				player.moveSpeed += 0.1f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 1.0f;
				player.autoJump = true;
                player.buffImmune[BuffID.Venom] = true;
			    player.buffImmune[BuffID.Poisoned] = true;				
            }
			
			
			//Princesses 
			
			if (Peach)
            {							
			    player.maxMinions = 2;
				player.moveSpeed += 0.1f;
			    player.minionDamage += 0.15f; //increases minion damage by 15%
			    player.jumpSpeedBoost += 1.0f;				
			    player.carpet = true;
			    player.slowFall = true;
			    player.autoJump = true;
			    player.noFallDmg = true;				
            }
			
			if (Daisy)
            {
				player.lifeRegen += 2;
				player.moveSpeed += 0.1f;
			    player.meleeDamage += 0.5f;			
			    player.jumpSpeedBoost += 1.0f;							 
			    player.slowFall = true;
			    player.autoJump = true;
			    player.noFallDmg = true;
                player.onHitPetal = true;				
            }
			
			if (Bowsette)
            {
				player.lifeRegen += 2;
				player.moveSpeed += 0.2f;
			    player.meleeDamage += 0.5f;
                player.jumpSpeedBoost += 1.0f;	
			
			    player.slowFall = true;
			    player.autoJump = true;
			    player.noFallDmg = true;
			
			    player.buffImmune[BuffID.OnFire] = true;
			    player.buffImmune[BuffID.Frozen] = true;
			    player.buffImmune[BuffID.Chilled] = true;
			    player.buffImmune[BuffID.Burning] = true;
			    player.buffImmune[BuffID.Frostburn] = true;
			    player.buffImmune[BuffID.CursedInferno] = true;                 
            }
			//Special Playable Character Buffs
			
			if (PaperMario)
            {
				player.lifeRegen += 2;
				player.moveSpeed += 0.1f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 1.0f;
                player.autoJump = true;				
            }
			
			//Enemy Playable Character Buffs 
			
			if (Pikachu)
            {
				player.lifeRegen += 2;
				player.autoJump = true;
				player.noFallDmg = true;
				player.buffImmune[BuffID.Venom] = true;
			    player.buffImmune[BuffID.Poisoned] = true;			    			
            }
			
			//Other Playable Character Buffs
			
			if (GrandDad)
            {
				player.lifeRegen += 2;
				player.moveSpeed += 0.1f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 1.0f;
                player.autoJump = true;				
            }
			         			
			if (DiagonalMario)
            {
				player.lifeRegen += 2;
				player.moveSpeed += 0.1f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 1.0f;
                player.autoJump = true;				
            }
			
			if (DiagonalLuigi)
            {
				player.lifeRegen += 2;
                player.moveSpeed += 0.4f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 3.0f;
				player.autoJump = true;
                player.waterWalk = true;			
            }
			
			if (DiagonalWario)
            {
				player.dash = 2;
				player.lifeRegen += 2;
				player.moveSpeed += 0.1f;
			    player.meleeDamage += 0.1f;
			    player.jumpSpeedBoost += 1.0f;

                player.coins = true;
				player.kbGlove = true;
                player.autoJump = true;
                player.doubleJumpFart = true;				
            }
			
			if (DiagonalWaluigi)
            {
				player.lifeRegen += 2;
                player.moveSpeed += 0.1f;
                player.meleeDamage += 0.1f;			
			    player.jumpSpeedBoost += 2.40f;		
				player.autoJump = true;
				player.buffImmune[BuffID.Poisoned] = true;
				player.buffImmune[BuffID.Sunflower] = true;
				
               if (NPC.downedMoonlord)
               {
					player.statLifeMax2 += 1000;
               }					
            }
		}

		public override void PostUpdate()
		{
			if (Mario)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (Mario == true && MarioActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/MarioSound"));
                MarioActive = true;
            }
			
			if (Mario == false)
            {
                MarioActive = false;
            }
			
			if (Luigi)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (Luigi == true && LuigiActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/LuigiSound"));
                LuigiActive = true;
            }
			
			if (Luigi == false)
            {
                LuigiActive = false;
            }
			
			if (Waluigi)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (Waluigi == true && WaluigiActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/WaluigiSound"));
                WaluigiActive = true;
            }
			
			if (Waluigi == false)
            {
                WaluigiActive = false;
            }
			
			if (Wario)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (Wario == true && WarioActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/WarioSound"));
                WarioActive = true;
            }
			
			if (Wario == false)
            {
                WarioActive = false;
            }
			
			if (Yoshi)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/YoshiJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}
			
			if (Yoshi == true && YoshiActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/YoshiSound"));
                YoshiActive = true;
            }
			
			if (Yoshi == false)
            {
                YoshiActive = false;
            }
			
			if (Peach)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (Peach == true && PeachActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/PeachSound"));
                PeachActive = true;
            }
			
			if (Peach == false)
            {
                PeachActive = false;
            }
			
			if (Bowsette)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (Bowsette == true && BowsetteActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/BowsetteSound"));
                BowsetteActive = true;
            }
			
			if (Bowsette == false)
            {
                BowsetteActive = false;
            }
			
			if (Toad)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}
			
			if (Toad == true && ToadActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/ToadSound"));
                ToadActive = true;
            }
			
			if (Toad == false)
            {
                ToadActive = false;
            }
			
			if (DiagonalMario)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (DiagonalMario == true && DiagonalMarioActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/MarioSound"));
                DiagonalMarioActive = true;
            }
			
			if (DiagonalMario == false)
            {
                DiagonalMarioActive = false;
            }
			
			if (DiagonalLuigi)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (DiagonalLuigi == true && DiagonalLuigiActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/LuigiSound"));
                DiagonalLuigiActive = true;
            }
			
			if (DiagonalLuigi == false)
            {
                DiagonalLuigiActive = false;
            }
			
			if (DiagonalWario)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (DiagonalWario == true && DiagonalWarioActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/WarioSound"));
                DiagonalWarioActive = true;
            }
			
			if (DiagonalWario == false)
            {
                DiagonalWarioActive = false;
            }
			
			if (DiagonalWaluigi)
			{
				if (player.controlJump && player.justJumped)
				{
					if (player.wet == false)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWJump"));
					}
					
					if (player.wet == true)
					{
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWSwim"));
					}
				}
			}	
			
			if (DiagonalWaluigi == true && DiagonalWaluigiActive == false)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/WaluigiSound"));
                DiagonalWaluigiActive = true;
            }
			
			if (DiagonalWaluigi == false)
            {
                DiagonalWaluigiActive = false;
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

                    if(count == 50)
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

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            if (Mario)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/MarioDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (Luigi)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/LuigiDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (Yoshi)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/YoshiDown"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/PlayerDeath"));
            }
			
			if (Waluigi)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/WaluigiDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (Wario)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/WarioDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (Peach)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/PeachDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (Toad)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/ToadDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (Bowsette)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/PeachDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (DiagonalMario)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/MarioDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (DiagonalLuigi)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/LuigiDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (DiagonalWario)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/WarioDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
			
			if (DiagonalWaluigi)
            {
				Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/WaluigiDeath"));
                Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/CharacterSounds/SMWDeath"));
            }
        }

        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (Yoshi)
            {
                playSound = false;
                genGore = false;
            }
			
			if (Mario)
            {
                playSound = false;
                genGore = false;
            }
			
			if (Luigi)
            {
                playSound = false;
                genGore = false;
            }
			
			if (Waluigi)
            {
                playSound = false;
                genGore = false;
            }
			
			if (Wario)
            {
                playSound = false;
                genGore = false;
            }
			
			if (Peach)
            {
                playSound = false;
                genGore = false;
            }
			
			if (Bowsette)
            {
                playSound = false;
                genGore = false;
            }
			
			if (Toad)
            {
                playSound = false;
                genGore = false;
            }
			
			if (DiagonalMario)
            {
                playSound = false;
                genGore = false;
            }
			
			if (DiagonalLuigi)
            {
                playSound = false;
                genGore = false;
            }
			
			if (DiagonalWario)
            {
                playSound = false;
                genGore = false;
            }
			
			if (DiagonalWaluigi)
            {
                playSound = false;
                genGore = false;
            }
            return true;
        }
		
		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath) 
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("Yoshi"));
            item.stack = 1;
            items.Add(item);
			
			item = new Item();
            item.SetDefaults(mod.ItemType("YoshiEgg"));
            item.stack = 60;
            items.Add(item);
			
			item = new Item();
            item.SetDefaults(mod.ItemType("GoldenCoin"));
            item.stack = 30;
            items.Add(item);
			
			item = new Item();
            item.SetDefaults(mod.ItemType("HintBlock"));
            item.stack = 1;
            items.Add(item);
			
			item = new Item();
            item.SetDefaults(mod.ItemType("OmoChaoItem"));
            item.stack = 1;
            items.Add(item);
        }
    }
}