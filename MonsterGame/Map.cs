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
            List<string> rooms = new List<string>();
            switch (Player.Room)
            {
                case "hallway":
                    rooms.Add("Bedroom");
                    rooms.Add("Bathroom");
                    rooms.Add("Toilet");
                    break;
                case "bathroom":
                    rooms.Add("Hallway");
                    break;
                case "toilet":
                    rooms.Add("Hallway");
                    break;
                case "bedroom":
                    rooms.Add("Hallway");
                    rooms.Add("Closet");
                    break;
            }
            return rooms;
        }
    }
}
