using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    private void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                break;
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select a goal to record: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goal.Points;

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsGoalComplete())
            {
                _score += checklistGoal.GetBonus();
                Console.WriteLine("Congratulations! You have completed the checklist goal and earned a bonus!");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] details = parts[1].Split(',');

                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);

                switch (type)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(details[3]);
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        simpleGoal.GetType().GetProperty("IsComplete").SetValue(simpleGoal, isComplete);
                        _goals.Add(simpleGoal);
                        break;

                    case "EternalGoal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;

                    case "ChecklistGoal":
                        int currentCount = int.Parse(details[3]);
                        int targetCount = int.Parse(details[4]);
                        int bonus = int.Parse(details[5]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonus);
                        checklistGoal.GetType().GetProperty("CurrentCount").SetValue(checklistGoal, currentCount);
                        _goals.Add(checklistGoal);
                        break;

                    default:
                        Console.WriteLine("Unknown goal type in file.");
                        break;
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
