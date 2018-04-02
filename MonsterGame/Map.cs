using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Map
    {
        private static List<Room> attachedRooms;
        public static Room Bedroom = new Room("Bedroom");
        private static Room hallway = new Room("Hallway");
        private static Room bathroom = new Room("Bathroom");
        private static Room toilet = new Room("Toilet");
        private static Room closet = new Room("Closet");

        public static void MapInit()
        {
            hallway.Attach(Bedroom);
            hallway.Attach(bathroom);
            hallway.Attach(toilet);
            Bedroom.Attach(closet);
        }

        public static void Navigate()
        {
            attachedRooms = SelectRooms();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You are in the " + Player.CurrentRoom.Name);
            Console.WriteLine("Where do you want to go to? (Choose a number)");

            for (int i = 0; i < attachedRooms.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + attachedRooms[i].Name);
            }

            MoveRoom();            
        }

        private static List<Room> SelectRooms()
        {
            Room playerRoom = Player.CurrentRoom;

            return playerRoom.Rooms;
        }

        private static void MoveRoom()
        {
            bool success;
            int result;

            success = int.TryParse(Console.ReadLine(), out result);

            for (int i = 0; i < attachedRooms.Count; i++)
            {
                if (result == (i + 1))
                {
                    Player.CurrentRoom = attachedRooms[i];
                    
                }
            }

            if (success == false)
            {
                Console.WriteLine("No such room.");
                MoveRoom();
            }
        }
    }
}
