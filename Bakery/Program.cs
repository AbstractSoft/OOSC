namespace Bakery;

public static class Program
{
    public static void Main(string[] args)
    {
        var person1 = new PersonBuilder();
        person1.SetPersonName("firstName", "string lastName");
        person1.SetPersonPhoneNumber("country-code1", "prefix1", "number1");
        person1.SetPersonPhoneNumber("country-code2", "prefix2", "number2");
        ...
        person1.SetEmail("email@email.com");   
        
        
              
    }
}




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
