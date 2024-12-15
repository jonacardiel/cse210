public class Address
{
    public string StreetAddress ;
    public string City ;
    public string StateProvince ;
    public string Country ;

    public override string ToString()
    {
        return $"{StreetAddress}, {City}, {StateProvince}, {Country}";
    }
}