using System;

namespace christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paperRolls = double.Parse(Console.ReadLine());
            double sheetRolls = double.Parse(Console.ReadLine());
            
            double glueLitres = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            totalPrice += paperRolls * 5.80;
            totalPrice += sheetRolls * 7.20;
            totalPrice += glueLitres * 1.20;

            double trueDisc = totalPrice * (discount / 100);
            totalPrice -= trueDisc;

            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}