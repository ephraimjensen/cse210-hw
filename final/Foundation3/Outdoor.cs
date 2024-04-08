class Outdoor : Event
{
    public Outdoor(string title, string description, string date, string time, Address address, string forecast) : base(title, description, date, time, address)
    {
        this.forecast = forecast;

    }

    private string forecast;


    public string ReturnFullDetailsPackage()
    {
        return $"The weather forecast is: {forecast}";
    }
    public string GetEventType()
    {
        return "Outdoor";
    }

    public string ReturnFullDetails()
    {
        string fullDeetsString = $"{ReturnStandardDetails()}\n\tEvent Type: {GetEventType()}\n\t{ReturnFullDetailsPackage()}";
        return fullDeetsString;
    }
    public string ReturnShortDescription()
    {
        string shortDescriptionString = $"\tEvent Type: {GetEventType()}\n\tTitle: {GetEventTitle()}\n\tDate: {GetEventDate()}";
        return shortDescriptionString;
    }
}