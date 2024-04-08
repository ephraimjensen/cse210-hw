class Address
{
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;

    }
    string street;
    string city;
    string state;
    string country;
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