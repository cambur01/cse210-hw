using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");

        Journal theJournal = new Journal();

        bool running = true;

        while (running == true)
        {
            Console.WriteLine("");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry anEntry = new Entry();
                theJournal.AddEntry(anEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                theJournal.SaveToFile("journal.txt");
            }
            else if (choice == "4")
            {
                theJournal.LoadFromFile("journal.txt");
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
        
    }
}