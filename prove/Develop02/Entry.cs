

public class Entry
{
    //attributes
    public string response;
    public string prompt;
    public string date;




    //Behaviors


    public Entry(string response, string prompt, string date)
    {
        this.response = response;
        this.prompt = prompt;
        this.date = date;


    }

    public Entry(string fromFile)
    {
        var parts = fromFile.Split("+/~|~/+");
        this.response = parts[0];
        this.prompt = parts[1];
        this.date = parts[2];

    }
    public string EntryToString()
    {
        return $"{response}+/~|~/+{prompt}+/~|~/+{date}";
    }
    public string DisplayString()
    {
        return $"Date: {date} - Prompt: {prompt} \n{response}\n";

    }

}