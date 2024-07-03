using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RunBreathingActivity();
                    break;
                case 2:
                    RunReflectionActivity();
                    break;
                case 3:
                    RunListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        SetDuration(breathingActivity);
        breathingActivity.StartActivity();
    }

    static void RunReflectionActivity()
    {
        ReflectingActivity reflectionActivity = new ReflectingActivity();
        SetDuration(reflectionActivity);
        reflectionActivity.StartActivity();
    }

    static void RunListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        SetDuration(listingActivity);
        listingActivity.StartActivity();
    }

    static void SetDuration(BaseActivity activity)
    {
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        activity.Duration = duration;
    }
}