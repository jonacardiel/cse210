public class Product
{
    public string Name { get; set; }
    public string ProductId { get; set; }
    public decimal PricePerUnit { get; set; }
    public int Quantity { get; set; }

    public decimal CalculateTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}