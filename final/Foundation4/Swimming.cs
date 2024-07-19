namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        public int Laps { get; private set; }

        public Swimming(DateTime date, int lengthInMinutes, int laps)
            : base(date, lengthInMinutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return Laps * 50 / 1000.0 * 0.62; // converting meters to miles
        }

        public override double GetSpeed()
        {
            return (GetDistance() / LengthInMinutes) * 60;
        }

        public override double GetPace()
        {
            return LengthInMinutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{Date.ToShortDateString()} Swimming ({LengthInMinutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
