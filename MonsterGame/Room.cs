using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Room
    {
        List<Room> rooms = new List<Room>();

        public string Name { get; } = Player.Room;

        public void Attach(Room room)
        {
            rooms.Add(room);
            if (!room.IsAttached(this))
            {
                room.Attach(this);
            }
        }

        private bool IsAttached(Room room)
        {
            if (rooms.Contains(room))
            {
                return true;
            }
            return false;
        }
    }
}
