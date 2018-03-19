using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Stats
    {
        
        public static void StatsMonster()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(Monster.Name + ":\nHp: {0}\nDmg: {1}", Monster.Hp, Monster.DmgLowest + " - " + Monster.DmgLowest + 10);
            Console.WriteLine(new string('-', 20));
        }
        public static void StatsPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(Player.Name + ":\nHp: {0}\nDmg: {1}", Player.Hp, Player.DmgLowest + " - " + Player.DmgLowest + 10);
            Console.WriteLine(new string('-', 20));
        }
        
    }
}
