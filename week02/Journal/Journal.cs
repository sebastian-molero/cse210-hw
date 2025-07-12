using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = response
                };

                _entries.Add(entry);
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    public void SearchEntries(string searchTerm)
    {
        bool found = false;
        foreach (Entry entry in _entries)
        {
            if (entry._entryText.Contains(searchTerm) || entry._date.Contains(searchTerm))
            {
                entry.Display();
            }
        }
        if (found == false)
        {
            Console.WriteLine("No entries found for the given search term");
        }
    }
}

