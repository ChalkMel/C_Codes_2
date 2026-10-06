namespace СP_ClassesAndOverrides;

public class Car : Vehicle
{
  public Car(float worth, float engineVolume) : base(worth, engineVolume) {}
  
  public override string ToString()
  {
    return "Машина" + base.ToString();
  }
}