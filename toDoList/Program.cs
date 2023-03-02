using System;
class Program
{
	static void Main(string[] args)
	{
		bool program = true;
		Console.Clear();
		while (program)
		{
			displayMenu();
			Console.WriteLine();
			int command = 0;
			
			try {
				command = Convert.ToInt32(Console.ReadLine());
				switch (command) {
					case 1:
						Console.Clear();
						addTask();
						break;
					case 2:
						Console.Clear();
					    viewAllTasks();
						break;
					case 3:
						Console.Clear();
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
                Console.WriteLine("Your input is not a number between 1 and 4.");
				continue;
            }			
		}
	}

	static void displayMenu()
	{
		char space = (char)32;
		Console.WriteLine();
		Console.WriteLine("TO-DO LIST MENU\n");
		Console.WriteLine($"{space}{space}(1) Add task");
		Console.WriteLine($"{space}{space}(2) View all tasks");
		Console.WriteLine($"{space}{space}(3) Delete task");
		Console.WriteLine($"{space}{space}(4) Quit program\n");
		Console.Write("Enter your choice: ");
	}

	static void addTask()
    {
		// Due date format depends on the current region.
		Task task = new Task();

		Console.WriteLine("Enter your task name: ");
		task.taskName = Console.ReadLine();

		Console.WriteLine("Enter your task description: ");
		task.taskDescription = Console.ReadLine();

		Console.WriteLine("Enter your task due date: (DD-MM-YYYY)");
		task.taskDueDate = DateTime.Parse(Console.ReadLine());

		GlobalStorage.taskList.Add(task);
		Console.WriteLine();
		Console.WriteLine("Task added successfully");
	}
	static void viewAllTasks()
    {
		string column1 = "TASK NAME";
		string column2 = "TASK DESCRIPTION";
		string column3 = "TASK DUEDATE";
		Console.WriteLine($"| {column1, -50} | {column2, -50} | {column3, -20} |");

		foreach(Task task in GlobalStorage.taskList) {
			Console.WriteLine($"| {task.taskName, -50} | {task.taskDescription, -50} | {task.taskDueDate.ToString("dd/MM/yyyy"), -20} |");
		}
		Console.WriteLine();
	}

	static void deleteTask()
    {
		viewAllTasks();
		Console.WriteLine("Enter the TASK NAME to be deleted");
		string taskName = Console.ReadLine();
		foreach (Task task in GlobalStorage.taskList) {
			if (task.taskName.Equals(taskName)) {
				GlobalStorage.taskList.Remove(task); 
                Console.WriteLine("Task deleted successfully");
                break;
            }
			else {
				Console.WriteLine("Task not found\n");
			}
		}
	}
}