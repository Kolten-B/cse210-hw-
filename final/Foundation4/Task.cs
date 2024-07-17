using System;

namespace TaskManagerApp
{
    public class Task
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public int Priority { get; private set; } // 1 = High, 2 = Medium, 3 = Low
        public bool IsComplete { get; private set; }

        public Task(string name, string description, DateTime dueDate, int priority)
        {
            Name = name;
            Description = description;
            DueDate = dueDate;
            Priority = priority;
            IsComplete = false;
        }

        public void MarkComplete()
        {
            IsComplete = true;
        }

        public void Edit(string name, string description, DateTime dueDate, int priority)
        {
            Name = name;
            Description = description;
            DueDate = dueDate;
            Priority = priority;
        }

        public override string ToString()
        {
            string priorityString = Priority == 1 ? "High" : Priority == 2 ? "Medium" : "Low";
            return $"[{priorityString}] {Name} - {Description} (Due: {DueDate.ToShortDateString()}, {(IsComplete ? "Completed" : "Pending")})";
        }
    }
}
