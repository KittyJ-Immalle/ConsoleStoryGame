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
            Player player = new Player();

            player.Hp = 100;
            player.Dmg = 10;
            player.RunAway = 5;
            player.Room = "Bedroom";
            
            
            Console.WriteLine("Press ENTER to continue dialogue. | Type 'skip' to skip the dialogue.");
            input = Console.ReadLine().ToLower();
            while (true)
            {
                if (input == "")
                {
                    Dialogue.Welcome(player);
                    break;
                }
                else if (input == "skip")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid answer");
                }
            }

        }
    }
}
