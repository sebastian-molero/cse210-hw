using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // Creating the list
        List<int> numbers = new List<int>();

        int user = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Adding numbers to the list while the user doesn't enter 0
        while (user != 0)
        {
            Console.Write("Enter a number: ");
            string sUser = Console.ReadLine();
            user = int.Parse(sUser);

            if (user != 0)
            {
                numbers.Add(user);
            }
        }


        // Summing the numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");


        // Getting the average 
        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {avg}");


        // Getting the largest number
        int largest = -1;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");


        // Ordering the list and displaying it
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}