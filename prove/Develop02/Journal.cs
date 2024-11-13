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
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }

    public void AddEntry(Entry entry)
    {
        if (entryCount < entries.Length)
        {
            entries[entryCount++] = entry;
            Console.WriteLine("Entry added.");
        }
        else
        {
            Console.WriteLine("Journal is full.");
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
        Console.WriteLine($"{i + 1}. {entries[i].GetPrompt()}");
        Console.WriteLine($"   Response: {entries[i].GetResponse()}");
        Console.WriteLine($"   Location: {entries[i].GetLocation()}");
        Console.WriteLine($"   Date: {entries[i].GetDate()}");
        Console.WriteLine();
    }
    
}

    public string SaveToString()
    {
        string savedEntries = string.Empty;
        for (int i = 0; i < entryCount; i++)
        {
            savedEntries += entries[i].ToString() + "\n";
        }
        return savedEntries.Trim();  
    }
    public void LoadFromString(string savedEntries)
    {
        entries = new Entry[entries.Length];  
        entryCount = 0;

        
        string[] entryStrings = savedEntries.Split('\n');

 
        foreach (String entryString in entryStrings)
        {
            Entry entry = Entry.FromString(entryString);
            if (entry != null && entryCount < entries.Length)
            {
                entries[entryCount++] = entry;
            }
        }
        Console.WriteLine("Entries loaded.");
        DisplayEntries(); 
    }
     public int GetEntryCount()
    {
        return entryCount;
    }
    public void DeleteEntry(int index)
{
    if (index >= 0 && index < entryCount)
    {
        for (int i = index; i < entryCount - 1; i++)
        {
            entries[i] = entries[i + 1]; 
        }
        entries[--entryCount] = null; 
        Console.WriteLine("Entry deleted.");
    }
    else
    {
        Console.WriteLine("Invalid index. Entry could not be deleted.");
    }
}
}