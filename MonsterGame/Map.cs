using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Map
    {
        static List<string> availableRooms;

        public static void Navigate()
        {
            availableRooms = SelectRoom();
            bool moved = false;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You are in the " + Player.Room);
            Console.WriteLine("Where do you want to go to?");

            for (int i = 0; i < availableRooms.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + availableRooms[i]);
            }

            if (moved == false)
            {
                moved = MoveRoom();
            }
            Console.WriteLine("Moved rooms");
        }

        private static List<string> SelectRoom()
        {
            List<string> rooms = new List<string>();
            switch (Player.Room)
            {
                case "Hallway":
                    rooms.Add("Bedroom");
                    rooms.Add("Bathroom");
                    rooms.Add("Toilet");
                    break;
                case "Bathroom":
                    rooms.Add("Hallway");
                    break;
                case "Toilet":
                    rooms.Add("Hallway");
                    break;
                case "Bedroom":
                    rooms.Add("Hallway");
                    rooms.Add("Closet");
                    break;
                case "Closet":
                    rooms.Add("Bedroom");
                    break;
            }
            return rooms;
        }

        private static bool MoveRoom()
        {
            int input;
            bool moved = false;

            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < availableRooms.Count; i++)
            {
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
