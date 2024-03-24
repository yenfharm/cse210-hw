public class ReflectionActivity : Activity
{
    private string[] _prompts = new[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = new[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);

        Console.WriteLine(_description);

        var random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(randomPrompt);

        List <string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        

        foreach (var question in _questions)
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(120 / _questions.Length);

            int i = 0;
            Console.Write($"1){question}");
            while (DateTime.Now < endTime)

            {
                string s = animationStrings[i];
                Console.Write($"{s}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i++;

                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
            Console.WriteLine();
        }

        base.EndActivity();
    }
}