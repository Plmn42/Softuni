using System;

namespace Calc_deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositsum = double.Parse(Console.ReadLine());
            int deposittime = int.Parse(Console.ReadLine());
            double yearinterest = double.Parse(Console.ReadLine());

            double interest = depositsum * (yearinterest / 100);
            double monthint = interest / 12;
            double finalsum = depositsum + deposittime * monthint;    

            Console.WriteLine(finalsum);
        }
    }
}