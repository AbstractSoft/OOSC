namespace Bakery;

public abstract class PhoneNumber {
    private readonly int countryCode;
    private readonly int prefix;
    private readonly int number;

    protected PhoneNumber (int countryCode, int prefix, int number)
    {
        ValidatePhoneNumber(countryCode, prefix, number);

        this.countryCode = countryCode;
        this.prefix = prefix;
        this.number = number;
    }

    public override string ToString()
    {
        return $"{countryCode}-{prefix}-{number}";
    }

    private void ValidatePhoneNumber(int countryCode, int prefix, int number) {
        // FluentValidation
        // throw exception when validation fails
    }
}

