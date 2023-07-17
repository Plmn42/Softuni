using System;

namespace area_of_figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;

            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (shape == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                area = side1 * side2;
            }
            else if (shape == "circle")
            {
                double side1 = double.Parse((Console.ReadLine()));
                area = Math.PI * (side1 * side1);
            }
            else if (shape == "triangle") 
            {
                double side1 = double.Parse(((Console.ReadLine())));
                double side2 = double.Parse((((Console.ReadLine()))));
                area = (side1 * side2) / 2;
            }
            Console.WriteLine(area);
        }
    }
}