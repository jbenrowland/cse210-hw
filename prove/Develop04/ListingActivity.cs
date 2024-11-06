class ListingActivity
{
    public void Run()
    {
        Console.WriteLine("\nStarting Listing Activity...");
        Console.WriteLine("List things that make you happy (type 'done' to finish):");

        string[] items = new string[10]; // Fixed-size array for simplicity
        int count = 0;

        while (count < items.Length)
        {
            Console.Write("Enter item: ");
            string item = Console.ReadLine();

            if (item.ToLower() == "done") break;

            items[count] = item;
            count++;
        }

        Console.WriteLine("\nYou listed:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("- " + items[i]);
        }
        Console.WriteLine("Listing activity complete.");
    }
}
