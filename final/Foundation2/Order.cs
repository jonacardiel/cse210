public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public decimal CalculateTotalPrice()
    {
        // Calculate the total price, including shipping cost
        decimal totalPrice = 0;
        foreach (Product product in Products)
        {
            totalPrice += product.CalculateTotalCost();
        }
        // Add shipping cost based on order total or other factors
        return totalPrice + CalculateShippingCost();
    }

    public string GetPackingLabel()
    {
        // Generate packing label based on product details and customer address
        return "Packing Label: " + Customer.Name + ", " + Customer.Address.ToString();
    }

    public string GetShippingLabel()
    {
        // Generate shipping label based on customer address and order weight/dimensions
        return "Shipping Label: " + Customer.Name + ", " + Customer.Address.ToString();
    }

    private decimal CalculateShippingCost()
    {
        // Calculate shipping cost based on order weight, distance, or other factors
        return 10.00m; 
    }
}