using System;
using System.Threading;

public class ReflectingActivity : BaseActivity
{
        private static readonly string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
          private static readonly string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };
    
    public ReflectingActivity() : base("Reflecting")
    {
        // Additional setup to Reflecting Activity if needed
    }

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Prepare for reflection...");
        Console.WriteLine($"Duration of activity: {Duration} seconds.");
        Thread.Sleep(2000); 
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");

        foreach (string question in Questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000); 
        }
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You've completed the {ActivityName} Activity for {Duration} seconds.");
    }
}