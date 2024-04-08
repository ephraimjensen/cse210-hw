class Lecture : Event
{
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int maxCapacity) : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.maxCapacity = maxCapacity;

    }
    string speaker;
    int maxCapacity;
    public string GetEventType()
    {
        return "Lecture";
    }

    public string ReturnFullDetailsPackage()
    {

        return $"The speaker will be: {speaker}\n\tThe max capacity is {maxCapacity}";
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