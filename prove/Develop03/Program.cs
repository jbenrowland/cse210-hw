using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture[] scriptures = new Scripture[]
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
        // I added this to exceed requirements by randomizing which scripture it would choose to memorize from the list
        Random random = new Random();
        Scripture currentScripture = scriptures[random.Next(scriptures.Length)];

        while (true)
        {
            Console.Clear();
            currentScripture.Display();

            if (currentScripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words have been hidden. The program will now exit.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide a random word, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input != null && input.ToLower() == "quit")
            {
                break;
            }

            currentScripture.HideRandomWord();
        }

        Console.WriteLine("Thanks for using the Scripture Memorizer!");
    }
}