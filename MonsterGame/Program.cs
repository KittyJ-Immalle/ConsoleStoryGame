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

            Player.MaxHp = 100;
            Player.CurrentHp = Player.MaxHp;
            Player.DmgLowest = 5;
            Player.RunAway = 5;
            Player.CurrentRoom = Map.Bedroom;

            Dialogue.BeforeStart();
            Dialogue.ChooseName();

            Map.MapInit();

            Console.WriteLine("Press ENTER to continue dialogue. | Type 'skip' to skip the dialogue.");
            while (true)
            {
                input = Console.ReadLine().ToLower();
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
                new Monster().Appear();
            }
            
        }
    }
}
