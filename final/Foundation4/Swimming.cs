class Swimming : Activity
{
    public Swimming(string date, float duration, float laps) : base(date, duration)
    {
        this.laps = laps;
    }
    float laps;
    string activityName = "Swimming";

    override public float GetDistance()
    {
        float miles = laps * 50f / 1000f * 0.62f;
        return miles;
    }
    public override string GetSummary()
    {
        string summaryString = $"{GetDate()} {activityName} ({(float)Math.Round(GetDuration(), 2)} minuites)- Distance {(float)Math.Round(GetDistance(), 2)} miles, Speed {(float)Math.Round(GetSpeed(), 2)} mph, Pace {(float)Math.Round(GetPace(), 2)} min per mile";
        return summaryString;
    }

}