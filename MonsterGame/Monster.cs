using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Monster
    {
        static Random rnd = new Random();
        static int hp;
        static int dmg;
        static bool tick;
        static char letter;
        static string inputString;
        static char inputChar;
        static bool res;

        enum Type
        {
            Monster1,
            Monster2,
            Monster3,
            Monster4,
            Monster5
        };

        public static void Encounter()
        {
            Type type = (Type)rnd.Next(1, 5);
            Console.ForegroundColor = ConsoleColor.DarkRed;

            if (type == Type.Monster1)
            {
                Console.WriteLine("Monster lvl1");
                Level1();
            } else if (type == Type.Monster2)
            {
                Console.WriteLine("Monster lvl2");
                Level2();
            }
            else if (type == Type.Monster3)
            {
                Console.WriteLine("Monster lvl3");
                Level3();
            }
            else if (type == Type.Monster4)
            {
                Console.WriteLine("Monster lvl4");
                Level4();
            }
            else if (type == Type.Monster5)
            {
                Console.WriteLine("Monster lvl5 (Watch out! This one's dangerous!)");
                Level5();
            }

            while (hp >= 0)
            {
                

                if (tick)
                {
                    
                    PlayerAttack();
                    
                } else
                {
                    MonsterAttack();
                }
                tick = !tick;
            }
        }

        private static void Level1()
        {
            hp = 50;
            dmg = 2;
            Console.WriteLine("Grr..");
        }

        private static void Level2()
        {
            hp = 60;
            dmg = 5;
            Console.WriteLine("Hgggrr..");
        }

        private static void Level3()
        {
            hp = 75;
            dmg = 10;
            Console.WriteLine("GGruuaagh..");
        }

        private static void Level4()
        {
            hp = 100;
            dmg = 15;
            Console.WriteLine("Mggrruuaaghhr..");
        }

        private static void Level5()
        {
            hp = 150;
            dmg = 15;
            Console.WriteLine("GGRRUAAGHHH..");
        }

        private static void PlayerAttack()
        {
            Console.WriteLine("Monster:\nHp: {0}\nDmg: {1}", hp, dmg);
            Console.WriteLine("Hero:\nHp: {0}\nDmg: {1}", Hero.Hp, Hero.Dmg);

            letter = GetLetter();
            inputString = Console.ReadLine();
            res = char.TryParse(inputString, out inputChar);
            if (letter == inputChar)
            {
                hp -= Hero.Dmg;
                Console.WriteLine("You attacked and did {0}!", Hero.Dmg);
            }
        }

        private static void MonsterAttack()
        {

        }

        public static char GetLetter()
        {
            int num = rnd.Next(0, 26);
            char let = (char)('a' + num);
            return let;
        }
    }
}
