using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal(5);
        string userInput;
        string savedEntries = string.Empty;

        do
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Create a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Delete an entry");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    string prompt = journal.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your Response: ");
                    string response = Console.ReadLine();
                    Console.Write("Enter Location (optional): ");
                    string location = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response, location));
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Please type a filename to save your entries to:");
                    string filename = Console.ReadLine();
                    savedEntries = journal.SaveToString();
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(savedEntries);
                    }
                    Console.WriteLine("Journal entries saved.");

                    break;

                case "4":
                    Console.Write("Please put in your filename:");
                    filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    savedEntries = string.Join("\n",lines); 
                    
                    if (string.IsNullOrEmpty(savedEntries))
                    {
                        Console.WriteLine("No saved journal entries to load.");
                    }
                    else
                    {
                        journal.LoadFromString(savedEntries);
                    }
                    break;

                case "5": //I added a delete entry option in order to show creativity on this assignment
                    Console.WriteLine("Select an entry to delete:");
                    journal.DisplayEntries();
                    Console.Write("Enter the number of the entry to delete (or 0 to cancel): ");
                    int deleteIndex;
                    if (int.TryParse(Console.ReadLine(), out deleteIndex) && deleteIndex > 0 && deleteIndex <= journal.GetEntryCount())
                    {
                        journal.DeleteEntry(deleteIndex - 1); 
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice or operation cancelled.");
                    }
                    break;

                case "6":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        } while (userInput != "6");
    }
}