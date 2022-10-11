namespace Bakery;

// Immutable

public class MobilePhoneNumber : PhoneNumber
{
    public MobilePhoneNumber(int countryCode, int prefix, int number)
        : base(countryCode, prefix, number)
    {
    }
}