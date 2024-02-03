using System.ComponentModel.DataAnnotations;

class Journal
{
    public Random rnd = new Random();

    public List<string> Prompts = new List<string>{
    "Who was the most interesting person I interacted with today?"
    ,"What was the best part of my day?"
    ,"How did I see the hand of the Lord in my life today?"
    ,"What was the strongest emotion I felt today?"
    ,"If I had one thing I could do over today, what would it be?"
    };
    public string GetDate()
    {
        string date = DateTime.Now.ToString().Substring(0, 10);
        return date;
    }

    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string[] importLines)
    {

        entries = new List<Entry>();
        foreach (var line in importLines)
        {

            var entry = new Entry(line);
            entries.Add(entry);
        }
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\nEntries:\n------------------");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.DisplayString());
        }
        Console.WriteLine("Press enter to contunue.");
        Console.ReadLine();
    }

    public string GetRandomPrompt()
    {
        int number = rnd.Next(1, 5);
        string promptChoice = Prompts[number];
        return promptChoice;
    }


    public string[] Export()
    {
        var exportThis = new List<string>();
        foreach (var entry in entries)
        {
            exportThis.Add(entry.EntryToString());
        }
        return exportThis.ToArray();
    }

    public void CreateNewEntry()
    {
        //get each
        var prompt = GetRandomPrompt();
        var date = GetDate();
        Console.WriteLine(prompt);
        Console.WriteLine("Enter your response: ");
        var response = Console.ReadLine();


        var entry = new Entry(response, prompt, date);

        entries.Add(entry);


    }




}