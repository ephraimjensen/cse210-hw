public class Eternal : Goal
{
    public Eternal(string goalTitle, string goalDescription, int goalPoints, bool complete) : base(goalTitle, goalDescription, goalPoints, complete)
    {
        this.goalDescription = goalDescription;
        this.goalTitle = goalTitle;
        this.goalPoints = goalPoints;
        this.complete = false;
    }
    public override void ExportToFile(string filename, bool overwrite)
    {
        string delimeter = "_/-=++=-\\_";
        using (StreamWriter outputFile = new StreamWriter(filename, overwrite))
        {
            outputFile.WriteLine($"EternalGoal{delimeter}{goalTitle}{delimeter}{goalDescription}{delimeter}{goalPoints}{delimeter}{complete}");
        }
    }


    public override int RecordEvent()
    {

        complete = false;
        Console.WriteLine($"\n\nearend {goalPoints}\n\n");
        return goalPoints;
    }
}