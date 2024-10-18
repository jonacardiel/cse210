public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator = 1)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            denominator = value;
        }
    }

    public double DecimalValue
    {
        get { return (double)numerator / denominator; }
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }
}