using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Room
    {
        public List<Room> Rooms { get; }  = new List<Room>();

        public string Name { get; }

        public Room(string name)
        {
            Name = name;
        }

        public void Attach(Room room)
        {
            Rooms.Add(room);
            if (!room.IsAttached(this))
            {
                room.Attach(this);
            }
        }

        private bool IsAttached(Room room)
        {
            return Rooms.Contains(room);
        }
    }
}
