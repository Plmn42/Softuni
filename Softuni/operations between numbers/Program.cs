using System;

namespace operations_between_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;

            switch (symbol)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 * 1.00 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    break;
            }

            double even = result % 2;
            if (even == 0)
            {
                if (symbol == "+")
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - even");
                }
                else if (symbol == "-")
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else if (symbol == "*")
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                }
            }
            else
            {
                if (symbol == "+")
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - odd");
                }
                else if (symbol == "-")
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }
                else if (symbol == "*")
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }
            }
        }
    }
}