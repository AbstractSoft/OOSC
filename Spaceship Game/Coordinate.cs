public class Coordinate
{
  private int horizontal;
  private int vertical;

  public Coordinate (int horizontal = 0, int vertical = 0)
  {
    Horizontal = horizontal;
    Vertical = vertical;
  }

  public int Horizontal { get; }
  public int Vertical { get; }

  public static readonly Coordinate NullObject = new Coordinate();
}