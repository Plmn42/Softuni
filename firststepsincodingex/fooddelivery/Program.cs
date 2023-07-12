using System;

namespace fooddelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double veganMenuPrice = veganMenu * 8.15;
            double delivery = 2.50;

            double totalMenuPrice = chickenMenuPrice + fishMenuPrice + veganMenuPrice;
            double dessertPrice = totalMenuPrice * 0.2;

            double totalPrice = totalMenuPrice + dessertPrice + delivery;

            Console.WriteLine($"{totalPrice}");

        }
    }
}