class ListingActivity : Activity
    {
        public ListingActivity() : base("Listing Activity", "List things that make you happy. Type 'done' to finish.", 10)
        { }

        public override void Run()
        {
            base.Run();
            string[] items = new string[10];
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
