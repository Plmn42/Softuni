using System;

namespace godzilla_vs_kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int extraCount = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decor = filmBudget * 0.10;
            double clothesTotalPrice = extraCount * clothesPrice;
            
            if (extraCount > 150) 
            {
                clothesTotalPrice = clothesTotalPrice - (clothesTotalPrice * 0.10);
            }

            double totalPrice = decor + clothesTotalPrice;
            double remainingMoney = filmBudget - totalPrice; 

            if (totalPrice > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - filmBudget:f2} leva more.");
            }
            else 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - totalPrice:f2} leva left.");
            }
        }
    }
}