using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        bool keepGoing = true;
        List<Goal> Goals = new List<Goal>();
        while (keepGoing)
        {
            Console.WriteLine($"You have {points} points\n");
            DisplayMainMenu();

            string userResponse = GetUserResponse();

            if (userResponse == "1")
            {
                Console.WriteLine("The types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
                string goalType = GetUserResponse();
                if (goalType == "1")
                {
                    //simple
                    Console.WriteLine("Goal Title: ");
                    string name = GetUserResponse();
                    Console.WriteLine("Goal Description: ");
                    string description = GetUserResponse();
                    Console.WriteLine("Goal Points: ");
                    int goalPoints = int.Parse(GetUserResponse());
                    Simple s = new Simple(name, description, goalPoints, false);
                    Goals.Add(s);

                }
                if (goalType == "2")
                {
                    //Eternal
                    Console.WriteLine("Goal Title: ");
                    string name = GetUserResponse();
                    Console.WriteLine("Goal Description: ");
                    string description = GetUserResponse();
                    Console.WriteLine("Goal Points: ");
                    int goalPoints = int.Parse(GetUserResponse());
                    Eternal e = new Eternal(name, description, goalPoints, false);
                    Goals.Add(e);
                }
                if (goalType == "3")
                {
                    //Checklist
                    Console.WriteLine("Goal Title: ");
                    string name = GetUserResponse();
                    Console.WriteLine("Goal Description: ");
                    string description = GetUserResponse();
                    Console.WriteLine("Goal Points: ");
                    int goalPoints = int.Parse(GetUserResponse());
                    Console.WriteLine("Checklist Goal Bonus: ");
                    int bonus = int.Parse(GetUserResponse());
                    Console.WriteLine("How many times to complete goal for bonus: ");
                    int maxRepetitions = int.Parse(GetUserResponse());
                    int repetitionsDone = 0;

                    Checklist c = new Checklist(name, description, goalPoints, false, bonus, repetitionsDone, maxRepetitions);
                    Goals.Add(c);
                }
            }
            else if (userResponse == "2")
            {
                //list goals
                int counter = 1;
                Console.WriteLine("The goals are:");
                foreach (Goal goal in Goals)
                {

                    Console.WriteLine($"\t{counter}. {goal.DisplayGoal()}");
                    counter += 1;
                }
            }
            else if (userResponse == "3")
            {
                Console.WriteLine("What file should the goals save in: ");
                string filename = GetUserResponse();

                //save the number of points
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(points);
                }
                //save goals
                int counter = 0;
                bool dontOverwrite = true;
                foreach (Goal goal in Goals)
                {

                    goal.ExportToFile(filename, dontOverwrite);
                    counter += 1;
                }
            }
            else if (userResponse == "4")
            {
                //load goals
                Console.WriteLine("what is the file that you want to read from: ");
                string filename = GetUserResponse();
                Goals.Clear();

                string[] lines = System.IO.File.ReadAllLines(filename);
                string delimeter = "_/-=++=-\\_";

                foreach (string line in lines)
                {
                    string[] parts = line.Split(delimeter);

                    string typeOfGoal = parts[0];
                    if (typeOfGoal == "SimpleGoal")
                    {
                        //call simple constructor
                        Simple s = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        Goals.Add(s);
                    }
                    else if (typeOfGoal == "EternalGoal")
                    {
                        //call eternal constructor
                        Eternal e = new Eternal(parts[1], parts[2], int.Parse(parts[3]), false);
                        Goals.Add(e);
                    }
                    else if (typeOfGoal == "ChecklistGoal")
                    {
                        //call checklist constructor
                        //title, desc, points, complete, bonus, repDone, maxR
                        //title, desc, points, bonus, maxR, repDone
                        Checklist c = new Checklist(parts[1], parts[2], int.Parse(parts[3]), false, int.Parse(parts[4]), int.Parse(parts[6]), int.Parse(parts[5]));
                        Goals.Add(c);
                    }
                    else
                    {
                        points = int.Parse(parts[0]);
                    }

                }
            }
            else if (userResponse == "5")
            {
                //record event (complete goals)
                Console.WriteLine("The Goals are:\n");
                int counter = 0;
                foreach (Goal goal in Goals)
                {
                    counter += 1;

                    Console.WriteLine($"\t{counter}. {goal.GetGoalTitle()}");
                }
                Console.WriteLine("Which goal did you accomplish: ");
                string responseIndex = GetUserResponse();
                Goal userChoice = Goals[int.Parse(responseIndex) - 1];
                int pointsEarned = userChoice.RecordEvent();
                points += pointsEarned;
                Console.WriteLine($"Congrats! You earned {pointsEarned} points!");



            }
            else if (userResponse == "6")
            {
                keepGoing = false;
            }


        }
        string GetUserResponse()
        {
            string userResponse = Console.ReadLine();
            return userResponse;
        }

        void DisplayMainMenu()
        {
            Console.WriteLine("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
        }

    }
}