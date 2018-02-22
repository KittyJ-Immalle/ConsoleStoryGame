using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Dialogue
    {
        private static string input;

        public static void Welcome(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello? Are you awake?");
            Enter();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You open your eyes, wondering where you are.\nYou feel yourself lying on a soft surface. It's a bed.");
            Enter();
            Console.WriteLine("When you take another look around you realize you're in some kind of mansion.");
            Enter();
            Console.WriteLine("There's a girl standing in front of you. She looks worried.");
            Enter();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Oh thank god, I thought you died.");
            Enter();
            Console.WriteLine("There's no time to explain, we have to get out of this place.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("a: What happend? | b: Let's get going!");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("What? You mean to tell me you don't remember anything?");
                    Enter();
                    Console.WriteLine("Mh, I suppose that's possible after you passed out.");
                    Enter();
                    Console.WriteLine("We were trying to escape this place but you were attacked by a monster.");
                    Enter();
                    Console.WriteLine("Don't worry, I was able to scare it off.\nWe should go now.");
                    break;
                }
                else if (input != "b")
                {
                    Console.WriteLine("Hm?");
                }
                Map.Navigate(player);
            }
            
        }

        public static void Enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
