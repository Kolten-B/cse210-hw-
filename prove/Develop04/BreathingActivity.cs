using System;
using System.Threading;

public class BreathingActivity : BaseActivity
{
    private const string Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public BreathingActivity() : base("Breathing")
    {
        //Can add extra things if needed here now.
    }

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine(Description);
        Console.WriteLine($"Duration of activity: {Duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
    }

    protected override void PerformActivity()
    {
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000); 
        }
    }

    protected override void DisplayEndingMessage()
    {
         Console.WriteLine($"Good job! You've completed the {ActivityName} Activity for {Duration} seconds.");
    }
    
}
