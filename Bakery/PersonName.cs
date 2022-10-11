namespace Bakery;

public class PersonName { //-> ValueObject din DDD
    private readonly string firstName;
    private readonly string lastName;
    
    public PersonName(string firstName, string lastName) {
        ValidateName(firstName,lastName);

        this.firstName = firstName;
        this.lastName = lastName;
    }

    public override string ToString()
    {
        return $"{firstName}, {lastName}";
    }

    private void ValidateName(string firstName, string lastName) {
        // FluentValidation
        // throw exception when validation fails
    }
}