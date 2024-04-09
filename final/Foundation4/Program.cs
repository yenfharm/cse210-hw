using System;
using System.Collections.Generic;

class Activity
{
    protected DateTime date;
    protected int lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without distance
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without speed
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without pace
    }

    public string GetSummary()
    {
        return $"{date.ToShortDateString()} {GetType().Name} ({lengthMinutes} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

class Running : Activity
{
    private double distance;

    public Running(DateTime date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / lengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return lengthMinutes / distance;
    }
}

class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return (speed * lengthMinutes) / 60;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}

class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / lengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return lengthMinutes / GetDistance();
    }
}

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 20.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}