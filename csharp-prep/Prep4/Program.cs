using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> myInts = new List<int>();
        var otherInts = new List<int>();


        // add items to list
        Console.WriteLine("Enter a List of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int userNumber = int.Parse(Console.ReadLine());

        do
        {
            myInts.Add(userNumber);
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
        } while (userNumber != 0);

        int largest = 0;
        int sum = 0;

        foreach (int i in myInts)
        {

            if (i > largest)
            {
                largest = i;
            };

            sum += i;




        }
        int theSum = sum;
        float theAverage = ((float)sum) / myInts.Count();
        int theMaximum = largest;

        Console.WriteLine($"The sum is: {theSum}");
        Console.WriteLine($"The average is: {theAverage}");
        Console.WriteLine($"The maximum is: {theMaximum}");
    }
}