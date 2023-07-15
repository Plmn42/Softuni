using System;

namespace Courier_express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packageWeight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double price = 0;

            switch (serviceType) 
            {
                case "standard":
                    if (packageWeight < 1) 
                    {
                        price = 0.03 * distance;
                    }
                    if (packageWeight >= 1 && packageWeight < 10) 
                    {
                        price = 0.05 * distance;
                    }
                    if (packageWeight >= 10 && packageWeight < 40) 
                    {
                        price = 0.10 * distance;
                    }
                    if (packageWeight >= 40 && packageWeight < 90) 
                    {
                        price = 0.15 * distance;
                    }
                    if (packageWeight >= 90 && packageWeight < 150) 
                    {
                        price = 0.20 * distance;
                    }
                    break;

                case "express":
                    if (packageWeight < 1)
                    {
                        price = ((0.03 * 0.8) * distance) * packageWeight + (distance * 0.03) ;
                    }
                    if (packageWeight >= 1 && packageWeight < 10)
                    {
                        price = ((0.05 * 0.4) * distance) * packageWeight + (distance * 0.05);
                    }
                    if (packageWeight >= 10 && packageWeight < 40)
                    {
                        price = ((0.10 * 0.05) * distance) * packageWeight + (distance * 0.10);
                    }
                    if (packageWeight >= 40 && packageWeight < 90)
                    {
                        price = ((0.15 * 0.02) * distance) * packageWeight + (distance * 0.15);
                    }
                    if (packageWeight >= 90 && packageWeight < 150)
                    {
                        price = ((0.20 * 0.01) * distance) * packageWeight + (distance * 0.20);
                    }
                    break;
            }

            Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:f3} kg. would cost {price:f2} lv.");
        }
    }
}