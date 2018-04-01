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
        public static Room Bedroom { get; } = new Room("Bedroom");
        private static Room hallway = new Room("Hallway");
        private static Room bathroom = new Room("Bathroom");
        private static Room toilet = new Room("Toilet");
        private static Room closet = new Room("Closet");

        public static void Navigate()
        {
            attachedRooms = SelectRooms();
            //bool moved = false;

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

            hallway.Attach(Bedroom);
            hallway.Attach(bathroom);
            hallway.Attach(toilet);
            bathroom.Attach(hallway);
            toilet.Attach(hallway);
            Bedroom.Attach(hallway);
            Bedroom.Attach(closet);
            closet.Attach(Bedroom);

            //List<string> rooms = new List<string>();

            //switch (Player.Room)
            //{
            //    case "Hallway":
            //        rooms.Add("Bedroom");
            //        rooms.Add("Bathroom");
            //        rooms.Add("Toilet");
            //        break;
            //    case "Bathroom":
            //        rooms.Add("Hallway");
            //        break;
            //    case "Toilet":
            //        rooms.Add("Hallway");
            //        break;
            //    case "Bedroom":
            //        rooms.Add("Hallway");
            //        rooms.Add("Closet");
            //        break;
            //    case "Closet":
            //        rooms.Add("Bedroom");
            //        break;
            //}

            return playerRoom.Rooms;
        }

        private static void MoveRoom()
        {
            bool input;
            int result;
            //bool moved = false;

            input = int.TryParse(Console.ReadLine(), out result);

            foreach (Room room in attachedRooms)
            {
                Player.CurrentRoom = room;
            }
            //for (int i = 0; i < attachedRooms.Count; i++)
            //{
            //    if (result == (i + 1))
            //    {
            //        Player.Room = attachedRooms[i];
            //        //moved = true;
            //    }
            //}
            
            if (input == false)
            {
                Console.WriteLine("No such room.");
                MoveRoom();
            }
            //return input;
        }
    }
}
