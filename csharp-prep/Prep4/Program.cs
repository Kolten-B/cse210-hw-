using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        // Input loop to gather the numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Claculate the sum
        int sum = numbers.Sum();

        // Calculate the average
        double average = numbers.Average();

        // Find the maximum number
        int max = numbers.Max();

        // Results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max number is: {max}");
    }
}