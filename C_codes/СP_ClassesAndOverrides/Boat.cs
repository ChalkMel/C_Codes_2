namespace СP_ClassesAndOverrides;

public class Boat : Vehicle
{
  public Boat(float worth, float engineVolume) : base(worth, engineVolume) {}
  
  public override string ToString()
  {
    return "Лодка" + base.ToString();
  }
}