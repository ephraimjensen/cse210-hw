class Reception : Event
{
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;

    }

    private string rsvpEmail;


    public string ReturnFullDetailsPackage()
    {
        return $"The RSVP email is: {rsvpEmail}";
    }

    public string GetEventType()
    {
        return "Reception";
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