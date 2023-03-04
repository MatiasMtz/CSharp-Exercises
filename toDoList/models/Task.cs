using System;
using System.Text.Json;
public class Task
{
	private static List<Task> taskList = new List<Task>();

	public string taskName { get; set; }
	public string taskDescription { get; set; }
	public DateTime taskDueDate { get; set; }

	public Task() {
	}

	public static void addTask()
	{
		// Due date format depends on the current region.
		Task task = new Task();

		Console.WriteLine("Enter your task name: ");
		string? taskName = Console.ReadLine();
		while (string.IsNullOrEmpty(taskName))
		{
			Console.WriteLine("Task name can't be empty! Input your name once more");
			taskName = Console.ReadLine();
		}
		task.taskName = taskName;

		Console.WriteLine("Enter your task description: (optional)");
		string? taskDescription = Console.ReadLine();
		if (string.IsNullOrEmpty(taskDescription)) {
			task.taskDescription = "*";
		}
		else {
			task.taskDescription = taskDescription;
		}

		Console.WriteLine("Enter your task due date: (DD-MM-YYYY)");
		DateTime? taskDueDate = DateTime.Parse(Console.ReadLine());
		while (taskDueDate == null)
		{
			Console.WriteLine("Task due date can't be empty! Input your task due date once more");
			taskName = Console.ReadLine();
		}
		task.taskDueDate = (DateTime)taskDueDate;

		taskList.Add(task);
		Console.WriteLine();
		Console.WriteLine("Task added successfully");
	}

	public static void viewAllTasks()
	{
		string column0 = "TASK No.";
		string column1 = "TASK NAME";
		string column2 = "TASK DESCRIPTION";
		string column3 = "TASK DUEDATE";
		
		Console.WriteLine($"| {column0, -10} | {column1,-50} | {column2,-50} | {column3,-20} |");
		int taskNo = 0;

		foreach (Task task in Task.taskList)
		{
			Console.WriteLine($"| {taskNo, -10} | {task.taskName,-50} | {task.taskDescription,-50} | {task.taskDueDate.ToString("dd/MM/yyyy"),-20} |");
			taskNo++;
		}
		Console.WriteLine();
	}

	public static void deleteTask()
	{
		viewAllTasks();
		Console.WriteLine("Enter the TASK No. to be deleted");
		int? taskNo = int.Parse(Console.ReadLine());
		while (taskNo == null)
		{
			Console.WriteLine("TASK No. can't be empty! Input your TASK No. once more");
			taskNo = int.Parse(Console.ReadLine());
		}
		if (taskNo <= Task.taskList.Count)
		{
			Task.taskList.RemoveAt((int)taskNo);
			Console.WriteLine("Task deleted successfully\n");
		}
		else
		{
			Console.WriteLine("Task not found\n");
		}
		viewAllTasks();
		Console.WriteLine();
	}

	public static void serializeList()
	{
		string fileName = "MyNotes.json";
		string jsonString = JsonSerializer.Serialize(Task.taskList);
		File.WriteAllText(fileName, jsonString);
	}

	public static void deserializeList()
	{
		string fileName = "MyNotes.json";
		string jsonString = File.ReadAllText(fileName);
		Task.taskList = JsonSerializer.Deserialize<List<Task>>(jsonString)!;
	}
}