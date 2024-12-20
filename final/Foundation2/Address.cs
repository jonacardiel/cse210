public class Address
{
    public string StreetAddress ;
    public string City ;
    public string StateProvince ;
    public string Country ;

    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{StreetAddress}, {City}, {StateProvince}, {Country}";
    }
}
