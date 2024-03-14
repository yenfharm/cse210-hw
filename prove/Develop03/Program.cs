using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        Console.WriteLine($"Scripture: {scripture.GetReference()}\n");
        Console.WriteLine(scripture.GetVisibleText());
        bool messageDisplay = false;  
        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                messageDisplay = true;
                break;
            }

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine($"Scripture: {scripture.GetReference()}\n");
            Console.WriteLine(scripture.GetVisibleText());
        }

        
        if (!messageDisplay)
        {
            Console.WriteLine("\n All words are hidden. Memorization complete!");
        }
        else if (messageDisplay)
        {
            Console.WriteLine("\n You finish the game");
        }
    }
}