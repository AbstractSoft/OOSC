namespace Bakery;

// Immutable

public class MobileNumber : PhoneNumber
{
    public MobileNumber(int countryCode, int prefix, int number)
        : base(countryCode, prefix, number)
    {
    }
}