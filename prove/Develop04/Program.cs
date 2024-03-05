
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        static void Menu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();

                // display the menu options
                Console.WriteLine("Menu Options: \n\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit\nSelect a choice from the menu: ");
                // get the user input
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Breathing b = new Breathing("Breathing", 30, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    b.TimeSetter(b.DisplayActivityDescription());

                    b.Breathe();

                }
                else if (userInput == "2")
                {
                    Reflection r = new Reflection("Reflection", 30, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    r.TimeSetter(r.DisplayActivityDescription());

                    r.Reflect();
                }
                else if (userInput == "3")
                {
                    Listing l = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30);
                    l.TimeSetter(l.DisplayActivityDescription());
                    l.Enumerate();
                }
                else if (userInput == "4")
                {
                    keepGoing = false;

                }

            }

        }

        Menu();

    }
}