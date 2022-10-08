namespace Abstraction;

public static class Program
{
    public static void Main(string[] args)
    {
        var coffeeStock = new CoffeeStock();
        coffeeStock.AddCoffeeQuantity(new CoffeeBean("Arabica"), new CoffeeQuantity(1000d));
        coffeeStock.AddCoffeeQuantity(new CoffeeBean("Columbia"), new CoffeeQuantity(1000d));

        var machine =
            new CoffeeMachine(coffeeStock.TakeCoffeeQuantity(
                new CoffeeBean("Arabica"), 
                new CoffeeQuantity(10)));

        // Brew a fresh coffee
        try
        {
            Console.WriteLine("Making coffee ...");
            var espresso = machine.BrewCoffee(CoffeeSelection.Espresso, CoffeeSize.Single);
            Console.WriteLine($"Your {espresso.CoffeeBean.Name} coffee is ready!");
        }
        catch (CoffeeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}