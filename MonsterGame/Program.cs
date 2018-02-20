using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Hero.Hp = 100;
            Hero.Dmg = 10;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello? Are you awake?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You open your eyes, wondering where you are.\nIt seems to be some kind of mansion.\nThere's a girl standing in front of you. She looks worried.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Oh thank god, I thought you died.\nThere's no time to explain, we have to get out of this place.");
            Console.WriteLine("a: What happend? | b: Let's get going");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.WriteLine("What? You mean to tell me you don't remember anything?\nMh, I suppose that's possible after you passed out. We were trying to escape this place but you were attacked by a monster. Don't worry, I was able to scare it off.\n We should go now.");
            }
            Monster.Encounter();
        }
    }
}
