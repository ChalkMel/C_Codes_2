namespace СP_ClassesAndOverrides;

public class Apartment : Immovable
{
  public Apartment(float worth, float space) : base(worth, space) {}

  public override string ToString()
  {
    return "Квартира" + base.ToString();
  }
}