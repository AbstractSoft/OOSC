namespace Abstraction;

public class CoffeeBeanComparer : IEqualityComparer<CoffeeBean>
{
    public bool Equals(CoffeeBean? x, CoffeeBean? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.Name == y.Name;
    }

    public int GetHashCode(CoffeeBean obj)
    {
        return obj.Name.GetHashCode();
    }
}