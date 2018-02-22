using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Map
    {
        public static void Navigate()
        {
            List<string> availableRooms = SelectRoom();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You are in the " + Player.Room);
            Console.WriteLine("Where do you want to go to?");
            for (int i = 0; i < availableRooms.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + availableRooms[i]);
            }
            Console.ReadLine();
        }

        private static List<string> SelectRoom()
        {
            List<string> hallway = new List<string>(new string[] { "Bedroom", "Bathroom", "Toilet" });
            List<string> bedroom = new List<string>(new string[] { "Hallway", "Closet" });
            List<List<string>> allRooms = new List<List<string>>(new List<string>[] { hallway, bedroom });
            foreach (List<string> room in allRooms)
            {
                if (nameof(room).Equals(Player.Room))
                {
                    return room;
                    
                }
            }
            return allRooms[0];
        }
    }
}
