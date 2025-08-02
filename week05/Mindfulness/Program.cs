//At the end of the program the user will see which and how many activities it made.
using System;

class Program
{
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int listingCount = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity ba = new BreathingActivity();
                ba.Run();
                breathingCount++;
            }
            else if (input == "2")
            {
                ReflectionActivity ra = new ReflectionActivity();
                ra.Run();
                reflectionCount++;
            }
            else if (input == "3")
            {
                ListingActivity la = new ListingActivity();
                la.Run();
                listingCount++;
            }
            else if (input == "4")
            {
                Console.WriteLine("\nThanks for participating!");
                Console.WriteLine($"Sessions completed: Breathing ({breathingCount}), Reflection ({reflectionCount}), Listing ({listingCount})");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Option. Press a number between 1-4");
                Console.ReadLine();
            }
        }
    }
}
