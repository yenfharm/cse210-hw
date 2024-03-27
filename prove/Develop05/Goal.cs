public abstract class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool Completed { get; set; }

    // Constructor
    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Completed = false;
    }

    // Abstract method to handle goal completion
    public abstract void Complete();
}