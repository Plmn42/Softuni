using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0 , p2 = 0 , p3 = 0 , p4 = 0 , p5 = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0 ; i < n ; i++) 
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else 
                {
                    p5++;
                }
                
            }
            Console.WriteLine($"{p1 / n * 100:f2}%");
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
            Console.WriteLine($"{p4 / n * 100:f2}%");
            Console.WriteLine($"{p5 / n * 100:f2}%");
        }
    }
}