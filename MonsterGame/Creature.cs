using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Creature
    {
        public static int Hp { get; set; }
        public static int Dmg { get; set; }

        public static void Stats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Monster:\nHp: {0}\nDmg: {1}", Creature.Hp, Creature.Dmg);
            Console.WriteLine(new string('-', 20));
        }
    }
}
