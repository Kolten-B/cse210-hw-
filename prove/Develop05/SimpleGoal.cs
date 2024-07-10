using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        IsComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{Points},{IsComplete}";
    }
}
