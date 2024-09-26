using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store numbers
        List<int> numbers = new List<int>();

        // Get numbers from the user until 0 is entered
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Calculate and display the sum, average, and maximum
        int sum = numbers.Sum();
        double average = (double)sum / numbers.Count;
        int max = numbers.Max();

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);

        // Optional stretch challenge: Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).Min();
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine("The smallest positive number is: " + smallestPositive);
        }

        // Optional stretch challenge: Sort the numbers and display the sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}