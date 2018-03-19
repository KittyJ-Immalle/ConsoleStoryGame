using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Monster : Stats
    {
        static Random rnd = new Random();
        static bool tick;
        static char letter;
        static string inputString;
        static char inputChar;
        static bool res;

        public static string Name { get; set; }
        public static int Hp { get; set; }
        public static int DmgLowest { get; set; }

        public enum Type
        {
            Default,
            Monster1,
            Monster2,
            Monster3,
            Monster4,
            Monster5
        };

        public static bool Appear()
        {
            Random rnd = new Random();
            if (rnd.Next(1, 4) == 1)
            {
                EncounterMonster();
            }
            return true;
        }

        public static int Attack()
        {
            return rnd.Next(DmgLowest, DmgLowest + 10);
        }

        public static void EncounterMonster(Type monster = Type.Default)
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
                            Player.RunAway = Player.RunAway - 1;
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
                    StatsMonster();
                    StatsPlayer();
                }
                tick = !tick;
            }
        }

        private static void SelectMonster(Type monster = Type.Default)
        {
            Type type = (Type)rnd.Next(1, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A monster appeared!");

            switch (type)
            {
                case Type.Monster1:
                    Monster.Name = "Monster lvl1";
                    SelectLevel(1);
                    break;
                case Type.Monster2:
                    Monster.Name = "Monster lvl2";
                    SelectLevel(2);
                    break;
                case Type.Monster3:
                    Monster.Name = "Monster lvl3";
                    SelectLevel(3);
                    break;
                case Type.Monster4:
                    Monster.Name = "Monster lvl4";
                    SelectLevel(4);
                    break;
                case Type.Monster5:
                    Monster.Name = "Monster lvl5";
                    Console.WriteLine("Watch out! This one's dangerous!");
                    SelectLevel(5);
                    break;
            }
            Console.WriteLine(Monster.Name);
             
        }

        private static void SelectLevel(int level)
        {
            switch (level)
            {
                case 1:
                    Monster.Hp = 50;
                    Monster.DmgLowest = 2;
                    Console.WriteLine("Grr..");
                    break;
                case 2:
                    Monster.Hp = 60;
                    Monster.DmgLowest = 5;
                    Console.WriteLine("Hgggrr..");
                    break;
                case 3:
                    Monster.Hp = 75;
                    Monster.DmgLowest = 10;
                    Console.WriteLine("GGruuaagh..");
                    break;
                case 4:
                    Monster.Hp = 100;
                    Monster.DmgLowest = 15;
                    Console.WriteLine("Mggrruuaaghhr..");
                    break;
                case 5:
                    Monster.Hp = 150;
                    Monster.DmgLowest = 15;
                    Console.WriteLine("GGRRUAAGHHH..");
                    break;
            }
        }

        private static void PlayerAttack()
        {
            Monster.Hp -= Player.Attack();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You attacked and did {0} damage!", Player.Attack());
        }

        private static void MonsterAttack()
        {
            Player.Hp -= Monster.Attack();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The monster attacked and did {0} damage!", Monster.Attack());
        }

        public static char GetLetter()
        {
            int num = rnd.Next(0, 25);
            char let = (char)('a' + num);
            return let;
        }
    }
}
