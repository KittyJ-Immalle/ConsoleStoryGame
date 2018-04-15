using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Dialogue
    {
        private static string input;

        public static void BeforeStart()
        {
            Console.WriteLine("It's important that you know the attack button changes every time, follow the instructions.");
            Console.WriteLine("Have fun! :D");
            Console.WriteLine("- Press ENTER to continue -");
            Enter();
        }

        public static void ChooseName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What should we call you?");
            Console.ResetColor();
            Player.Name = Console.ReadLine();
            ConfirmName();
            
        }

        public static void ConfirmName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Player.Name + ", is this correct? (Y/N)");
            Console.ResetColor();
            string chosenName = Console.ReadLine();
            if (chosenName.ToLower() == "yes" || chosenName.ToLower() == "y" || chosenName.ToLower() == "yeah")
            {
                Console.WriteLine("Very well, " + Player.Name + "\nLet's get started");
                Console.ResetColor();
            }
            else if (chosenName.ToLower() == "no" || chosenName.ToLower() == "n" || chosenName.ToLower() == "nah")
            {
                ChooseName();
            }
            else
            {
                Console.WriteLine("Not a valid answer");
                ConfirmName();
            }
        }

        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello? Are you awake?");
            Enter();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You open your eyes, wondering where you are.\nYou feel yourself lying on a soft surface. It's a bed.");
            Enter();
            Console.WriteLine("When you take another look around you realize you're in some kind of mansion.");
            Enter();
            Console.WriteLine("There's a girl standing in front of you. She looks worried.");
            Enter();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Oh thank god, I thought you died.");
            Enter();
            Console.WriteLine("There's no time to explain, we have to get out of this place.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("a: What happend? | b: Let's get going!");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("What? You mean to tell me you don't remember anything?");
                    Enter();
                    Console.WriteLine("Mh, I suppose that's possible after you passed out.");
                    Enter();
                    Console.WriteLine("We were trying to escape this place but you were attacked by a monster.");
                    Enter();
                    Console.WriteLine("Don't worry, I was able to scare it off.\nWe should go now.");
                    break;
                }
                else if (input == "b")
                {
                    break;
                } else
                {
                    Console.WriteLine("Hm?");
                }
                
            }
        }

        public static void Closet()
        {

        }

        public static void EndingDialogue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("No! It can't be!");
            Enter();
            Console.WriteLine("Please, please don't die.");
            Enter();
            Console.WriteLine("I can't survive without you...");
            Enter();
            Picture.PrintGameOverLogo();
        }


        public static void Enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
