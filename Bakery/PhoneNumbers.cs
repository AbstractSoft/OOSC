using System.Collections.ObjectModel;

namespace Bakery;

public class PhoneNumbers
{
    private readonly IList<PhoneNumber> phoneNumbers = new Collection<PhoneNumber>();
    
    public void AddNumber(PhoneNumber phoneNumber)
    {
        phoneNumbers.Add(phoneNumber);
    }

    public IReadOnlyCollection<PhoneNumber> GetPhoneNumbers()
    {
        return new ReadOnlyCollection<PhoneNumber>(phoneNumbers);
    }
}