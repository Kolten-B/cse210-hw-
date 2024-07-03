using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Option 1: Make the _studentName protected in the base class
        // Option 2: Use a getter method from the base class
        // Here we will assume _studentName is protected in the base class
        return $"{_title} by {GetSummary().Split(" - ")[0]}";
    }
}
