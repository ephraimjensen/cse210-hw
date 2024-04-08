using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        // Create 2 orders with 2-3 products each
        Product product1 = new Product("Acrylic Paint Pot", 1, 1.25f, 12);
        Product product2 = new Product("Pot of Black Wash", 2, 5.99f, 1);
        Product product3 = new Product("Fine Tip Paintbrush", 3, 17.99f, 2);
        Product product4 = new Product("Acrylic Paint Brush", 4, 10.00f, 4);
        Product product5 = new Product("Super Glue", 5, 4.99f, 2);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);

        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);
        products2.Add(product5);

        Address address1 = new Address("101 E Viking Street", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("Resorts World Arena, Perimeter Rd", "Birmingham", "B40 1NT", "United Kingdom");

        Customer customer1 = new Customer("Alvin F. Meredith", address1);
        Customer customer2 = new Customer("ESL Gaming", address2);

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        orders.Add(order1);
        orders.Add(order2);


        // call methods to get:
        //      packing label, shipping label, total price of order and display all of the previous.
        int counter = 0;
        foreach (Order order in orders)
        {
            counter++;

            string packingLabel = order.ReturnPackingLabel();
            string shippingLabel = order.ReturnShippingLabel();

            float totalPrice = order.CalculateTotalCost();

            Console.WriteLine($"For Order {counter}:\n");

            Console.WriteLine($"The Packing Label is: \n{packingLabel}\n");
            Console.WriteLine($"The Shipping Label is: \n{shippingLabel}\n");
            Console.WriteLine($"The Total Price is: {totalPrice}\n\n");



        }


    }
}