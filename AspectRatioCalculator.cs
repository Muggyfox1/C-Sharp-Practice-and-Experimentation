using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class AspectRatioCalculator
    {
        public void Start()
        {
            //intro


            //gather x and y
            float x;
            while(!float.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("something went wrong, try again");
            }
            
            float y;
            while (!float.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("something went wrong, try again");
            }

            //figure highest common denom of both numbers.

            //divide numbers by highest common denom for aspect ratio as small as possible.

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
