using System.Collections;

namespace MyClassProject
{
  public class Garages
  {
    private string name;

    public ArrayList carList = new ArrayList();

    public Garages()
    { }
    public Garages(string n)
    {
      name = n;
    }

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public void DisplayGarageCars()
    {
      Console.WriteLine("Garage: " + name);
      foreach (Cars c in carList)
      {
        Console.WriteLine(
          "Car: " +
          c.Make +
          " " + c.Type +
          " " + c.Colour +
          " " + c.Cost
        );
      }
    }
  }
}
