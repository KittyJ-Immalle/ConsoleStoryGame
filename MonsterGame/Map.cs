using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Map
    {
        private static List<string> availableRooms;
        public List<string> Hallway {
            get {
                availableRooms.Add("Bedroom");
                availableRooms.Add("Bathroom");
                availableRooms.Add("Toilet");
                return availableRooms;
            }
        }
        public static void Navigate(Player player)
        {
            Console.WriteLine("Right now, you are in the " + player.Room);
            for (int i = 0; i < availableRooms.Count; i++)
            {
                Console.WriteLine((i + 1) + availableRooms[i]);
            }
        }
    }
}
