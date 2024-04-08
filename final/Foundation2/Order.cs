using System.Diagnostics.Metrics;

class Order
{
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }
    List<Product> products;
    Customer customer;
    public float CalculateTotalCost()
    {
        float total = 0;
        foreach (Product product in products)
        {
            total += product.CalculateTotalCost();
            total += CalculateShippingCost();
        }
        total = (float)Math.Round(total, 2);
        return total;
    }
    public string ReturnPackingLabel()
    {
        int counter = 0;
        string returnString = "";
        foreach (Product product in products)
        {
            counter++;

            string productName = product.GetName();
            int productId = product.GetId();

            returnString = returnString + $"\n\tProduct {counter}: \n\t\tProduct Name: {productName}\n\t\tProduct ID: {productId}";



        }
        return returnString;
    }
    public string ReturnShippingLabel()
    {
        return $"\tCustomer Name: {customer.GetName()} \n\tCustomer Address: {customer.GetAddress().ExportToString()}";
    }
    int CalculateShippingCost()
    {
        if (customer.CheckIfInUSA())
        {
            return 5;
        }
        else { return 35; }
    }
}