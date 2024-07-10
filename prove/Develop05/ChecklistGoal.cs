using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonus;
    public int CurrentCount { get; private set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < _targetCount)
        {
            CurrentCount++;
            if (CurrentCount == _targetCount)
            {
                IsComplete = true;
            }
        }
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed {CurrentCount}/{_targetCount} times";
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public bool IsGoalComplete()
    {
        return CurrentCount >= _targetCount;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{CurrentCount},{_targetCount},{_bonus}";
    }
}
