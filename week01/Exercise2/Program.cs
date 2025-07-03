using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? (0 - 100) ");
        string strGrade = Console.ReadLine();
        int intGrade = int.Parse(strGrade);

        string letter = "";

        if (intGrade >= 90 && intGrade <= 100)
        {
            letter = "A";
        }
        else if (intGrade >= 80 && intGrade < 90)
        {
            letter = "B";
        }
        else if (intGrade >= 70 && intGrade < 80)
        {
            letter = "C";
        }
        else if (intGrade >= 60 && intGrade < 70)
        {
            letter = "D";
        }
        else if (intGrade < 60 && intGrade >= 0)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("You should enter a number between 0 and 100");
        }


        if (letter != "")
        {
            Console.WriteLine($"Your grade is {letter}");

            if (intGrade >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else if (intGrade >= 0 || intGrade < 70)
            {
                Console.WriteLine("You don't passed.");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
