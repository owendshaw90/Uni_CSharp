using System.Collections;

namespace MyClassProject


{
  class Program
  {
    static void Main(string[] args)
    {
      Cars car1 = new Cars();// contructor method with no arguments passed
      car1.Colour = "Red";
      car1.Make = "Ford";
      car1.Type = "Mondeo";
      car1.Cost = 15000;
      // Console.WriteLine(
      //   "Car1 is a" +
      //   " " + car1.Country +
      //   " " + car1.Make +
      //   " " + car1.Type +
      //   " " + car1.Colour +
      //   " " + car1.Cost
      //   );

      Cars car2 = new Cars("Vauxhall", "Velox");// contructor method with one argument passed
      car2.Colour = "Blue";
      car2.Cost = 20000;

      // Console.WriteLine(
      //   "Car2 is a" +
      //   " " + car2.Country +
      //   " " + car2.Make +
      //   " " + car2.Type +
      //   " " + car2.Colour +
      //   " " + car2.Cost
      //   );

      //write your own code that uses the constructor
      //that takes two arguments
      Cars car3 = new Cars("Aston Martin", "DB9");
      car3.Colour = "Black";
      car3.Cost = 100000;

      // Console.WriteLine(
      //   "Car3 is a" +
      //   " " + car3.Country +
      //   " " + car3.Make +
      //   " " + car3.Type +
      //   " " + car3.Colour +
      //   " " + car3.Cost
      //   );

      // then change the Cars Class to add a constructor method 
      // that takes three arguements
      Cars car4 = new Cars("Lotus", "Elise", "Yellow");
      car4.Cost = 50000;

      // Console.WriteLine(
      //   "Car4 is a" +
      //   " " + car4.Country +
      //   " " + car4.Make +
      //   " " + car4.Type +
      //   " " + car4.Colour +
      //   " " + car4.Cost
      //   );

      ElectricCars car5 = new ElectricCars("Tesla", "Model S", "Silver", 300);
      car5.Cost = 80000;

      Cars.HowMany();

      car1.Display();
      car2.Display();
      car3.Display();
      car4.Display();
      car5.DisplayEV();

      Console.WriteLine("Moving on to the Array List");

      Garages garage1 = new Garages("Stirling");
      Garages garage2 = new Garages("Glasgow");

      garage1.carList.Add(car1);
      garage1.carList.Add(car2);
      garage1.carList.Add(car3);
      garage2.carList.Add(car4);
      garage2.carList.Add(car5);

      // a.Add("Vauxhall");
      // a.Add("Lotus");
      // a.Add("Aston Martin");
      // a.Add("JLR");

      // a.Sort(); // add to sort the array list

      // Cars.DisplayArrayList(a);
      garage1.DisplayGarageCars();
      garage2.DisplayGarageCars();

      Console.ReadLine();
    }
  }
}