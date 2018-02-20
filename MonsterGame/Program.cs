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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello? Are you awake?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You open your eyes, wondering where you are.\nThere's a girl standing in front of you. She looks worried.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Oh thank god, I thought you died.\nThere's no time to explain, we have to get out of this place.");
            Hero.Hp = 100;
            Hero.Dmg = 10;
            Monster.Encounter();
        }
    }
}
