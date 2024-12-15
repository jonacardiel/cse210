public class Order
{
    public List<Product> Products { get; set; } = new List<Product>();
    public Customer Customer ;

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in Products)
        {
            totalPrice += product.CalculateTotalCost();
        }

        decimal shippingCost = Customer.IsInUSA() ? 5 : 35;
        return totalPrice + shippingCost;
    }

    public string GetPackingLabel()
    {
        var label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} (ID: {product.ProductId}) - Quantity: {product.Quantity}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address}";
    }
}