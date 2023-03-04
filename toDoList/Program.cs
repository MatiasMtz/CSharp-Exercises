using System;

class Program
{
    static void Main(string[] args)
    {
        bool program = true;
        Console.Clear();
        Task.deserializeList();
        while (program)
        {
            displayMenu();
            Console.WriteLine();
            int command = 0;

            try
            {
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Console.Clear();
                        Task.addTask();
                        break;
                    case 2:
                        Console.Clear();
                        Task.viewAllTasks();
                        break;
                    case 3:
                        Console.Clear();
                        Task.deleteTask();
                        break;
                    case 4:
                        Task.serializeList();
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Please select an option between 1 and 4");
                        break;
                }
            }
            catch (FormatException)
            {
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

    //Console.WriteLine(File.ReadAllText(fileName));
}
