using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Map
    {
        static List<string> availableRooms = SelectRoom();

        public static void Navigate()
        {
            bool moved;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You are in the " + Player.Room);
            Console.WriteLine("Where do you want to go to?");

            for (int i = 0; i < availableRooms.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + availableRooms[i]);
            }

            //moved = MoveRoom();
            
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

        private static bool MoveRoom()
        {
            int input;
            bool moved = false;

            for (int i = 0; i < availableRooms.Count; i++)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input == (i + 1))
                {
                    Player.Room = availableRooms[i];
                    moved = true;
                }
            }
            return moved;
        }
    }
}
