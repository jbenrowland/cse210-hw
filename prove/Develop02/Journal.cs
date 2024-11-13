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

    private Entry[] _entries;
    private int _entryCount;

    public Journal(int maxEntries)
    {
        _entries = new Entry[maxEntries];
        _entryCount = 0;
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }

    public void AddEntry(Entry entry)
    {
        if (_entryCount < _entries.Length)
        {
            _entries[_entryCount++] = entry;
            Console.WriteLine("Entry added.");
        }
        else
        {
            Console.WriteLine("Journal is full.");
        }
    }
   public void DisplayEntries()
{
    if (_entryCount == 0)
    {
        Console.WriteLine("No entries to display.");
        return;
    }

    for (int i = 0; i < _entryCount; i++)
    {
        Console.WriteLine($"{i + 1}. {_entries[i].GetPrompt()}");
        Console.WriteLine($"   Response: {_entries[i].GetResponse()}");
        Console.WriteLine($"   Location: {_entries[i].GetLocation()}");
        Console.WriteLine($"   Date: {_entries[i].GetDate()}");
        Console.WriteLine();
    }
    
}

    public string SaveToString()
    {
        string savedEntries = string.Empty;
        for (int i = 0; i < _entryCount; i++)
        {
            savedEntries += _entries[i].ToString() + "\n";
        }
        return savedEntries.Trim();  
    }
    public void LoadFromString(string savedEntries)
    {
        _entries = new Entry[_entries.Length];  
        _entryCount = 0;

        
        string[] entryStrings = savedEntries.Split('\n');

 
        foreach (String entryString in entryStrings)
        {
            Entry entry = Entry.FromString(entryString);
            if (entry != null && _entryCount < _entries.Length)
            {
                _entries[_entryCount++] = entry;
            }
        }
        Console.WriteLine("Entries loaded.");
        DisplayEntries(); 
    }
     public int GetEntryCount()
    {
        return _entryCount;
    }
    public void DeleteEntry(int index)
{
    if (index >= 0 && index < _entryCount)
    {
        for (int i = index; i < _entryCount - 1; i++)
        {
            _entries[i] = _entries[i + 1]; 
        }
        _entries[--_entryCount] = null; 
        Console.WriteLine("Entry deleted.");
    }
    else
    {
        Console.WriteLine("Invalid index. Entry could not be deleted.");
    }
}
}