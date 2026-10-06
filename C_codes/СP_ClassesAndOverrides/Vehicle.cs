namespace СP_ClassesAndOverrides;

public class Vehicle : Property
{
  public float EngineVolume { get; private set; }
  
  public Vehicle(float worth, float engineVolume) : base(worth)
  {
    if (engineVolume > 0)
      EngineVolume = engineVolume;
    else
      throw new ArgumentOutOfRangeException(nameof(engineVolume), engineVolume, "Должно быть больше нуля");
  }

  public override float CalculateTax()
  {
    return Worth * EngineVolume / 3000;
  }

  public override string ToString()
  {
     return $": Стоимость - {Worth}, налог - {CalculateTax():F2}, объём двигателя - {EngineVolume} см.куб";
  }
}