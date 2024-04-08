using System.Dynamic;

class Customer
{
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
    string name;
    Address address;
    public string GetName()
    {
        return name;
    }
    public Address GetAddress()
    {
        return address;
    }
    public bool CheckIfInUSA()
    {
        return address.IsInUSA();
    }
}