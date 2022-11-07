public class Spaceship
{
    private string callSign;
    private bool shieldActive;
    private int shieldStrength;
    private Coordinate position;
  
    public Spaceship(
        string callSign = "Super Fighter", 
        bool shieldActive = true,
        int shieldStrength = 10,
        Coordinate position = default)
    {
        this.callSign = callSign;
        this.shieldActive = shieldActive;
        this.shieldStrength = shieldStrength;
        
        if (position == null)
        {
            position = Coordinate.NullObject;
            return;
        }
          
        this.position = position;
    }
    
    public int GetShieldStrength(){...}
    public void ReduceShield(int newValue) {...}
    public Coordinate GetPosition() {...}
    public void Move() {...}
  
    private SetPosition(Coordinate coordinate) {...}
    
    public static readonly Spaceship NullObject = new Spaceship() { };
}