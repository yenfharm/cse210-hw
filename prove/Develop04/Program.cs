using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.StartActivity(60); 
                break;
            case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.StartActivity(120); 
                break;
            case 3:
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.StartActivity(180); 
                break;
            case 4:
                Console.WriteLine("See you then");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}