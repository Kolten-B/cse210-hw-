using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagerApp
{
    public class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public List<Task> GetAllTasks()
        {
            return tasks;
        }

        public List<Task> GetPendingTasks()
        {
            return tasks.Where(t => !t.IsComplete).ToList();
        }

        public List<Task> GetCompletedTasks()
        {
            return tasks.Where(t => t.IsComplete).ToList();
        }

        public List<Task> GetTasksByPriority(int priority)
        {
            return tasks.Where(t => t.Priority == priority).ToList();
        }

        public List<Task> GetTasksByDueDate(DateTime dueDate)
        {
            return tasks.Where(t => t.DueDate.Date == dueDate.Date).ToList();
        }
    }
}
