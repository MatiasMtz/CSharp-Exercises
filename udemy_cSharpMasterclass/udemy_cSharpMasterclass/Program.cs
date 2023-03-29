using System;
using System.Diagnostics.Metrics;

class Program
{
    
    // Chapter 3 - Methods | Functions
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
    }
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