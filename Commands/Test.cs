using Terraria;
using Terraria.ModLoader;

namespace tmonadds.Commands
{
    class Test : ModCommand
    {
        public override CommandType Type
        {
            get { return CommandType.Chat; }
        }

        public override string Command
        {
            get { return "disable"; }
        }

        public override string Description
        {
            get { return "Test command."; }
        }

        public override string Usage
        {
            get { return "/disable"; }
        }

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            
                if (args.Length == 0)
                {
                TmonPlayer TmonPlayer = Main.LocalPlayer.GetModPlayer<TmonPlayer>();
                TmonPlayer.Pikachu = false;
                return;
                }
                else
            {
                TmonPlayer TmonPlayer = Main.LocalPlayer.GetModPlayer<TmonPlayer>();
                TmonPlayer.Pikachu = true;
                return;
            }
        }
    }
}
