public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void StartActivity(int duration)
    {
        _duration = duration;
        Console.WriteLine($"Starting {_name}...");
        Thread.Sleep(2000); 
    }

    public virtual void EndActivity()
    {
        Console.WriteLine($"You've completed {_name} for {_duration} seconds.");
        Console.WriteLine("Good job!");
        Thread.Sleep(2000); 
    }
}