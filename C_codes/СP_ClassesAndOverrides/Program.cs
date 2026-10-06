namespace СP_ClassesAndOverrides
{
  internal class Program
  {
    public static void Main()
    {
      Property[] properties = new Property[10];

      properties[0] = new Apartment(1000, 10);
      properties[1] = new Apartment(20589, 483);
      properties[2] = new Apartment(74734, 237);

      properties[3] = new Car(8237, 433);
      properties[4] = new Car(7534, 665);
      properties[5] = new Car(6532, 1847);

      properties[6] = new Boat(93934, 453);
      properties[7] = new Boat(67532, 456);

      properties[8] = new CountryHouse(57674, 753);
      properties[9] = new CountryHouse(67534, 986);

      foreach (Property property in properties)
        Console.WriteLine(property);
    }
  }
}