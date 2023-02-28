using System;
class Task
{
	public int taskId { get; }
	public string taskName { get; set; } = string.Empty;
	public string description { get; set; } = string.Empty;
	public DateTime date { get; set; }

	// empty constructor
	public Task() {
	}
}