using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace C_Sharp_Practice
{
    class Module_FizzBuzz
    {
        bool ReportStats;
        List<long> Results = new List<long>();
        string[] MethodDescriptions = new string[] {
            "\nMethod 1: modulo comparison and a for loop.\n",
            "\nMethod 2: subtraction looping and a for loop.\n",
            "\nMethod 3: recursive subtraction and a for loop.\n",
            "\nMethod 4: modulo comparison and recursion.\n",
            "\nMethod 5: subtraction looping and recursion.\n",
            "\nMethod 6: recursive subtraction and recursion.\n",
            "\nMethod 7: fast as I can make it.\n"
        };

        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Results = new List<long>();

                #region FizzBuzz intro
                //intro speech
                string intro = "The goal of FizzBuzz is to count up from zero and on every number that is divisible by 3 you say fizz, and on every number divisible by 5 you say buzz, if the number is both divisible by 3 and 5, say fizzbuzz. ";
                string options = "\nHow high of a number should we count?\n" + "\nYou can also type \"stats\" to read about how well this performs using different methods of calculation.\n" + "\nType \"e\" to go back to the main menu.\n";
                Console.WriteLine(DecorLines.Decor2 + "FizzBuzz" + DecorLines.Decor2);
                Console.WriteLine(intro);
                Console.WriteLine(DecorLines.Decor2);
                Console.WriteLine(options);

                //take input
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
                #endregion

                //Start FizzBuzzing.
                //  if no stats are desired, only runs this on method 1.
                Stopwatch Watcher = new Stopwatch();
                if (ReportStats)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine(DecorLines.Decor1 + MethodDescriptions[i] + DecorLines.Decor1);
                        Watcher.Start();
                        switch (i)
                        {
                            case 0: Method1(num); break;
                            case 1: Method2(num); break;
                            case 2: Method3(num); break;
                            case 3: Method4(num); break;
                            case 4: Method5(num); break;
                            case 5: Method6(num); break;
                            case 6: Method7(num); break;
                        }
                        RecordResults(Watcher);
                        Console.WriteLine();
                    }
                    ReportResults();
                }
                else
                {
                    //this is just method 1,
                    //  but it prints each number on a new line instead.
                    for (int i = 1; i <= num; i++)
                    {
                        if (i % 3 == 0) Console.Write("Fizz");
                        if (i % 5 == 0) Console.Write("Buzz");
                        if (i % 3 != 0 && i % 5 != 0) Console.Write(i);
                        Console.Write("\n");
                    }
                }

                Console.WriteLine();
                Console.ReadLine();
            }
        }

        void RecordResults(Stopwatch Watcher)
        {
            Watcher.Stop();
            Results.Add(Watcher.ElapsedMilliseconds);
            Watcher.Reset();
        }

        void ReportResults()
        {
            for (int i = 0; i < 7; i++)
            {
                string result = $"\nMethod {i + 1} took {Results[i]} miliseconds.\n AKA {Results[i] / 1000} seconds.";
                Console.WriteLine(result);
            }
        }

        //modulo comparison and for loop
        void Method1(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                bool b1 = i % 3 == 0;
                bool b2 = i % 5 == 0;

                if (b1) Console.Write("Fizz");
                if (b2) Console.Write("Buzz");
                if (!b1 && !b2) Console.Write(i);
                Console.Write(", ");
            }
        }

        //subtraction looping and a for loop.
        void Method2(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                float a = i;
                while (a > 0) a -= 3;
                if (a == 0) Console.Write("Fizz");

                float b = i;
                while (b > 0) b -= 5;
                if (b == 0) Console.Write("Buzz");

                if (a < 0 && b < 0) Console.Write(i);
                Console.Write(", ");
            }
        }

        //recursive subtraction and a for loop.
        void Method3(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                bool b1 = Method3_Recurve(i, 3) == 0;
                bool b2 = Method3_Recurve(i, 5) == 0;

                if (b1) Console.Write("Fizz");
                if (b2) Console.Write("Buzz");
                if (!b1 && !b2) Console.Write(i);
                Console.Write(", ");
            }
        }

        float Method3_Recurve(float f, float iteration)
        {
            if (!(f <= 0)) f = Method3_Recurve(f - iteration, iteration);
            return f;
        }

        //modulo comparison and recursion.
        void Method4(int num)
        {
            Console.WriteLine(Method4_recurve(1, num));
        }

        string Method4_recurve(int Start, int Stop)
        {
            string str = "";

            bool b1 = Start % 3 == 0;
            bool b2 = Start % 5 == 0;

            if (b1) str += "Fizz";
            if (b2) str += "Buzz";
            if (!b1 && !b2) str += Start.ToString();

            str += ", ";

            Start++;
            if (Start <= Stop) str += Method4_recurve(Start, Stop);
            return str;
        }

        //subtraction looping and recursion.
        void Method5(int num)
        {
            Console.WriteLine(Method5_Recurve(1, num));
        }

        string Method5_Recurve(int Start, int Stop)
        {
            string str = "";

            float a = Start;
            while (a > 0) a -= 3;
            if (a == 0) str += "Fizz";

            float b = Start;
            while (b > 0) b -= 5;
            if (b == 0) str += "Buzz";

            if (a < 0 && b < 0) str += Start.ToString();

            str += ", ";
            Start++;
            if (Start <= Stop) str += Method4_recurve(Start, Stop);
            return str;
        }

        void Method6(int num)
        {
            Console.WriteLine(Method6_Recurve(1,num));
        }

        string Method6_Recurve(int Start, int Stop)
        {
            string str = "";

            //this just recycles method 3 \s 
            bool b1 = Method3_Recurve(Start, 3) == 0;
            bool b2 = Method3_Recurve(Start, 5) == 0;

            if (b1) Console.Write("Fizz");
            if (b2) Console.Write("Buzz");
            if (!b1 && !b2) Console.Write(Start);
            Console.Write(", ");

            str += ", ";
            Start++;
            if (Start <= Stop) str += Method4_recurve(Start, Stop);
            return str;
        }

        //fast as i can get it.
        void Method7(int num)
        {
            //can we track the result via bool? is this faster?
            //multi threading?
        }
    }
}

