


class Program
{
    static void Main(string[] args)
    {


        string helaman = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
        Reference hel5 = new Reference("Helaman 5:12");
        // hel5.Display();
        Scripture scriptureWords = new Scripture(helaman);
        bool keepGoing = true;
        while (keepGoing)
        {

            Console.Clear();
            hel5.Display();
            scriptureWords.Display();


            string userChoice = GetUserInput();
            if (userChoice == "quit")
            {
                keepGoing = false;
            }
            else if (scriptureWords.CheckIfDone())
            {
                keepGoing = false;
            }
            else
            {
                keepGoing = true;
                scriptureWords.HideWords();
            }



        }

        static string GetUserInput()
        {
            Console.WriteLine("\n\nType 'quit' to quit. Press enter to continue");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                return "quit";
            }

            else
            {
                return "";



            }
        }

    }

}