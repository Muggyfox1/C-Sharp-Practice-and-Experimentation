using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace C_Sharp_Practice
{
    class Module_FizzBuzz
    {
        bool ReportStats;
        List<long> Results = new List<long>();

        public void Start()
        {
            while (true)
            {
                Console.Clear();

                //intro
                string intro = "The goal of FizzBuzz is to count up from zero and on every number that is divisible by 3 you say fizz, and on every number divisible by 5 you say buzz, if the number is both divisible by 3 and 5, say fizzbuzz. ";
                Console.WriteLine(DecorLines.Decor2 + "FizzBuzz" + DecorLines.Decor2);
                Console.WriteLine(intro);
                Console.WriteLine(DecorLines.Decor2);
                Console.WriteLine("How high of a number should we count?\n");
                Console.WriteLine("You can also type \"stats\" to read about how well this performs using different methods of calculation.\n");
                Console.WriteLine("Type \"e\" to go back to the main menu.");

                Console.Write("input: ");
                string x = Console.ReadLine();
                if (x == "e") break;
                ReportStats = (x.ToLower() == "stats");

                //make sure input is a number above 0
                int num;
                while (!int.TryParse(x, out num) || num <= 0)
                {
                    if (ReportStats) Console.WriteLine("What number should we calculate to?");
                    Console.Write("Number: ");
                    x = Console.ReadLine();
                }

                //Method 1, modulo + looping. my Prefered way.

                Stopwatch Watcher = new Stopwatch(); 
                if (ReportStats)
                {
                    Console.WriteLine(DecorLines.Decor1 + "\nMethod 1: modulo comparison and a for loop.\n" + DecorLines.Decor1);
                    Watcher.Start();
                }

                FirstMethod(num);
                if (ReportStats) RecordResults(Watcher);

                if(ReportStats)
                {
                    Console.WriteLine
                    Watcher.Start();
                    SecondMethod(num);
                }
                    

                //Method 2, 

                Console.WriteLine();
                Console.ReadLine();
            }
        }

        void RecordResults(Stopwatch Watcher)
        {
            Watcher.Stop();
            Results.Add(Watcher.ElapsedMilliseconds);
        }

        void ReportResults()
        {
            //result = $"\nMethod {i} took {Watcher.ElapsedMilliseconds} miliseconds.\n AKA {Watcher.ElapsedMilliseconds / 1000} seconds.";
        }



        void FirstMethod(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                //can we track the result via bool? is this faster?
                if (i % 3 == 0) Console.Write("Fizz");
                if (i % 5 == 0) Console.Write("Buzz");
                if (i % 3 != 0 && i % 5 != 0) Console.Write(i);
                Console.Write("\n");
            }
        }

        void SecondMethod(int num)
        {

        }
    }
}
