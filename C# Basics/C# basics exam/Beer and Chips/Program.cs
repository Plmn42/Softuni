using System;

namespace Beer_and_Chips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            double beerPrice = beerCount * 1.20;
            double chipsPrice = beerPrice * 0.45;
            double totalChipsPrice = Math.Ceiling (chipsPrice * chipsCount);

            totalPrice = beerPrice + totalChipsPrice;

            if (totalPrice > budget)
            {
                Console.WriteLine($"{fanName} needs {totalPrice - budget:f2} more leva!");
            }
            else 
            {
                Console.WriteLine($"{fanName} bought a snack and has {budget - totalPrice:f2} leva left.");
            }
        }
    }
}