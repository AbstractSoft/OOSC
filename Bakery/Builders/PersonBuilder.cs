namespace Bakery.Builders;

public class PersonBuilder
{
    private PersonName personName;
    private PhoneNumbers personPhoneNumbers;
    
    public void SetPersonName(string firstName, string lastName)
    {
        personName = new PersonName(firstName, lastName);
    }

    public void SetPersonPhoneNumbers(IReadOnlyCollection<PhoneNumber> phoneNumbersCollection)
    {
        personPhoneNumbers = new PhoneNumbers();

        foreach (var phoneNumber in phoneNumbersCollection)
        {
            personPhoneNumbers.AddNumber(phoneNumber);
        }
    }

    public Person GetResult()
    {
        return new Person(personName, personPhoneNumbers, personEmail);
    }
}