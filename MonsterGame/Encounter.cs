using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Encounter
    {
        static Random rnd = new Random();

        static string encounter1 = "You hear something behind the closet. It seems like there's something hidden in the shadows.";
        static string encounter2 = "You notice something in the corner of your eye. Did that chair just move?";
        static string encounter3 = "Weird sounds are coming from the room ahead of you.";

        static string investigate = "Should you go investigate?";
        static bool input;

        enum Choice
        {
            Encounter1,
            Encounter2,
            Encounter3
        };

        static Choice notice = (Choice)rnd.Next(1, 4);

        static void Notice()
        {
            if (notice == Choice.Encounter1)
            {
                Console.WriteLine(encounter1 + "\n" + investigate);
            } else if (notice == Choice.Encounter2)
            {
                Console.WriteLine(encounter2 + "\n" + investigate);
            } else if (notice == Choice.Encounter3)
            {
                Console.WriteLine(encounter3 + "\n" + investigate);
            }
            input = Convert.ToBoolean(Console.ReadLine());
        }

        static void Investigate(Player player)
        {
            string nothing = "You found nothing!";
            int find;
            if (input == true)
            {
                find = rnd.Next(1, 4);
                if (find == 1)
                {
                    Monster.Encounter(player);
                } else if (find == 2)
                {
                    Item.Find();
                } else
                {
                    Console.WriteLine(nothing);
                }
            } else
            {
                Console.WriteLine("You ignored it.");
            }
        }


    }
}
