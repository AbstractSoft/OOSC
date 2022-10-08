namespace Abstraction;

public class CoffeeStock
{
    private Dictionary<CoffeeBean, CoffeeQuantity> stock;

    public CoffeeStock()
    {
        stock = new Dictionary<CoffeeBean, CoffeeQuantity>();
    }

    public void AddCoffeeQuantity(CoffeeBean coffee, CoffeeQuantity coffeeQuantity)
    {
        if (stock.ContainsKey(coffee))
        {
            stock[coffee].Weight += coffeeQuantity.Weight;
            return;
        }

        stock.Add(coffee, coffeeQuantity);
    }

    public KeyValuePair<CoffeeBean, CoffeeQuantity> TakeCoffeeQuantity(CoffeeBean coffeeBean, CoffeeQuantity coffeeQuantity)
    {
        if (!stock.ContainsKey(coffeeBean))
        {
            throw new CoffeeException($"There is no '{coffeeBean.Name}' coffee in stock");
        }
        
        var existingQuantity = stock[coffeeBean];

        if (existingQuantity.Weight < coffeeQuantity.Weight)
        {
            throw new CoffeeException(
                $"Insufficient quantity in stock. There are only '{coffeeQuantity}" +
                $"{coffeeQuantity.MeasurementUnit}' of '{coffeeBean.Name}' available.");
        }

        stock[coffeeBean].Weight -= coffeeQuantity.Weight;
        
        return new KeyValuePair<CoffeeBean, CoffeeQuantity>(coffeeBean, coffeeQuantity);
    }
}