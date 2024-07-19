using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        public DateTime Date { get; private set; }
        public int LengthInMinutes { get; private set; }

        public Activity(DateTime date, int lengthInMinutes)
        {
            Date = date;
            LengthInMinutes = lengthInMinutes;
        }

        public abstract double GetDistance(); // in miles or kilometers
        public abstract double GetSpeed(); // in miles per hour or kilometers per hour
        public abstract double GetPace(); // in minutes per mile or minutes per kilometer

        public virtual string GetSummary()
        {
            return $"{Date.ToShortDateString()} {GetType().Name} ({LengthInMinutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
