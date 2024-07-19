using System;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            Running running = new Running(new DateTime(2024, 7, 15), 30, 3.0); // 3 miles
            Cycling cycling = new Cycling(new DateTime(2024, 7, 16), 45, 15.0); // 15 mph
            Swimming swimming = new Swimming(new DateTime(2024, 7, 17), 20, 40); // 40 laps

            // List of activities
            Activity[] activities = new Activity[] { running, cycling, swimming };

            // Display activity summaries
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
