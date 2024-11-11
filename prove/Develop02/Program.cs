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
            Console.WriteLine("5. Exit");
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
                    savedEntries = journal.SaveToString();
                    Console.WriteLine("Journal entries saved.");
                    break;

                case "4":
                    if (string.IsNullOrEmpty(savedEntries))
                    {
                        Console.WriteLine("No saved journal entries to load.");
                    }
                    else
                    {
                        journal.LoadFromString(savedEntries);
                    }
                    break;

                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        } while (userInput != "5");
    }
}