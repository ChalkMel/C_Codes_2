namespace MelnikVictoria_CatFramework;

public class Tiger : Cat
{
  public override int Fluffiness { get; }
  public double Weight { get; }

  public Tiger(double weight, int fluffiness = 50)
  {
    bool weightBad = weight < 75 || weight > 140;
    bool fluffinessBad = fluffiness < 0 || fluffiness > 100;
    if (weightBad && fluffinessBad)
      throw new CatException(
        $"Unable to create a tiger with weight: {weight}; " +
        $"Unable to create a tiger with fluffiness {fluffiness}");

    if (weightBad)
      throw new CatException($"Unable to create a tiger with weight: {weight}");
    
    if (fluffinessBad)
      throw new CatException($"Unable to create a tiger with fluffiness {fluffiness}");

    Fluffiness = fluffiness;
    Weight = weight;
  }
  
  public override string FluffinessCheck()
  {
    return "Kycb!";
  }
  
  public  override string ToString()
  {
    return $"A tiger with weight: {Weight} fluffiness: {Fluffiness}";
  }
}