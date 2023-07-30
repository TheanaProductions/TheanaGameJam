using System;
using System.Text.Json;

namespace TheanaGameJam
{
    internal class Program
    {
        private static readonly string THEMES_PATH = "JamThemes.json";

        private static string _title = @"

_________          _______  _______  _        _______    _______  _______  _______  _______   _________ _______  _______ 
\__   __/|\     /|(  ____ \(  ___  )( (    /|(  ___  )  (  ____ \(  ___  )(       )(  ____ \  \__    _/(  ___  )(       )
   ) (   | )   ( || (    \/| (   ) ||  \  ( || (   ) |  | (    \/| (   ) || () () || (    \/     )  (  | (   ) || () () |
   | |   | (___) || (__    | (___) ||   \ | || (___) |  | |      | (___) || || || || (__         |  |  | (___) || || || |
   | |   |  ___  ||  __)   |  ___  || (\ \) ||  ___  |  | | ____ |  ___  || |(_)| ||  __)        |  |  |  ___  || |(_)| |
   | |   | (   ) || (      | (   ) || | \   || (   ) |  | | \_  )| (   ) || |   | || (           |  |  | (   ) || |   | |
   | |   | )   ( || (____/\| )   ( || )  \  || )   ( |  | (___) || )   ( || )   ( || (____/\  |\_)  )  | )   ( || )   ( |
   )_(   |/     \|(_______/|/     \||/    )_)|/     \|  (_______)|/     \||/     \|(_______/  (____/   |/     \||/     \|
                                                                                                                         
";

        private static List<string> _themes = new List<string>()
        {
            "Connect",
            "Time",
            "Switch",
            "Alone",
            "Reflection",
            "Lost",
            "Transform",
            "Minimal",
            "Growth",
            "Repair",
            "Balance",
            "Hidden",
            "Gravity",
            "Fragile",
            "Loop",
            "Upgrade",
            "Discovery",
            "Sacrifice",
            "Frantic",
            "Chaos",
            "Break",
            "Oddity",
            "Construct",
            "Unstable",
            "Multiverse",
            "Parallel",
            "Rewind",
            "Merge",
            "Duality",
            "Momentum",
            "Tension",
            "Rewire",
            "Obstacle",
            "Momentum",
            "Growth",
            "Serenity",
            "Resonate",
            "Illuminate",
            "Shift",
            "Abandoned",
            "Embrace",
            "Converge",
            "Distortion",
            "Mirage",
            "Catalyst",
            "Pulse",
            "Resilient",
            "Sync",
            "Ascend",
            "Harmony"
        };

        private static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.Write(_title);

            while (true)
            {
                Console.WriteLine("\n \n Press a key to select a theme...");

                Console.ReadKey();

                GetRandomTheme();
            }
        }

        private static void GetRandomTheme()
        {
            int index = rand.Next(0, _themes.Count);
            string randomString = _themes[index];

            Console.WriteLine(randomString);
        }
    }
}