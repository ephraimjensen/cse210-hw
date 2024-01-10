using System;

class Program
{
    static void Main(string[] args)
    {
        string fName;
        string lName;

        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        fName = Console.ReadLine();
        Console.Write("What is your last name? ");
        lName = Console.ReadLine();

        Console.WriteLine($"Your name is {lName}, {fName} {lName}");

    }
}