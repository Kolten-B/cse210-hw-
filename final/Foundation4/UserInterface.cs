using System;

namespace TaskManagerApp
{
    public class UserInterface
    {
        private TaskManager taskManager;

        public UserInterface(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\nTask Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View All Tasks");
                Console.WriteLine("3. View Pending Tasks");
                Console.WriteLine("4. View Completed Tasks");
                Console.WriteLine("5. Mark Task as Complete");
                Console.WriteLine("6. Edit Task");
                Console.WriteLine("7. Delete Task");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        ViewAllTasks();
                        break;
                    case 3:
                        ViewPendingTasks();
                        break;
                    case 4:
                        ViewCompletedTasks();
                        break;
                    case 5:
                        MarkTaskAsComplete();
                        break;
                    case 6:
                        EditTask();
                        break;
                    case 7:
                        DeleteTask();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void AddTask()
        {
            Console.Write("Enter task name: ");
            string name = Console.ReadLine();

            Console.Write("Enter task description: ");
            string description = Console.ReadLine();

            Console.Write("Enter due date (MM/DD/YYYY): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter priority (1 = High, 2 = Medium, 3 = Low): ");
            int priority = int.Parse(Console.ReadLine());

            Task task = new Task(name, description, dueDate, priority);
            taskManager.AddTask(task);

            Console.WriteLine("Task added successfully!");
        }

        private void ViewAllTasks()
        {
            Console.WriteLine("\nAll Tasks:");
            foreach (var task in taskManager.GetAllTasks())
            {
                Console.WriteLine(task);
            }
        }

        private void ViewPendingTasks()
        {
            Console.WriteLine("\nPending Tasks:");
            foreach (var task in taskManager.GetPendingTasks())
            {
                Console.WriteLine(task);
            }
        }

        private void ViewCompletedTasks()
        {
            Console.WriteLine("\nCompleted Tasks:");
            foreach (var task in taskManager.GetCompletedTasks())
            {
                Console.WriteLine(task);
            }
        }

        private void MarkTaskAsComplete()
        {
            Console.Write("Enter the name of the task to mark as complete: ");
            string name = Console.ReadLine();

            Task task = taskManager.GetAllTasks().FirstOrDefault(t => t.Name == name);
            if (task != null)
            {
                task.MarkComplete();
                Console.WriteLine("Task marked as complete!");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        private void EditTask()
        {
            Console.Write("Enter the name of the task to edit: ");
            string name = Console.ReadLine();

            Task task = taskManager.GetAllTasks().FirstOrDefault(t => t.Name == name);
            if (task != null)
            {
                Console.Write("Enter new task name: ");
                string newName = Console.ReadLine();

                Console.Write("Enter new task description: ");
                string newDescription = Console.ReadLine();

                Console.Write("Enter new due date (MM/DD/YYYY): ");
                DateTime newDueDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter new priority (1 = High, 2 = Medium, 3 = Low): ");
                int newPriority = int.Parse(Console.ReadLine());

                task.Edit(newName, newDescription, newDueDate, newPriority);
                Console.WriteLine("Task edited successfully!");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        private void DeleteTask()
        {
            Console.Write("Enter the name of the task to delete: ");
            string name = Console.ReadLine();

            Task task = taskManager.GetAllTasks().FirstOrDefault(t => t.Name == name);
            if (task != null)
            {
                taskManager.RemoveTask(task);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }
    }
}
