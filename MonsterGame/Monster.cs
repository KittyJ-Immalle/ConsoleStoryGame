using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Monster
    {
        static int Hp { get; set; }
        static int Dmg { get; set; }
        static Random rnd = new Random();
        static bool tick;
        static char letter;
        static string inputString;
        static char inputChar;
        static bool res;

        public enum Type
        {
            Default,
            Monster1,
            Monster2,
            Monster3,
            Monster4,
            Monster5
        };

        public static void Encounter(Type monster = Type.Default)
        {
            if (monster == Type.Default)
            {
                SelectMonster();
            } else
            {
                SelectMonster(monster);
            }
            
            while (Monster.Hp >= 0)
            {

                if (!tick)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("What would you like to do?");
                    letter = GetLetter();
                    Console.WriteLine(letter + ": Attack");
                    Console.WriteLine("z: Run away (" + Player.RunAway + ")");
                    inputString = Console.ReadLine();
                    res = char.TryParse(inputString, out inputChar);
                    if (letter == inputChar)
                    {
                        PlayerAttack();
                    } else if (inputChar == 'z')
                    {
                        if (Player.RunAway > 0)
                        {
                            Console.WriteLine("You ran away.");
                            Player.RunAway--;
                            return;
                        } else
                        {
                            Console.WriteLine("You're too tired to run away.");
                        }
                    } else
                    {
                        Console.WriteLine("You missed.");
                    }
                    
                    
                } else
                {
                    MonsterAttack();
                    Stats();
                }
                tick = !tick;
            }
        }

        private static void SelectMonster(Type monster = Type.Default)
        {
            Type type = (Type)rnd.Next(1, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A monster appeared!");

            if (type == Type.Monster1)
            {
                Console.WriteLine("Monster lvl1");
                SelectLevel(1);
            }
            else if (type == Type.Monster2)
            {
                Console.WriteLine("Monster lvl2");
                SelectLevel(2);
            }
            else if (type == Type.Monster3)
            {
                Console.WriteLine("Monster lvl3");
                SelectLevel(3);
            }
            else if (type == Type.Monster4)
            {
                Console.WriteLine("Monster lvl4");
                SelectLevel(4);
            }
            else if (type == Type.Monster5)
            {
                Console.WriteLine("Monster lvl5 (Watch out! This one's dangerous!)");
                SelectLevel(5);
            }
        }

        private static void SelectLevel(int level)
        {
            switch (level)
            {
                case 1:
                    Monster.Hp = 50;
                    Monster.Dmg = 2;
                    Console.WriteLine("Grr..");
                    break;
                case 2:
                    Monster.Hp = 60;
                    Monster.Dmg = 5;
                    Console.WriteLine("Hgggrr..");
                    break;
                case 3:
                    Monster.Hp = 75;
                    Monster.Dmg = 10;
                    Console.WriteLine("GGruuaagh..");
                    break;
                case 4:
                    Monster.Hp = 100;
                    Monster.Dmg = 15;
                    Console.WriteLine("Mggrruuaaghhr..");
                    break;
                case 5:
                    Monster.Hp = 150;
                    Monster.Dmg = 15;
                    Console.WriteLine("GGRRUAAGHHH..");
                    break;
            }
        }

        private static void PlayerAttack()
        {
            Monster.Hp -= Player.Dmg;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You attacked and did {0} damage!", Player.Dmg);
        }

        private static void MonsterAttack()
        {
            Player.Hp -= Monster.Dmg;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The monster attacked and did {0} damage!", Monster.Dmg);
        }

        private static void Stats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Monster:\nHp: {0}\nDmg: {1}", Monster.Hp, Monster.Dmg);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Player:\nHp: {0}\nDmg: {1}", Player.Hp, Player.Dmg);
            Console.WriteLine(new string('-', 20));
        }

        public static char GetLetter()
        {
            int num = rnd.Next(0, 26);
            char let = (char)('a' + num);
            return let;
        }
    }
}
