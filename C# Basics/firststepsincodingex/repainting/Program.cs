using System;

namespace repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            totalPrice += (nylon + 2) * 1.50;
            totalPrice += (paint + (paint * 0.1)) * 14.50;
            totalPrice += thinner * 5.00;
            totalPrice += 0.40;

            double workerPrice = (totalPrice * 0.3) * hours;
            double truePrice = totalPrice + workerPrice;

            Console.WriteLine($"{truePrice}");

        }
    }
}