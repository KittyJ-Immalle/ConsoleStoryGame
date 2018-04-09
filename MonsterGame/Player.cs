using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Player : Stats
    {
        static Random rnd = new Random();
        public static string Name { get; set; }
        public static int MaxHp { get; set; }
        public static int CurrentHp { get; set; }
        public static int DmgLowest { get; set; }
        public static Room CurrentRoom { get; set; }
        public static int RunAway { get; set; }

        public static int Attack()
        {
            return rnd.Next(DmgLowest, DmgLowest + 10);
        }

        public static void IncreaseStrength(int damage)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("You feel stronger by defeating that monster.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" [+" + damage + " damage]");
            DmgLowest += damage;
        }

        public static void ResetHealth()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" Health regenerated ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+");
            Player.CurrentHp = Player.MaxHp;
        }

        public static void EndLife()
        {
            Dialogue.EndingDialogue();
            Environment.Exit(0);
        }
    }
}
