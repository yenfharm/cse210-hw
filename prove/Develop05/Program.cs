using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        List<Goal> goals = new List<Goal>
        {
            new SimpleGoal("Run a marathon", 1000),
            new EternalGoal("Read scriptures", 100),
            new ChecklistGoal("Attend the temple", 50, 10)
        };

        Console.WriteLine("Welcome to the Eternal Quest Program!");

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Add New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewGoals(goals);
                    break;
                case 2:
                    AddGoal(goals);
                    break;
                case 3:
                    RecordEvent(goals);
                    break;
                case 4:
                    ViewScore(goals);
                    break;
                case 5:
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to view goals
    static void ViewGoals(List<Goal> goals)
    {
        Console.WriteLine("\nCurrent Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.Name} - {(goal.Completed ? "[X]" : "[ ]")}");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"   Completed {checklistGoal.CompletedCount}/{checklistGoal.RequiredCount} times");
            }
        }
    }

    // Method to add a new goal
    static void AddGoal(List<Goal> goals)
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal type (1. Simple, 2. Eternal, 3. Checklist):");
        int type = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter point value:");
        int value = int.Parse(Console.ReadLine());

        Goal goal;

        switch (type)
        {
            case 1:
                goal = new SimpleGoal(name, value);
                break;
            case 2:
                goal = new EternalGoal(name, value);
                break;
            case 3:
                Console.WriteLine("Enter required completion count:");
                int requiredCount = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, value, requiredCount);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goals.Add(goal);
        Console.WriteLine($"Goal '{name}' added!");
    }

    // Method to record an event for a goal
    static void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("Enter the name of the goal you completed:");
        string goalName = Console.ReadLine();

        Goal goal = goals.Find(g => g.Name == goalName);

        if (goal != null)
        {
            goal.Complete();
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    // Method to view the user's score
    static void ViewScore(List<Goal> goals)
    {
        int score = 0;

        foreach (var goal in goals)
        {
            if (goal.Completed)
            {
                score += goal.Value;
            }
        }

        Console.WriteLine($"Current Score: {score} points");
    }
}