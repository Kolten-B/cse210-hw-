using System;

public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }
    public bool IsComplete { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public abstract void RecordEvent();
    public virtual string GetShortName() => Name;
    public virtual string GetDetailsString() => $"{Name} - {Description}";
    public abstract string GetStringRepresentation();
}

