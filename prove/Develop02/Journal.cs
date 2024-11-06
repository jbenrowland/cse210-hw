class Journal
{
    private string[] prompts = new string[]
    {
        "What are you grateful for today?",
        "What was the highlight of your day?",
        "What challenges did you face today and how did you overcome them?",
        "Describe something that made you smile today.",
        "What is something new you learned today?"
    };

    private Entry[] entries;
    private int entryCount;

    public Journal(int maxEntries)
    {
        entries = new Entry[maxEntries];
        entryCount = 0;
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        return prompts[random.Next(prompts.Length)];
    }

    public void AddEntry(Entry entry)
    {
        if (entryCount < entries.Length)
        {
            entries[entryCount++] = entry;
            Console.WriteLine("Entry added successfully.");
        }
        else
        {
            Console.WriteLine("Journal is full. No more entries can be added.");
        }
    }

    public void DisplayEntries()
    {
        if (entryCount == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        for (int i = 0; i < entryCount; i++)
        {
            Console.WriteLine($"\nDate: {entries[i].Date}");
            Console.WriteLine($"Prompt: {entries[i].Prompt}");
            Console.WriteLine($"Response: {entries[i].Response}");
            if (!string.IsNullOrWhiteSpace(entries[i].Location))
                Console.WriteLine($"Location: {entries[i].Location}");
        }
    }
}
