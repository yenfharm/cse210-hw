public class ListingActivity : Activity
{
    private string[] _prompts = new[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);

        Console.WriteLine(_description);

        var random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(randomPrompt);

        Console.WriteLine("You have {0} seconds to list as many items as you can.", duration);

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i % animationStrings.Count];
            Console.Write($"{s}\b");
            Thread.Sleep(500);
            i++;
        }

        Console.WriteLine("\nStart listing items (press Enter after each item):");

        List<string> itemsListed = new List<string>();
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemsListed.Add(item);
                Console.WriteLine("Item added: " + item);
            }
        }
        foreach (var item in itemsListed)
        {
            Console.WriteLine("- " + item);
        }

        base.EndActivity();
    }
}