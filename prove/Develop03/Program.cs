using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of sample scriptures
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs 3:5-6"),
                "Trust in the Lord with all your heart, " +
                "and lean not on your own understanding; " +
                "in all your ways acknowledge Him, " +
                "and He shall direct your paths."),
            new Scripture(new Reference("John 3:16"),
                "For God so loved the world that He gave His only begotten Son, " +
                "that whoever believes in Him should not perish but have everlasting life."),
            new Scripture(new Reference("Philippians 4:13"),
                "I can do all things through Christ who strengthens me."),
            new Scripture(new Reference("Isaiah 40:31"),
                "But those who wait on the Lord shall renew their strength; " +
                "they shall mount up with wings like eagles, " +
                "they shall run and not be weary, they shall walk and not faint."),
            new Scripture(new Reference("Romans 8:28"),
                "And we know that all things work together for good to those who love God, " +
                "to those who are the called according to His purpose.")
        };

        // Select a random scripture
        Random random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }

        Console.WriteLine("Thanks for using the Scripture Memorizer!");
    }
}

class Scripture
{
    private Reference Reference { get; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine($"{Reference.GetReference()}");
        Console.WriteLine(string.Join(" ", Words.Select(w => w.IsHidden ? "_____" : w.Text)));
    }

    public void HideRandomWords()
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
}

class Reference
{
    public string ReferenceText { get; }

    public Reference(string referenceText)
    {
        ReferenceText = referenceText;
    }

    public string GetReference()
    {
        return ReferenceText;
    }
}

class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }
}