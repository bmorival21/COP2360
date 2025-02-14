using System;

namespace MyApplication
{
  class Octopus
  {
    public string name;
    public readonly int Legs;
    // Create a class constructor with a parameter
    public Octopus(string Name)
    {
      name = Name;
    }
    public Octopus(string Name,int Leg)
    {
      name = Name;
      Legs = Leg;
    }
    static void Main(string[] args)
    {
      Octopus myobject= new Octopus("blue");
      Console.WriteLine(myobject.name);
      Octopus myobject2= new Octopus("pink",8);
      Console.WriteLine(myobject2.name);
      Console.WriteLine(myobject2.Legs);
    }
  }
}
