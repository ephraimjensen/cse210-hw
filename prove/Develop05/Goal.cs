using System.IO;
public class Goal
{
    protected string goalTitle;
    protected string goalDescription;
    protected int goalPoints;
    protected bool complete;

    public virtual void ExportToFile(string filename, bool overwrite)
    {
        string delimeter = "_/-=++=-\\_";
        using (StreamWriter outputFile = new StreamWriter(filename, overwrite))
        {
            outputFile.WriteLine($"GoalDefault{delimeter}{goalTitle}{delimeter}{goalDescription}{delimeter}{goalPoints}{delimeter}{complete}");
        }
    }

    public Goal(string goalTitle, string goalDescription, int goalPoints, bool complete)
    {
        this.goalTitle = goalTitle;
        this.goalDescription = goalDescription;
        this.goalPoints = goalPoints;
        this.complete = complete;
    }
    public virtual string DisplayGoal()
    {
        if (complete == true)
        {
            return $"[X] {goalTitle} ({goalDescription})";
        }
        else
        {
            return $"[ ] {goalTitle} ({goalDescription})";
        }

    }
    public virtual int RecordEvent()
    {
        if (complete == false)
        {
            complete = true;
            return goalPoints;
        }
        else { return 0; }


    }
    public string GetGoalTitle()
    {
        return goalTitle;
    }



}