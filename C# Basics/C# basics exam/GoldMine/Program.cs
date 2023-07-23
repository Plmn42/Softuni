using System;

namespace GoldMine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int locationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < locationsCount; i++) 
            {
                double expextedGold = double.Parse(Console.ReadLine());
                
                int daysPerLocation = int.Parse(Console.ReadLine());

                double goldSum = 0;
                for (int j = 0; j < daysPerLocation; j++) 
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    goldSum += goldPerDay;
                }
                double avgGold = goldSum / daysPerLocation;
                if (avgGold >= expextedGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {avgGold:f2}.");
                }
                else 
                {
                    Console.WriteLine($"You need {expextedGold - avgGold:f2} gold.");
                }
            }
        }
    }
}