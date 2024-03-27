public class SimpleGoal : Goal
{
    // Constructor
    public SimpleGoal(string name, int value) : base(name, value) { }

    // Implementation of Complete method
    public override void Complete()
    {
        if (!Completed)
        {
            Console.WriteLine($"Goal completed: {Name} (+{Value} points)");
            Completed = true;
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' was already completed.");
        }
    }
}