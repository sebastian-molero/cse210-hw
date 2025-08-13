using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity(new DateTime(2025, 7, 2), 30, 3);
        activities.Add(running);

        CyclingActivity cycling = new CyclingActivity(new DateTime(2025, 8, 11), 45, 15);
        activities.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity(new DateTime(2025, 8, 8), 60, 35);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}