using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            while (true)//Main Loop
            {
                string WelcomeSpeech = "  Hello, thanks for checking out this collection of small works.";
                string Instructions = "To get started, type in which module you'd like to check out!";

                string[] ModulesNames = new string[] {
                    "1. Game: Find the I.",
                    "2. Practice: FizzBuzz",
                    "3. Experiment: Console Art",
                    "e. Exit program"
                };

                Console.WriteLine($"{DecorLines.Decor1}\n{WelcomeSpeech}\n{Instructions}");
                Console.WriteLine(DecorLines.Decor1);
                foreach (string Module in ModulesNames) Console.WriteLine(Module);
                Console.WriteLine(DecorLines.Decor1);

                Console.Write("\nModule: ");
                string Input = Console.ReadLine();

                //Compare Input to modules and start module selected
                if (Input == "e") break;
                if (Input == "1") new Module_FindTheI().Start();
                if (Input == "2") new Module_FizzBuzz().Start();
                if (Input == "3") new Module_ConsoleArt().Start();
            }

            //Safe exit, save data(if needed), say goodbyes.
            Console.WriteLine("Thanks for checking this out.\nI hope you have a great rest of your day!");
            Console.Write("\nPress Enter to exit.");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }

    /// <summary>
    /// Reference/Library for decorative Lines
    /// </summary>
    static class DecorLines
    {
        /// <summary>~ ~ ~ </summary>
        public static readonly string Decor1 = "~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ";
        
        /// <summary>+ + + </summary>
        public static readonly string Decor2 = "+ + + + + + + + + + + + ";

        /// <summary>! ! ! </summary>
        public static readonly string Alarm1 = "! ! ! ! ! ! ! ! ! ! ! ! ";
        
        /// <summary>!&!&!&</summary>
        public static readonly string Alarm2 = "!&!&!&!&!&!&!&!&!&!&!&!&";
    }
}
