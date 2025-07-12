// I added the "Search Entries" option so the user can look for and watch an entry if it is in the journal
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nJournal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Search Entries");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _promptText = prompt,
                    _entryText = response,
                    _date = DateTime.Now.ToString("yyyy-MM-dd")
                };

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added successfully!\n");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully!\n");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully!\n");
            }

            else if (choice == "5")
            {
                Console.WriteLine("Enter a search term (keyword or date).");
                Console.WriteLine("For dates, please enter in the format yyyy-MM-dd (e.g., 2023-08-15).");

                string searchTerm = Console.ReadLine();
                journal.SearchEntries(searchTerm);
            }
            else if (choice == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }
    }
}
