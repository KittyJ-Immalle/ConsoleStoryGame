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

        public static void ChooseName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What should we call you?");
            Console.ResetColor();
            Player.Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Very well, " + Player.Name + "\nLet's get started");
            Console.ResetColor();
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
            PrintGameOverLogo();
        }

        private static void PrintGameOverLogo()
        {
            Console.SetWindowSize(100,40);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            // GAME
            Console.WriteLine(String.Format("{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,26}{0,1}{0,1}{0,1}{0,1}{0,16}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,26}{0,1}{0,1}{0,1}{0,1}{0,16}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine();
            Console.WriteLine();
            // OVER
            Console.WriteLine(String.Format("{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,16}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,16}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,16}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,1}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,16}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,16}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine(String.Format("{0,6}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,16}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,1}{0,6}{0,1}{0,1}{0,1}{0,1}{0,11}{0,1}{0,1}{0,1}{0,1}", "#"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Enter();
        }

        public static void Enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
