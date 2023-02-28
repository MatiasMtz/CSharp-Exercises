## To Do List C#.

Console Application that allows users to manage a to-do list. The program should allow the user to add, view and remove tasks from their to-do list.

When the program starts, it should display a menu of options, such as:
- Add a new task.

If the user chooses to add a task, they should be prompted to enter the task description and due date. The task should then be added to the to-do list.

- View all tasks.

If the user selects to view all tasks, they should be shown a list of all the tasks currently in the to-do list, along with their due dates.

- Remove a task.

If the user choose to remove a task, they should be prompted to select the task to remove from the to-do list. Once the taks is removed, the updated task list should be displayed.

- Quit the program.

Ends the program.

- Additional features to implement:
	- Allow the user to sort tasks by due date or by priority.
	- Allow the user to mark tasks as completed.
	- Allow the user to edit the description or due date of a task.

Class hierarchy example:
-- Task 

-- RecurringTask (This class will represent a recurring task entity, with properties and methods to handle recurring tasks.) 

-- PriorityTask (This class will represent a priority task entity, with properties and methods to handle priority tasks).