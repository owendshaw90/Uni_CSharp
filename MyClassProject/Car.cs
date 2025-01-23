using System.Collections;
using System.Runtime.InteropServices;

namespace MyClassProject
{
  public class Cars
  {
    private static int carID = 0; // a static variable
    private string colour;
    private string type;
    private string make;
    private readonly string country;
    private double cost;

    public Cars() // counstructor
    {
      carID++;
      country = "UK";
    }

    public Cars(string m) : this() // counstructor
    {
      make = m;
    }

    public Cars(string m, string t) : this(m)
    {
      type = t;
    }

    public Cars(string c) : this(m, t)
    {
      colour = c;
    }

    public string Country //read only Property
    {
      get { return country; }
    }

    public string Colour //property for manipulating colour
    {
      get { return colour; }
      set { colour = value; }
    }
    public string Type //property for manipulating type
    {
      get { return type; }
      set { type = value; }
    }

    public string Make //property for manipulating make
    {
      get { return make; }
      set { make = value; }
    }
    public double Cost //property for manipulating cost
    {
      get { return cost; }
      set { cost = value; }
    }

    public void Display()
    {
      Console.WriteLine(
        "Car" +
        " " + country +
        " " + make +
        " " + type +
        " " + colour +
        " " + cost
        );
    }

    public static void DisplayArrayList(ArrayList list)
    {
      foreach (string Make in list)
      {
        Console.WriteLine("{0}", Make);
      }
    }

    // Static Method
    public static void HowMany()
    {
      Console.WriteLine("There are " + carID + " cars sold by garage");
    }
  }
}
