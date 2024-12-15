public class Customer
{
    public string Name ;
    public Address Address ;

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}