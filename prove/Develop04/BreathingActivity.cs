public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.") { }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);

        Console.WriteLine(_description);
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000); 

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine((i % 2 == 0) ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(5000); 
        }

        base.EndActivity();
    }
}