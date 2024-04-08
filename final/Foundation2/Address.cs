class Address
{
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;

    }
    private string street;
    private string city;
    private string state;
    private string country;
    public bool IsInUSA()
    {
        if (country == "USA")
        {
            return true;
        }
        else { return false; }
    }
    public string ExportToString()
    {
        return $"{street} {city}, {state} {country}";
    }
}