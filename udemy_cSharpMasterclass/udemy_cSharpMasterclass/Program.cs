using System;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;

class Program
{
    // Chapter 5 - Loops
    static void Main(string[] args) 
    {
        float scoreCounter = 0;
        int iterations = 0;
        int input;

        while (true)
        {
            Console.Write("Enter the student score or -1 when you are ready: ");
            bool success = int.TryParse(Console.ReadLine(), out input);
            if (success)
            {
                if (input == -1)
                    break;
                else
                {
                    scoreCounter += input;
                    iterations++;
                }
            }
        }
        Console.WriteLine($"The average score of your students is: {scoreCounter / iterations}");
        Console.Read();
    }
    
    // Chapter 4 - If statements
    static void temperatureCheck(string[] args)
    {
        Console.Write("Please, enter the temperature: ");
        string userInput = Console.ReadLine();
        string output = "";

        if (int.TryParse(userInput, out int temperature))
        {
            output = temperature <= 15 ? "it is too cold here" : temperature >= 16 && temperature <= 28 ? "it is ok" : "it is hot here";
            Console.WriteLine(output);
        }
        else
            Console.WriteLine("Not a valid Temperature");
    }

    static void CheckHighscore(string playerName, int score)
    {
        // Highscore and highscorePlayer should be a global var.
        int highscore = 2000;
        string highscorePlayer = "aleekei";

        if (score > highscore)
        {
            highscore = score;
            highscorePlayer = playerName;
            Console.WriteLine($"New highscore is {highscore}");
            Console.WriteLine($"New highscore holder is {playerName}");
        }
        else
        {
            Console.WriteLine($"The old highscore of {highscore} could not be broken and is still held by {highscorePlayer}");
        }
    }

    // Chapter 3 - Methods | Functions
    static void GreetFriend(string friendName1, string friendName2, string friendName3)
    {
        /* Main method:
        static string alex = "Alex";
        static string guille = "Guillermo";
        static string axel = "Axel";
        GreetFriend(alex, guille, axel);
        */

        Console.WriteLine($"Hi {friendName1}, my friend!");
        Console.WriteLine($"Hi {friendName2}, my friend!");
        Console.WriteLine($"Hi {friendName3}, my friend!");
    }

    // Chapter 2 - Datatypes and variables
    static void Datatypes(string[] args)
    {
        // Datatypes
        byte myByte = 254;
        Console.WriteLine(myByte);
        sbyte mySByte = 127;
        Console.WriteLine(mySByte);
        int myInt = 0;
        Console.WriteLine(myInt);
        uint myUInt = 4294967295;
        Console.WriteLine(myUInt);
        short myShort = 32767;
        Console.WriteLine(myShort);
        ushort myUShort = 65535;
        Console.WriteLine(myUShort);
        long myLong = 9223372036854775807;
        Console.WriteLine(myLong);
        ulong myULong = 18446744073709551615;
        Console.WriteLine(myULong);
        float myFloat = 3.402823e38f;
        Console.WriteLine(myFloat);
        double myDouble = 1.79769313486232e307;
        Console.WriteLine(myDouble);
        decimal myDecimal = 0;
        Console.WriteLine(myDecimal);
        char myChar = 'a';
        Console.WriteLine(myChar);
        bool myBool = false;
        Console.WriteLine(myBool);
        string myString = "This is a string";
        Console.WriteLine(myString);

        // Int parse
        string value1 = "I control text";
        string value2 = "123789";

        myInt = int.Parse(value2);
        Console.WriteLine(myInt);
    }
    static void InputManipulation(string[] args)
    {
        // find the index of the first occurrence in a string
        Console.Write("Enter a string here: ");
        string userString = Console.ReadLine();
        Console.Write("Enter the character to search: ");
        string search = Console.ReadLine();
        Console.WriteLine($"Character/s found at index: {userString.IndexOf(search)}");

        // print full name
        Console.Write("Enter your first name here: ");
        string firstname = Console.ReadLine();
        Console.Write("Enter your last name here: ");
        string lastname = Console.ReadLine();
        string fullname = firstname + " " + lastname;
        Console.WriteLine($"Your full name is: {fullname}");
    }
    static void StringMethods(string[] args)
    {
        string username = "";
        Console.WriteLine("Please enter your name and press enter.");
        username = Console.ReadLine();

        Console.WriteLine($"UPPERCASE: {username.ToUpper()}");
        Console.WriteLine($"LOWERCASE: {username.ToLower()}");
        Console.WriteLine($"TRIMMED: {username.Trim()}");
        Console.WriteLine($"SUBSTR: {username.Substring(2)}");
    }
}