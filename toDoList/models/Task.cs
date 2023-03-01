using System;
class Task
{
	public int taskID;
	public string taskName;
	public string taskDescription; 
	public DateTime taskDueDate;

	// empty constructor
	public Task(string name, string desc, DateTime date) {
		taskName = name;
		taskDescription = desc;
		taskDueDate = date;
	}
}