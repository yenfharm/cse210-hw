using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Development";
        job1._company = "Google";
        job1._startYear = 2013;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Designer";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Yenfhael Armas";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}