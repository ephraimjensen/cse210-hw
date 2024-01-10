using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradeNumber = int.Parse(userInput);
        string letter = "grade goes here";
        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else if (gradeNumber < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congrats on passing the class!!!");
        }
        else
        {
            Console.WriteLine("You failed. Better luck next time");
        }
    }
}