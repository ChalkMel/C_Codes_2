namespace СP_ClassesAndOverrides;

public class CountryHouse : Immovable
{
  public CountryHouse(float worth, float space) : base(worth, space) {}
  
  public override string ToString()
  {
    return "Дача" + base.ToString();
  }
}