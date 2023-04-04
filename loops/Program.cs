using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            int counter = 0;
            while (counter <= 100)
            {
                Console.WriteLine(counter);
                counter++;
            }

            int counterTwo = 0;
            do
            {
                Console.WriteLine(counterTwo);
                counterTwo++;
            } while (counter <= 100);
            */
        
            Console.WriteLine("1/2 + 2/3 + 3/4 + ... + n/n+1");
            Console.WriteLine("Enter a value for number N: ");
            int numberN = int.Parse(Console.ReadLine());
            float result = 0f;

            for (float i = 1; i < numberN; i++)
            {
                result += i / (i + 1);
                
            }

            Console.WriteLine("Result equals to: {0}", result);

            Console.ReadKey();
        }
    }
}