using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("This my buildings!!");
      Building NSS = new Building("301 Plus Park")
      {
        Width = 250,
        Depth = 300,
        Stories = 5
      };
      Building oldNSS = new Building("500 Interstate Blvd");
      Building dadsHouse = new Building("Spring Hill");

      oldNSS.Width = 250;
      oldNSS.Depth = 300;
      oldNSS.Stories = 5;

      dadsHouse.Width = 250;
      dadsHouse.Depth = 300;
      dadsHouse.Stories = 5;

      NSS.Construct();
      oldNSS.Construct();
      dadsHouse.Construct();

      NSS.Purchase("John Wark");
      oldNSS.Purchase("James Nitz");
      dadsHouse.Purchase("The Bank");

      Console.WriteLine(NSS.ToString());
      Console.WriteLine(oldNSS.ToString());
      Console.WriteLine(dadsHouse.ToString());


    }
  }
}
