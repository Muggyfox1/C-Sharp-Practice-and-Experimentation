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
            Console.ResetColor();
            Console.Clear();

            string[] strs = new string[]{
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
            "bbybybbbllbbgbbgbrrrrbwwwbb"};
            foreach (string s in strs)
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
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }
    }

    class Pix
    {
        int X = 0;
        int Y = 0;
        ConsoleColor FColor = ConsoleColor.White;
        ConsoleColor BGColor = ConsoleColor.Black;
        
        public Pix(int x, int y, ConsoleColor fcolor, ConsoleColor bgcolor)
        {
            X = x;
            Y = y;
            FColor = fcolor;
            BGColor = bgcolor;
        }
    }
    

}
