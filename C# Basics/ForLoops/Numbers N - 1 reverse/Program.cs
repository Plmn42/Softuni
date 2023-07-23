using System;

namespace Numbers_N___1_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--) 
            {
                Console.WriteLine(i);
            }
        }
    }
}