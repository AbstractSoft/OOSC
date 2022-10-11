namespace CoffeeMachine;

public class CoffeeQuantity
{
    private const string measurementUnit = "Kg";
    
    public CoffeeQuantity(double weight)
    {
        Weight = weight;
    }

    public double Weight { get; set; }
    public string MeasurementUnit => measurementUnit;
}