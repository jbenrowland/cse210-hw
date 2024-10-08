using System;
using System.Collections.Generic;
using System.IO;

class Entry // This Class has properties for the prompt, response, and date. 
//It includes a constructor for creating new entries and overrides ToString() for formatted output.

{
    public string Prompt { get; set; } //get the prompt and then set it as the prompt variable
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt; ; // essentially a collection of strings that the user will be prompted with when creating a new entry
        Response = response; // make sure they are actually able to respond and there is a variable to store the response in
        Date = DateTime.Now.ToString("yyyy-MM-dd"); //I want the format to be specified this way
    }

    public override string ToString() //overrides the standards code to produce this format
    {
        return $"{Date} | {Prompt} | {Response}"; //returns the three things in a specific order once the response is received from the user
    }
}

class Journal
{
    public List<Entry> Entries { get; private set; }
    public List<string> Prompts { get; private set; }

    public Journal() //stores the entries and prompts 
    {
        Entries = new List<Entry>();
        Prompts = new List<string> //where the prompts the user receives are stored
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Did you meet someone new today? how was that experience?",
            "What did you study in the scriptures today?",
            "how did it feel when your code finally successful pushed to github?",
            "How was the weather today?",
            "What did you eat for lunch/dinner today?"
        };
    }
// #1 - Write a New Entry Code
    public void AddEntry(Entry entry)
      //code that allows you to add new entries into the journal and it stores it as an additional entry
    {
        Entries.Add(entry);
    }
// #2 Display Journal Code
    public void DisplayEntries()
        // allows the entries to be displayed if ther user presses 2 and requests it
    {
        foreach (var entry in Entries)
                //for each entry stored in entries, it will write in entries in the console as requested
        {
            Console.WriteLine(entry); //writes the entry in console
        }
    }
// #3 Save Journal to file 
    public void SaveToFile(string filename)
        //this code saves the entry under a specific filename that is a string that the user can enter and later load if desired
    {
        using (StreamWriter writer = new StreamWriter(filename))
        //efficient way to write text to store it in directly in a file
        //essentially it writes it then stores it as a variable which can be easily stored in as a filename

        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Prompt}~|~{entry.Response}~|~{entry.Date}");
            }
            //stores each entry in this order in the save file
        }
    }
// #4 Load Journal from file code
    public void LoadFromFile(string filename)
        //load a specific filename from the filesystem
    {
        Entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line; //created a string stored in line variable
            while ((line = reader.ReadLine()) != null)
            //while loop in which the line is read and the file is loaded from the filesystem 
            //you have to split line into several parts and then add new entry to the console based on the entry the user chose
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

class Program // this class holds the actual program itself
{
    static void Main()
    {
        Journal journal = new Journal(); //Pull from the Journal Class code
        string userInput;
        
        // What the user sees as options in the console
        {

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
  //when the user inputs info, read it and shove it through the switch statement
            switch (userInput)  // cleaner alternative to multiple if statements
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
}
