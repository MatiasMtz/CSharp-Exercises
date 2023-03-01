using System;
class Program
{
	static void Main(string[] args)
	{
		bool program = true;
		bool goBackMenu = false;
		displayMenu();
		while (program)
		{
			if (goBackMenu) 
			{
				displayMenu();
				goBackMenu = false;
			};
		    
			int command = 0;
			
			try {
				command = Convert.ToInt32(Console.ReadLine());
				switch (command) {
					case 1:
					    addTask();
						break;
					case 2:
					    viewAllTasks();
						break;
					case 3:
					    deleteTask();
						break;
					case 4:
						program = false;
						break;
					default: 
						Console.WriteLine("Please select an option between 1 and 4");
						break;
				}
			}
			catch (FormatException) {
                Console.WriteLine("Input is not a valid option.");
				continue;
            }			
			Console.WriteLine($"{command}");
		}
	}
	static void displayMenu()
	{
		char space = (char)32;
		Console.WriteLine();
		Console.WriteLine("TO-DO LIST MENU");
		Console.WriteLine();
		Console.WriteLine($"{space}{space}(1) Add task");
		Console.WriteLine($"{space}{space}(2) View all tasks");
		Console.WriteLine($"{space}{space}(3) Delete task");
		Console.WriteLine($"{space}{space}(4) Quit program");
		Console.WriteLine();
		Console.WriteLine("Enter your choice: ");
		Console.WriteLine();
	}

	static void addTask()
    {
		string taskName = "";
		string taskDescription = "";
		DateTime taskDueDate;

		Console.WriteLine("Enter your task name: ");
		taskName = Console.ReadLine();
		Console.WriteLine("Enter your task description: ");
		taskDescription = Console.ReadLine();
		Console.WriteLine("Enter your task due date: ");
		taskDueDate = DateTime.Parse(Console.ReadLine());

		Task task = new Task(taskName, taskDescription, taskDueDate);
		Console.WriteLine($"{task.taskName}, {task.taskDescription}, {task.taskDueDate}");
	}

	static void saveTasks(int taskId) {
	}

	static void viewAllTasks()
    {
		Console.WriteLine("VER TASKS");
	}

	static void deleteTask()
    {
        Console.WriteLine("Enter TaskID");
		try
		{
			int taskID = Convert.ToInt32(Console.ReadLine());
			// delete task or show error message (taskID not found)
		}
		catch (FormatException)
		{
			Console.WriteLine("TaskID must be a number");
	    }
	}
}