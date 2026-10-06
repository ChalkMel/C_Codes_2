namespace СP_ClassesAndOverrides;

public abstract class Property
{
  public float Worth { get; private set; }

  public Property(float worth)
  {
    if (worth > 0)
      Worth = worth;
    else
      throw new ArgumentOutOfRangeException(nameof(worth), worth, "Должно быть больше нуля");
  }

  public abstract float CalculateTax();
}