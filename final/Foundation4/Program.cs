using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycle = new Cycling(new DateTime(2022, 11, 4), 45, 15.0);
        Swimming swim = new Swimming(new DateTime(2022, 11, 5), 60, 20);

        Activity[] activities = new Activity[3];
        activities[0] = run;
        activities[1] = cycle;
        activities[2] = swim;

        for (int i = 0; i < activities.Length; i++)
        {
            Console.WriteLine(activities[i].GetSummary());
            Console.WriteLine();
        }
    }
}
