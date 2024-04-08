class Event
{
    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;



    }
    string title;
    string description;
    string date;
    string time;
    Address address;


    public string ReturnStandardDetails()
    {
        string addressString = address.ExportToString();
        string standardDeetsString = $"\tTitle: {title}\n\tDescription: {description}\n\tDate: {date}\n\tTime: {time}\n\tAddress: {addressString}";
        return standardDeetsString;
    }
    public string GetEventTitle()
    {
        return title;
    }
    public string GetEventDate()
    {
        return date;
    }


    // public string ReturnFullDetails()
    // {
    //     if 
    //     string fullDeetsString = $"{ReturnStandardDetails()}\nEvent Type: {GetEventType()}\n{ReturnFullDetailsPackage()}";
    //     return "";
    // }
    // public string ReturnShortDescription()
    // {
    //     string shortDescriptionString = $"Event Type: {GetEventType()}\nTitle: {GetEventTitle()}";
    //     return shortDescriptionString;

}