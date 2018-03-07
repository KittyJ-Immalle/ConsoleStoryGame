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
            

            Player.Hp = 100;
            Player.Dmg = 10;
            Player.RunAway = 5;
            Player.Room = "Bedroom";
            
            
            Console.WriteLine("Press ENTER to continue dialogue. | Type 'skip' to skip the dialogue.");
            input = Console.ReadLine().ToLower();
            while (true)
            {
                if (input == "")
                {
                    Dialogue.Welcome();
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
            while (true)
            {
                Map.Navigate();
            }
            
        }
    }
}
