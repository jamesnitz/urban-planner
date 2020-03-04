using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {

      City Nashville = new City("Nashville")
      {
        cityMayor = "Mayor McCheese",
        cityYear = 1978,
      };
      City ellivhsan = new City("ellivhsan")
      {
        cityMayor = "Grimace",
        cityYear = 2020,
      };

      Console.WriteLine("This my buildings!!");
      Building NSS = new Building("301 Plus Park")
      {
        Width = 250,
        Depth = 300,
        Stories = 5,
        Name = "NSS"
      };
      Building oldNSS = new Building("500 Interstate Blvd");
      Building dadsHouse = new Building("Spring Hill");

      oldNSS.Width = 250;
      oldNSS.Depth = 300;
      oldNSS.Stories = 5;
      oldNSS.Name = "Old NSS";

      dadsHouse.Width = 250;
      dadsHouse.Depth = 300;
      dadsHouse.Stories = 5;
      dadsHouse.Name = "My Dad's Place";

      NSS.Construct();
      oldNSS.Construct();
      dadsHouse.Construct();

      NSS.Purchase("John Wark");
      oldNSS.Purchase("James Nitz");
      dadsHouse.Purchase("The Bank");

      Nashville.addBuilding(NSS);
      Nashville.addBuilding(oldNSS);
      ellivhsan.addBuilding(dadsHouse);

      Console.WriteLine($"{Nashville.Name} has the following buildings");
      foreach (Building building in Nashville.Buildings)
      {
        Console.WriteLine($"{building.Name} located at {building.Address} ");
      }
      Console.WriteLine($"{ellivhsan.Name} has the following buildings");
      foreach (Building building in ellivhsan.Buildings)
      {
        Console.WriteLine($"{building.Name} located at {building.Address} ");
      }









    }
  }
}
