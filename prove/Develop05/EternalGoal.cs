public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, int value) : base(name, value) { }

    // Implementation of Complete method
    public override void Complete()
    {
        Console.WriteLine($"Eternal goal recorded: {Name} (+{Value} points)");
    }
}