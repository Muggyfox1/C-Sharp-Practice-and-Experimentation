using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Module_ConsoleArt
    {
        
        public void Start()
        {
            while (true) //Main Loop
            {
                Console.ResetColor();
                Console.Clear();
                DrawArt(0);
                Console.WriteLine("Please enter what art piece you would like to see.");
                Console.WriteLine("1: Hello World");
                Console.WriteLine("2: Sun Rise");
                Console.WriteLine("3: Random Static");
                Console.WriteLine("4: Code Lisa");
                Console.WriteLine("e: Exit Module");

                string UserInput = "";
                int UserInt = 0;
                while(UserInput != "e" && !(UserInt > 0 || UserInt > 5))
                {
                    Console.Write("Selection: ");
                    UserInput = Console.ReadLine();
                    int.TryParse(UserInput, out UserInt);
                }
                Console.Write("Success!");
                DrawArt(UserInt);
                break;
            }
            
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        void DrawArt(int ArtPiece)
        {
            Console.ResetColor();
            Console.Clear();
            foreach (string s in ArtPieces[ArtPiece])
            {
                foreach (char c in s)
                {
                    switch (c)
                    {
                        case 'w':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;
                        case 'b':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                        case 'r':
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                        case 'g':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        case 'l':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case 'y':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;
                    }
                    Console.Write(" ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n");
            }
        }

        string[][] ArtPieces = new string[][]
        {
            //121 is max width //why?

            //Console Art Intro
            new string[]{
            "bwbbwbrrrrbgbbbblbbbbbyybbb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwwwwbrrrrbgbbbblbbbbybbybb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwbbwbrrrrbggggbllllbbyybbb",
            "bbbbbbbbbbbbbbbbbbbbbbbbbbb",
            "bybybybbllbbgggbbrbbbbwwwbb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bybybyblbblbgggbbrbbbbwbbwb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bbybybbbllbbgbbgbrrrrbwwwbb"},

            //Hello World
            new string[]{
            "bwbbwbrrrrbgbbbblbbbbbyybbb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwwwwbrrrrbgbbbblbbbbybbybb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwbbwbrrrrbggggbllllbbyybbb",
            "bbbbbbbbbbbbbbbbbbbbbbbbbbb",
            "bybybybbllbbgggbbrbbbbwwwbb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bybybyblbblbgggbbrbbbbwbbwb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bbybybbbllbbgbbgbrrrrbwwwbb"},
            

            new string[]{
            "bwbbwbrrrrbgbbbblbbbbbyybbb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwwwwbrrrrbgbbbblbbbbybbybb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwbbwbrrrrbggggbllllbbyybbb",
            "bbbbbbbbbbbbbbbbbbbbbbbbbbb",
            "bybybybbllbbgggbbrbbbbwwwbb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bybybyblbblbgggbbrbbbbwbbwb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bbybybbbllbbgbbgbrrrrbwwwbb"},
            
            new string[]{
            "bwbbwbrrrrbgbbbblbbbbbyybbb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwwwwbrrrrbgbbbblbbbbybbybb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwbbwbrrrrbggggbllllbbyybbb",
            "bbbbbbbbbbbbbbbbbbbbbbbbbbb",
            "bybybybbllbbgggbbrbbbbwwwbb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bybybyblbblbgggbbrbbbbwbbwb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bbybybbbllbbgbbgbrrrrbwwwbb"},

            new string[]{
            "bwbbwbrrrrbgbbbblbbbbbyybbb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwwwwbrrrrbgbbbblbbbbybbybb",
            "bwbbwbrbbbbgbbbblbbbbybbybb",
            "bwbbwbrrrrbggggbllllbbyybbb",
            "bbbbbbbbbbbbbbbbbbbbbbbbbbb",
            "bybybybbllbbgggbbrbbbbwwwbb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bybybyblbblbgggbbrbbbbwbbwb",
            "bybybyblbblbgbbgbrbbbbwbbwb",
            "bbybybbbllbbgbbgbrrrrbwwwbb"}

        };
    }   
}
