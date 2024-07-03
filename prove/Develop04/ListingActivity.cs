using System;
using System.Threading;

public class ListingActivity : BaseActivity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt at peace recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing")
    {
        // Additional setup to Listing Activity if needed
    }

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Prepare for listing...");
        Console.WriteLine($"Duration of activity: {Duration} seconds.");
        Thread.Sleep(2000); 
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        Thread.Sleep(5000); 
        int itemsCount = random.Next(5, 10); 
        Console.WriteLine($"You listed {itemsCount} items.");
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You've completed the {ActivityName} Activity for {Duration} seconds.");
    }
}