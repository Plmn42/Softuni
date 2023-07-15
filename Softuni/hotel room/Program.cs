using System;

namespace hotel_room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double apartmentPrice = 0, studioPrice = 0;

            switch (month) 
            {
                case "May":
                case "October":
                    apartmentPrice = 65;
                    studioPrice = 50; 
                    break;
                case "June":
                case "September":
                    apartmentPrice = 68.70;
                    studioPrice = 75.20;
                    break;
                case "July":
                case "August":
                    apartmentPrice = 77;
                    studioPrice = 76;
                    break;
            }

            double totalApartmentCost = apartmentPrice * nightsCount;
            double totalStudioCost = studioPrice * nightsCount;

            if (nightsCount > 14 && (month == "May" || month == "October"))
            {
                totalStudioCost *= 0.7;
            }
            else if (nightsCount > 7 && (month == "May" || month == "October"))
            {
                totalStudioCost *= 0.95;
            }
            else if (nightsCount > 14 && (month == "June" || month == "September")) 
            {
                totalStudioCost *= 0.8;
            }

            if (nightsCount > 14) 
            {
                totalApartmentCost *= 0.9;
            } 

            Console.WriteLine($"Apartment: {totalApartmentCost:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioCost:f2} lv.");
        }
    }
}