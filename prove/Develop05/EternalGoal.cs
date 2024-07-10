using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals are never fully complete, so this is empty
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{Points}";
    }
}
