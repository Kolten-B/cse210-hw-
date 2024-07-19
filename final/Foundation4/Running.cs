namespace ExerciseTracking
{
    public class Running : Activity
    {
        public double Distance { get; private set; } // in miles

        public Running(DateTime date, int lengthInMinutes, double distance)
            : base(date, lengthInMinutes)
        {
            Distance = distance;
        }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return (Distance / LengthInMinutes) * 60;
        }

        public override double GetPace()
        {
            return LengthInMinutes / Distance;
        }
    }
}
