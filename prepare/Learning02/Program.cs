using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2018;


        Job job2 = new Job();
        job2._jobTitle = "Consultant";
        job2._company = "IBM";
        job2._startYear = 2018;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();
        Console.WriteLine();

        Resume myResume = new Resume();
        myResume._name = "Paulo B";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}