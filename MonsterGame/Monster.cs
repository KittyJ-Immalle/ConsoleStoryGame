using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Monster : Stats
    {
        private static Random rnd = new Random();
        private Type monsterType;
        private bool tick;
        private char letter;
        private string inputString;
        private char inputChar;
        private bool res;

        public string Name { get; set; }
        public int Hp { get; set; }
        public int DmgLowest { get; set; }

        public enum Type
        {
            Default,
            Monster1,
            Monster2,
            Monster3,
            Monster4,
            Monster5
        };

        public Monster(Type monsterType = Type.Default)
        {
            this.monsterType = monsterType;
        }

        public bool Appear()
        {
            Random rnd = new Random();
            if (rnd.Next(1, 4) == 1)
            {
                EncounterMonster();
            }
            return true;
        }

        public int Attack()
        {
            return rnd.Next(DmgLowest, DmgLowest + 10);
        }

        public void EncounterMonster()
        {
            if (monsterType == Type.Default)
            {
                SelectMonster();
            } else
            {
                SelectMonster(monsterType);
            }
            
            while (Hp >= 0)
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
                    StatsMonster(this);
                    StatsPlayer();
                }
                tick = !tick;
            }
        }

        private void SelectMonster(Type monster = Type.Default)
        {
            Type type = (Type)rnd.Next(1, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A monster appeared!");

            switch (type)
            {
                case Type.Monster1:
                    Name = "Monster lvl1";
                    SelectLevel(1);
                    break;
                case Type.Monster2:
                    Name = "Monster lvl2";
                    SelectLevel(2);
                    break;
                case Type.Monster3:
                    Name = "Monster lvl3";
                    SelectLevel(3);
                    break;
                case Type.Monster4:
                    Name = "Monster lvl4";
                    SelectLevel(4);
                    break;
                case Type.Monster5:
                    Name = "Monster lvl5";
                    Console.WriteLine("Watch out! This one's dangerous!");
                    SelectLevel(5);
                    break;
            }
            Console.WriteLine(Name);
             
        }

        private void SelectLevel(int level)
        {
            switch (level)
            {
                case 1:
                    Hp = 50;
                    DmgLowest = 2;
                    Console.WriteLine("Grr..");
                    break;
                case 2:
                    Hp = 60;
                    DmgLowest = 5;
                    Console.WriteLine("Hgggrr..");
                    break;
                case 3:
                    Hp = 75;
                    DmgLowest = 10;
                    Console.WriteLine("GGruuaagh..");
                    break;
                case 4:
                    Hp = 100;
                    DmgLowest = 15;
                    Console.WriteLine("Mggrruuaaghhr..");
                    break;
                case 5:
                    Hp = 150;
                    DmgLowest = 15;
                    Console.WriteLine("GGRRUAAGHHH..");
                    break;
            }
        }

        private void PlayerAttack()
        {
            Hp -= Player.Attack();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You attacked and did {0} damage!", Player.Attack());
        }

        private void MonsterAttack()
        {
            Player.Hp -= Attack();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The monster attacked and did {0} damage!", Attack());

            if (Player.Hp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(new string('-', 20));
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("-----!YOU DIED!-----");
                Console.WriteLine(new string('-', 20));
                Console.WriteLine(new string('-', 20));
                Player.EndLife();
            }
            else if (Player.Hp <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("[Health low]");
            }
        }

        public char GetLetter()
        {
            int num = rnd.Next(0, 25);
            char let = (char)('a' + num);
            return let;
        }
    }
}
