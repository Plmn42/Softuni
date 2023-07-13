using System;

namespace shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocardCount = int.Parse(Console.ReadLine());
            int precessorCount = int.Parse(Console.ReadLine());
            int RAMCount = int.Parse(Console.ReadLine());

            double videocardPrice = videocardCount * 250;
            double pricessorPrice = videocardPrice * 0.35;
            double RAMPrice = videocardPrice * 0.10;

            double totalPrice = videocardPrice + (precessorCount * pricessorPrice) + (RAMCount * RAMPrice);

            if (videocardCount > precessorCount) 
            {
                totalPrice = totalPrice * 0.85;
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}