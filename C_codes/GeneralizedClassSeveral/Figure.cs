namespace GeneralizedClassSeveral;
using System.Numerics;

public class Figure
{
  public Vector2 Center { get; set; }

  public Figure(Vector2 center)
  {
    Center = center;
  }
  
  public virtual Vector2 MinPoint => Center;

  public virtual Vector2 MaxPoint => Center;
}