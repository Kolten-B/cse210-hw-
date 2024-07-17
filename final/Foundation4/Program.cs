using System;

namespace TaskManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            UserInterface ui = new UserInterface(taskManager);
            ui.DisplayMenu();
        }
    }
}
