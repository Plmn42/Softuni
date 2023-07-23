    using System;

    namespace ConsoleApp1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double pagePrice = double.Parse(Console.ReadLine());
                double coverPrice = double.Parse(Console.ReadLine());
                int paperDiscount = int.Parse(Console.ReadLine());
                double designerSum = double.Parse(Console.ReadLine());
                int percentPaidFromTeam = int.Parse(Console.ReadLine());

                double totalPrice = 0;

                totalPrice = (pagePrice * 899) + (coverPrice * 2);
                totalPrice *= 1.0 - (double)paperDiscount / 100;
                totalPrice += designerSum;
                totalPrice *= 1.0 - (double)percentPaidFromTeam / 100;

                Console.WriteLine($"Avtonom should pay {totalPrice:f2} BGN.");
            }
        }
    }