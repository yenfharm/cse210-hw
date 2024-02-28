using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string percentage = Console.ReadLine();

        int x = int.Parse(percentage);

        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }

        else if (x >= 80)
        {
            letter = "B";
        }

        else if (x >= 70)
        {
            letter = "C";
        }

        else if (x >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter is {letter}");

        if (x >= 70)
        {
            Console.WriteLine("--> Great, you passed the course <--");
        }
        else 
        {
            Console.WriteLine("--> Don't give up, you can do it better next time <--");
        }

    }
}