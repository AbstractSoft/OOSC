namespace Abstraction;

public class Coffee {
    public CoffeeSelection Selection { get; }
    public double Quantity { get; }

    public Coffee(CoffeeSelection selection, double quantity) {
        Selection = selection;
        Quantity = quantity;
    }
}