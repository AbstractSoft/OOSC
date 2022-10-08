namespace BethanyPieShop.Models;

public class CoffeeBean {
    public string Name { get; }
    public double Quantity { get; }

    public CoffeeBean(string name, double quantity) {
        Name = name;
        Quantity=quantity;
    }
}