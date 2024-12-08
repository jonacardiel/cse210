class Program
{
    static void Main(string[] args)
    {
        // Create a list of orders
        List<Order> orders = new List<Order>();

        // Create products
        Product product1 = new Product { Name = "Product 1", ProductId = "P1", PricePerUnit = 10.00m, Quantity = 2 };
        Product product2 = new Product { Name = "Product 2", ProductId = "P2", PricePerUnit = 20.00m, Quantity = 1 };

        // Create a customer
        Customer customer1 = new Customer { Name = "John Doe", Address = new Address { StreetAddress = "123 Main St", City = "Anytown", StateProvince = "CA", Country = "USA" } };

        // Create an order
        Order order1 = new Order { Products = new List<Product> { product1, product2 }, Customer = customer1 };
        orders.Add(order1);

        // Process orders
        foreach (Order order in orders)
        {
            Console.WriteLine($"Total Price: {order.CalculateTotalPrice()}");
            Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}");
        }
    }
}