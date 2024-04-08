
class Activity
{
    public Activity(string date, float duration)
    {
        this.date = date;
        this.duration = duration;
    }
    private string date;
    private float duration;

    public float GetDuration()
    {
        return duration;
    }

    public virtual float GetDistance()
    {
        float distance = GetSpeed() * duration / 60f;
        return distance;
    }
    public virtual float GetSpeed()
    {
        float speed = GetDistance() / duration * 60f;
        return speed;
    }
    public virtual float GetPace()
    {
        float pace = duration / GetDistance();
        return pace;
    }
    public string GetDate()
    {
        return date;
    }
    public virtual string GetSummary()
    {
        string summaryString = $"{GetDate()} ACTIVITY NAME HERE ({GetDuration()} minuites)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
        return summaryString;
    }

}