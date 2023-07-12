using System;

namespace world_swimming_record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSecs = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSecsForOneMetre = double.Parse(Console.ReadLine());

            double timeToSwimTheWholeDistance = distanceInMetres * timeInSecsForOneMetre;
            double timesSlowedDown = Math.Floor(distanceInMetres / 15);

            timeToSwimTheWholeDistance += timesSlowedDown * 12.5;

            if (timeToSwimTheWholeDistance < recordInSecs)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {timeToSwimTheWholeDistance:f2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {timeToSwimTheWholeDistance - recordInSecs:f2} seconds slower.");
            }
        }
    }
}