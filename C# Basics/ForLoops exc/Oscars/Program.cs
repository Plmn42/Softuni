﻿using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judgesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < judgesCount; i++) 
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());

                academyPoints += (judgeName.Length * judgePoints / 2);

                if (academyPoints > 1250.5) 
                {
                    break;
                }
            }

            if (academyPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
            }   
            else 
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:f1} more!");
            }
        }
    }
}