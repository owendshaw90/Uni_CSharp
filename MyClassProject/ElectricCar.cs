namespace MyClassProject
{
  public class ElectricCars : Cars //Inherit from Cars
  {
    private int range;

    public ElectricCars(string make, string type, string colour, int r) : base(make, type, colour) // counstructor
    {
      range = r;
    }

    public int Range
    {
      get { return range; }
      set { range = value; }
    }


    public void DisplayEV()
    {
      Console.WriteLine(
      "Electric Car" +
      " " + Country +
      " " + Make +
      " " + Type +
      " " + Colour +
      " " + Cost +
      " " + range
    );
    }
  }
}