using System;

namespace CatLIfe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string catType = Console.ReadLine();
            string gender = Console.ReadLine();

            int years = 0;
            switch (catType) 
            {
                case "British Shorthair":
                    years = 13;
                    break;
                case "Siamese":
                    years = 15;
                    break;
                case "Persian":
                    years = 14;
                    break;
                case "Ragdoll":
                    years = 16;
                    break;
                case "American Shorthair":
                    years = 12;
                    break;
                case "Siberian":
                    years = 11;
                    break;
                default:
                    Console.WriteLine($"{catType} is invalid cat!");
                    return;
            }

            if (gender == "f") 
            {
                years++;
            }

            int catMonths = (years * 12) / 6;

            Console.WriteLine($"{catMonths} cat months");
        }
    }
}