using System;

namespace football_kit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());
            double neededSum = double.Parse(Console.ReadLine());
            double pantsPrice = shirtPrice * 0.75;
            double socksPrice = pantsPrice * 0.20;
            double shoesPrice = (shirtPrice + pantsPrice) * 2;

            double totalPrice = shirtPrice + pantsPrice + socksPrice + shoesPrice;

            double truePrice = totalPrice - (totalPrice * 0.15);

            if (truePrice > neededSum) 
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {truePrice:f2} lv.");
            }

            if (neededSum > truePrice) 
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {neededSum - truePrice:f2} lv. more.");
            }
        }
    }
}