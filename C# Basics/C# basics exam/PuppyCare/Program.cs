using System;

namespace PuppyCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boughtFood = int.Parse(Console.ReadLine()) * 1000;
            string input = Console.ReadLine();

            int totalFood = 0;


            while (input != "Adopted")
            {
                int gramsEaten = int.Parse(input);
                totalFood += gramsEaten;
                input = Console.ReadLine();
            }

            if (boughtFood < totalFood)
            {
                Console.WriteLine($"Food is not enough. You need {totalFood - boughtFood} grams more.");
            }
            else 
            {
                Console.WriteLine($"Food is enough! Leftovers: {boughtFood - totalFood} grams.");
            }
        }
    }
}