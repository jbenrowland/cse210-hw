using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
}

class Journal
{
    public List<Entry> Entries { get; private set; }
    public List<string> Prompts { get; private set; }

    public Journal()
    {
        Entries = new List<Entry>();
        Prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Prompt}~|~{entry.Response}~|~{entry.Date}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    AddEntry(new Entry(parts[0], parts[1]) { Date = parts[2] });
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string userInput;

        do
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    var random = new Random();
                    var prompt = journal.Prompts[random.Next(journal.Prompts.Count)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your Response: ");
                    var response = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response));
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    var saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    var loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
            }

        } while (userInput != "5");
    }
}