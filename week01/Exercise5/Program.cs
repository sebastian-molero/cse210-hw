using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");


        // Greeting
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }


        // Getting User's name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            return name;
        }


        // Getting User's number
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string sNumber = Console.ReadLine();
            int number = int.Parse(sNumber);
            return number;
        }


        // Returning the number ^ 2
        static int SquareNumber(int number)
        {
            int sqNumber = number * number;
            return sqNumber;
        }


        // Result
        static void DisplayResult(string name, int sqNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {sqNumber}");
        }


        // Executing the code

        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareNumber(number);

        DisplayResult(name, square);
        
    }
}