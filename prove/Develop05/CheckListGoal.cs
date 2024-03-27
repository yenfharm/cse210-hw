public class ChecklistGoal : Goal
{
    // Added CompletedCount and RequiredCount properties
    public int CompletedCount { get; private set; }
    public int RequiredCount { get; private set; }

    // Constructor
    public ChecklistGoal(string name, int value, int requiredCount) : base(name, value)
    {
        RequiredCount = requiredCount;
        CompletedCount = 0;
    }

    // Implementation of Complete method
    public override void Complete()
    {
        CompletedCount++;

        Console.WriteLine($"Checklist goal: {Name} (+{Value} points)");

        if (CompletedCount == RequiredCount)
        {
            Console.WriteLine($"Bonus: Goal '{Name}' completed {RequiredCount} times! (+{Value} points)");
            Completed = true;
        }
    }
}