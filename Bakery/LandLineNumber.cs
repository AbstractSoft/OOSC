namespace Bakery;

public class LandLineNumber: PhoneNumber{
    public LandLineNumber(int countryCode, int prefix, int number)
        : base(countryCode, prefix, number)
    {
    }
}