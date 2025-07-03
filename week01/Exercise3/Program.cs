using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 101);

            int intGuess = -1;

            while (intGuess != randomNumber)
            {
                Console.Write("What is your guess? ");
                string sGuess = Console.ReadLine();
                intGuess = int.Parse(sGuess);

                if (intGuess == randomNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (intGuess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine();
        }
        Console.Write("Thanks for playing!");
    }
    
}