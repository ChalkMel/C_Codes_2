namespace СP_ClassesAndOverrides;

public class Immovable : Property
{
  public float Space { get; private set; }
  public Immovable(float worth, float space) : base(worth)
  {
    if (space > 0)
      Space = space;
    else
      throw new ArgumentOutOfRangeException(nameof(space), space, "Должно быть больше нуля");
  }

  public override float CalculateTax()
  {
    if (Space <= 100)
      return Worth / 500;
    if (Space <= 300)
      return Worth / 350;
    return Worth / 250;
  }
  
  public float CalculateWorthByMeter() => Worth / Space;

  public override string ToString()
  {
    return $": Стоимость - {Worth}, налог - {CalculateTax():F2}, площадь - {Space} кв.м";
  }
}