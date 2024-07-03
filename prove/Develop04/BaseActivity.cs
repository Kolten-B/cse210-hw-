using System;
using System.Threading;

public abstract class BaseActivity
{
    protected string ActivityName { get; set; }
    public int Duration { get; set; }

    public BaseActivity(string activityName)
    {
        ActivityName = activityName;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {ActivityName} Activity...");
        DisplayStartingMessage();
        Thread.Sleep(3000); 
        PerformActivity();
        DisplayEndingMessage();
        Thread.Sleep(3000); 
    }

    protected abstract void DisplayStartingMessage();

    protected abstract void PerformActivity();

    protected abstract void DisplayEndingMessage();
}
