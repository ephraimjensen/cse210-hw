public class Checklist : Goal
{
    int repetitionsDone;
    int maxRepetitions;
    int bonus;
    public Checklist(string goalTitle, string goalDescription, int goalPoints, bool complete, int bonus, int repetitionsDone, int maxRepetitions) : base(goalTitle, goalDescription, goalPoints, complete)
    {

        this.repetitionsDone = repetitionsDone;
        this.maxRepetitions = maxRepetitions;
        this.bonus = bonus;
        this.complete = false;
        if (maxRepetitions == repetitionsDone)
        {
            this.complete = true;
        }
    }
    public override string DisplayGoal()
    {
        if (complete == true)
        {
            return $"[X] {goalTitle} ({goalDescription}) -- Currently completed: {repetitionsDone}/{maxRepetitions}";
        }
        else
        {
            return $"[ ] {goalTitle} ({goalDescription}) -- Currently completed: {repetitionsDone}/{maxRepetitions}";
        }
    }
    public override void ExportToFile(string filename, bool overwrite)
    {
        string delimeter = "_/-=++=-\\_";
        using (StreamWriter outputFile = new StreamWriter(filename, overwrite))
        {
            outputFile.WriteLine($"ChecklistGoal{delimeter}{goalTitle}{delimeter}{goalDescription}{delimeter}{goalPoints}{delimeter}{bonus}{delimeter}{maxRepetitions}{delimeter}{repetitionsDone}");
        }
    }

    public override int RecordEvent()
    {
        if (complete == false)
        {
            if (repetitionsDone < maxRepetitions)
            {
                repetitionsDone += 1;
            }
            if (repetitionsDone == maxRepetitions)
            {
                complete = true;
            }
            if (repetitionsDone == maxRepetitions)
            {
                return goalPoints + bonus;

            }
            else
            {
                return goalPoints;
            }

        }
        else
        {
            return 0;
        }
    }

}