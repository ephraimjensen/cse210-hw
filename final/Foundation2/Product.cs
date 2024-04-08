class Product
{
    public Product(string name, int id, float price, int quantity)
    {
        this.price = price;
        this.name = name;
        this.quantity = quantity;
        this.id = id;
    }
    string name;
    float price;
    int quantity;
    int id;
    public string GetName()
    {
        return name;
    }
    public int GetId()
    {
        return id;
    }
    public float CalculateTotalCost()
    {
        float total = quantity * price;
        total.ToString("0.00");
        return total;


    }
}