using System;

namespace fishing_boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            int boatCost = season switch
            {
                "Spring" => 3000,
                "Summer" => 4200,
                "Autumn" => 4200,
                "Winter" => 2600,
            };

            double totalCost = boatCost;

            if (fishermanCount <= 6)
            {
                totalCost *= 0.90;
            }

            else if (fishermanCount <= 11 && fishermanCount >= 7)
            {
                totalCost *= 0.85;
            }

            else
            {
                totalCost *= 0.75;
            }

            if (season != "Autumn" && fishermanCount % 2 == 0)
            {
                totalCost *= 0.95;
            }

            if (totalCost <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - totalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva.");
            }
        }
    }
}