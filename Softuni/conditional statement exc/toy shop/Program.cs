using System;

namespace toy_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double totalPrice = (puzzleCount * 2.60) + (dollCount * 3) + (bearCount * 4.10) + (minionCount * 8.20) + (truckCount * 2);

            int totalCount = puzzleCount + dollCount + bearCount + minionCount + truckCount;

            if (totalCount >= 50)
            {
                totalPrice *= 0.75;
            }

            totalPrice *= 0.9;

            if (tripPrice <= totalPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalPrice:f2} lv needed.");
            }
        }
    }
}