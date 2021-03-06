using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;
using Terramon.UI.SidebarParty;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace tmonadds
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("Universal Music Setting")]
        [Tooltip("Choose which region universal tracks come from")]
        [DefaultValue(DefMusic.Unova)]
        // Using StringEnumConverter, Enums are read and written as strings rather than the numerical value of the Enum. This makes the config file more readable, but prone to errors if a player manually modifies the config file.
        [JsonConverter(typeof(StringEnumConverter))]
        public DefMusic musType { get; set; }

        [DefaultValue(false)]
        [Label("Classic Music")]
        [Tooltip("When true, the mod will use music from the original games rather than remakes.")]
        public bool MusicMode;

        public override void OnChanged()
        {
            TAddOns.OldMusic = MusicMode;
            TAddOns.Region = "Hoenn";
        }

        public enum DefMusic
        {
            Kanto,
            Johto,
            Hoenn,
            Sinnoh,
            Unova,
            Kalos,
            Alola,
            Galar
        }
    }
}