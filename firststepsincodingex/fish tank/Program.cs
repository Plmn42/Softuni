using System;

namespace fish_tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double spaceTaken = double.Parse(Console.ReadLine()) / 100;

            int volume = lenght * width * height;
            double allSpaceAvailable = volume / 1000.0;
            double spaceAvailable = allSpaceAvailable * (1 - spaceTaken);

            Console.WriteLine(spaceAvailable);
        }
    }
}