using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        // ask for a number once 
        // Console.WriteLine("What is your magic number?");
        // int magicNumber = int.Parse(Console.ReadLine());
        // start a loop that checks if userInput == magicNumber
        int userInput = -99999999;

        // create a random number between 0 and 100
        Random rand = new Random();
        int magicNumber = rand.Next(1, 101);

        do
        {
            // get a guess from the user
            Console.WriteLine("What is your guess?");
            userInput = int.Parse(Console.ReadLine());

            // check if the guess is greater than magicNumber
            if (userInput > magicNumber)
            {
                Console.WriteLine("The magic number is lower than your guess");
            }
            // check if the guess is less than the magicNumber
            else if (userInput < magicNumber)
            {
                Console.WriteLine("The magic number is higher than your guess");
            }
            // check if the guess is equal to the magicNumber
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }


        } while (magicNumber != userInput);



    }
}