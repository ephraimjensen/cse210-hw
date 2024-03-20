public class Simple : Goal
{
    public Simple(string goalTitle, string goalDescription, int goalPoints, bool complete) : base(goalTitle, goalDescription, goalPoints, complete)
    {

    }
    public override void ExportToFile(string filename, bool overwrite)
    {
        string delimeter = "_/-=++=-\\_";
        using (StreamWriter outputFile = new StreamWriter(filename, overwrite))
        {
            outputFile.WriteLine($"SimpleGoal{delimeter}{goalTitle}{delimeter}{goalDescription}{delimeter}{goalPoints}{delimeter}{complete}");
        }
    }


}