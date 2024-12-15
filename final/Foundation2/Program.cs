class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address1 = new Address
        {
            StreetAddress = "123 Elm St",
            City = "Springfield",
            StateProvince = "IL",
            Country = "USA"
        };

        Address address2 = new Address
        {
            StreetAddress = "456 Maple Ave",
            City = "Toronto",
            StateProvince = "ON",
            Country = "Canada"
        };

        // Create customers
        Customer customer1 = new Customer { Name = "John Doe", Address = address1 };
        Customer customer2 = new Customer { Name = "Jane Smith", Address = address2 };

        // Create products
        Product product1 = new Product { Name = "Laptop", ProductId = "A123", PricePerUnit = 999.99m, Quantity = 1 };
        Product product2 = new Product { Name = "Mouse", ProductId = "B456", PricePerUnit = 25.50m, Quantity = 2 };
        Product product3 = new Product { Name = "Keyboard", ProductId = "C789", PricePerUnit = 45.00m, Quantity = 1 };

        // Create orders
        Order order1 = new Order
        {
            Customer = customer1,
            Products = new List<Product> { product1, product2 }
        };

        Order order2 = new Order
        {
            Customer = customer2,
            Products = new List<Product> { product3 }
        };

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}\n");
    }
}