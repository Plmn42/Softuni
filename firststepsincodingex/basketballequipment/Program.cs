using System;

namespace basketballequipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyPayment = int.Parse(Console.ReadLine());

            double shoePrice = yearlyPayment - (yearlyPayment * 0.4);
            double clothesPrice = shoePrice - (shoePrice * 0.2);
            double ballPrice = clothesPrice / 4;
            double accessories = ballPrice / 5;

            double totalPrice = yearlyPayment + shoePrice + clothesPrice + ballPrice + accessories;

            Console.WriteLine(totalPrice);
        }
    }
}