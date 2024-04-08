using System.Reflection.Metadata.Ecma335;

class Cycling : Activity
{
    public Cycling(string date, float duration, float speed) : base(date, duration)
    {
        this.speed = speed;
    }
    private float speed;
    private string activityName = "Cycling";

    override public float GetSpeed()
    {
        return speed;
    }
    public override string GetSummary()
    {
        string summaryString = $"{GetDate()} {activityName} ({(float)Math.Round(GetDuration(), 2)} minuites)- Distance {(float)Math.Round(GetDistance(), 2)} miles, Speed {(float)Math.Round(GetSpeed(), 2)} mph, Pace {(float)Math.Round(GetPace(), 2)} min per mile";
        return summaryString;
    }


    //speed = (distance / duration) * 60
}