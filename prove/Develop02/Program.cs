using System;
class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        bool exit = false;
        Console.WriteLine("\nWelcome to the Journal Program");
        while (!exit)
        {   
            Console.WriteLine("\nPlease select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string promptPopUp = prompt.GetRandomPrompt();
                    Console.WriteLine(promptPopUp);
                    Console.WriteLine("\nEnter your response:");
                    string response = Console.ReadLine();
                    Console.WriteLine("\nEnter the date (e.g., 2023-10-03):");
                    string date = Console.ReadLine();
                    journal.AddEntry(promptPopUp, response, date);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("\nEnter the file name:");
                    string fileNameSave = Console.ReadLine();
                    journal.SaveJournalToFile(fileNameSave);
                    break;
                case 4:
                    Console.WriteLine("\nEnter the file name:");
                    string fileNameLoad = Console.ReadLine();
                    journal.LoadJournalFromFile(fileNameLoad);
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    break;
            }
        }
    }


}