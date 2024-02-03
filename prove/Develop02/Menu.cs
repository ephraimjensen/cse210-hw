

public class Menu
{
    List<string> options = new List<string> { "Write", "Display", "Save", "Load", "Quit" };

    Journal journal = new Journal();


    public bool RunMenu()
    {
        Display();
        var userChoice = GetUserChoice();
        return RunUserChoice(userChoice);
    }
    void Display()
    {
        Console.WriteLine("Please Select One of the Following Options:");
        var count = 1;
        foreach (var option in options)
        {

            Console.WriteLine($"{count}. {option}");
            count += 1;
        }
        Console.Write("What would you like to do? ");
    }

    string GetUserChoice()
    {
        string userChoice = Console.ReadLine();
        return userChoice;
    }

    bool RunUserChoice(string userChoice)
    {
        Console.Clear();
        if (userChoice == "1")
        {//add entry

            journal.CreateNewEntry();

            return true;
        }
        else if (userChoice == "2")
        {//list entries
            journal.DisplayEntries();

            return true;
        }
        else if (userChoice == "3")
        {// save entries
            var lines = journal.Export();
            WriteToFile(lines);

            return true;
        }
        else if (userChoice == "4")
        {//load entries

            var lines = ReadFromFile();
            journal = new Journal(lines);

            return true;
        }
        else if (userChoice == "5")
        {//exit
            return false;

        }
        else
        {
            return true;
        }


    }

    public void WriteToFile(string[] lines)
    {
        Console.WriteLine("Write to what filename: ");
        var fileName = Console.ReadLine();

        File.WriteAllLines(fileName, lines);


    }
    public string[] ReadFromFile()
    {
        Console.WriteLine("Read from what filename: ");
        var fileName = Console.ReadLine();

        return System.IO.File.ReadAllLines(fileName);
    }
}
