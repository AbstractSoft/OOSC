namespace CoffeeMachine;

public class Coffee {
    public Coffee(CoffeeBean coffeeBean, CoffeeSelection coffeeSelection, CoffeeSize coffeeSize) {
        CoffeeBean = coffeeBean;
        CoffeeSelection = coffeeSelection;
        CoffeeSize = coffeeSize;
    }

    public CoffeeBean CoffeeBean { get; }
    public CoffeeSelection CoffeeSelection { get; }
    public CoffeeSize CoffeeSize { get; }
}