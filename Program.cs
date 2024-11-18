using System;

namespace CCAD16_Assignment3_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year, and I'll determine if it's a leap year:");
            double choiceYear = Convert.ToDouble(Console.ReadLine());

            if (choiceYear % 4 == 0)
            {
                if (choiceYear % 100 == 0)
                {
                    if (choiceYear % 400 == 0)
                    {
                        Console.WriteLine($"{choiceYear} is a leap year (it has 366 days).");
                    }
                    else
                    {
                        Console.WriteLine($"{choiceYear} is NOT a leap year (it has 365 days).");
                    }
                }
                else
                {
                    Console.WriteLine($"{choiceYear} is a leap year (it has 366 days).");
                }
            }
            else
            {
                Console.WriteLine($"{choiceYear} is NOT a leap year (it has 365 days).");
            }
        }
    }
}