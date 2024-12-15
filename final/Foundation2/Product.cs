public class Product
{
    public string Name ;
    public string ProductId ;
    public decimal PricePerUnit ;
    public int Quantity ;

    public decimal CalculateTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}