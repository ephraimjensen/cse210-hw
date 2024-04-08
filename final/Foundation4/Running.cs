class Running : Activity
{
    public Running(string date, float duration, float distance) : base(date, duration)
    {
        this.distance = distance;
    }
    float distance;
    string activityName = "Running";

    override public float GetDistance()
    {
        return distance;
    }
    public override string GetSummary()
    {
        string summaryString = $"{GetDate()} {activityName} ({(float)Math.Round(GetDuration(), 2)} minuites)- Distance {(float)Math.Round(GetDistance(), 2)} miles, Speed {(float)Math.Round(GetSpeed(), 2)} mph, Pace {(float)Math.Round(GetPace(), 2)} min per mile";
        return summaryString;
    }
}

//total = (float)Math.Round(total, 2)