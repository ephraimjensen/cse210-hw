class Product
{
    public Product(string name, int id, float price, int quantity)
    {
        this.price = price;
        this.name = name;
        this.quantity = quantity;
        this.id = id;
    }
    private string name;
    private float price;
    private int quantity;
    private int id;
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