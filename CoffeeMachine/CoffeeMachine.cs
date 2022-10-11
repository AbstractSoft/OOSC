namespace CoffeeMachine;

public class CoffeeMachine
{
    private KeyValuePair<CoffeeBean, CoffeeQuantity> coffeeLoad;

    public CoffeeMachine(KeyValuePair<CoffeeBean, CoffeeQuantity> coffeeLoad)
    {
        this.coffeeLoad = coffeeLoad;
    }

    public CoffeeBean GetCoffeeBean()
    {
        return coffeeLoad.Key;
    }
    
    public Coffee BrewCoffee(CoffeeSelection coffeeSelection, CoffeeSize coffeeSize)
    {
        var coffee = new Coffee(coffeeLoad.Key, coffeeSelection, coffeeSize);
        coffeeLoad.Value.Weight -= 0.05d;
        return coffee;
    }
}
