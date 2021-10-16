using System;

namespace C_Sharp_Practice
{
    class FindTheI
    {
        public void Start()
        {
            while (true) //GameLoop
            {
                //Intro and difficulty selection
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                string Dline = DecorLines.Decor1;
                string WelcomeMessage = "Find The I:";
                string Instructions = "First question: How hard do you want this game to be? (1 or greater)";
                
                Console.WriteLine($"{Dline}\n{WelcomeMessage}\n{Instructions}\n{Dline}\n");

                int Difficulty = 0;
                while (true) //makes sure Difficulty is valid.
                {
                    Console.Write("Difficulty level: ");
                    string str = Console.ReadLine();
                    if (int.TryParse(str, out Difficulty) && Difficulty >= 1)
                    {
                        break;
                    }
                    Console.WriteLine("That didn't work, try again.");
                }

                //Game round
                Console.Clear(); 

                //Draw the Ls and Is
                int x = new Random().Next(0, Difficulty);
                int y = new Random().Next(0, Difficulty);
                for (int i = 0; i < Difficulty; i++)
                {
                    for (int j = 0; j < Difficulty; j++)
                    {
                        if (i == y && j == x)
                        {
                            Console.Write("I");
                        }
                        else
                        {
                            Console.Write("l");
                        }
                    }
                    Console.Write("\n");
                }

                //validate input from player.
                Instructions = "In the grid below, find the I and tell me where it is. \n" +
                    "Answer in this format \"X , Y\"\n";
                
                Console.WriteLine($"{Dline}\n{Instructions}\n{Dline}");
                int[] Guess = new int[2];

                while (true)
                {
                    Console.Write("Location of I: ");
                    string[] Input = Console.ReadLine().Split(',');
                    if (Input.Length == 2 && 
                        int.TryParse(Input[0], out Guess[0]) && 
                        int.TryParse(Input[1], out Guess[1]))
                    {
                        break;
                    }
                    Console.WriteLine("That didn't work, try again.");
                }

                if (Guess[0] == x + 1 && Guess[1] == y + 1)
                {
                    //Win
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You win!");
                }
                else
                {
                    //Lose
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You lose!");
                }

                //ask about replay
                Console.WriteLine("playAgain?");
                Console.Write("Y/N: ");
                string YN = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                if (YN != "Y" &&
                    YN != "y") break;
            }
        }
    }
}
