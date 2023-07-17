using System;

namespace ski_trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();

            double roomPrice = roomType switch
            {
                "room for one person" => 18.0,
                "apartment" => 25.0,
                "president apartment" => 35.0,
                _ => 0
            };

            double totalPrice = daysCount * roomPrice;

            if (roomType == "apartment")
            {
                if (daysCount < 10)
                {
                    totalPrice *= 0.7;
                }
                else if (daysCount >= 10 && daysCount <= 15)
                {
                    totalPrice *= 0.65;
                }
                else
                {
                    totalPrice *= 0.5;
                }
            }

            if (roomType == "president apartment")
            {
                if (daysCount < 10)
                {
                    totalPrice *= 0.9;
                }
                else if (daysCount >= 10 && daysCount <= 15)
                {
                    totalPrice *= 0.85;
                }
                else
                {
                    totalPrice *= 0.8;
                }
            }

            if (grade == "positive")
            {
                totalPrice *= 1.25;
            }
            else
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}