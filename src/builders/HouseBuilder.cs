using BuilderPattern.src.types;

namespace BuilderPattern.src
{
  public class HouseBuilder : IBuilder
  {
    public HouseBuilder()
    {
      House = new House();
    }
    public void Reset()
    {
      House.Walls = 0;
      House.Doors = 0;
      House.Windows = 0;
      House.Roof = "Basic";
      House.Garage = false;
    }

    public void SetWalls(int numberOfWalls)
    {
      House.Walls = numberOfWalls;
    }

    public void SetDoors(int numberOfDoors)
    {
      House.Doors = numberOfDoors;
    }

    public void SetWindows(int numberOfWindows)
    {
      House.Windows = numberOfWindows;
    }

    public void SetRoof(string styleOfRoof)
    {
      House.Roof = styleOfRoof;
    }

    public void SetGarage(bool hasGarage)
    {
      House.Garage = hasGarage;
    }

    public House GetResult() => House ?? throw new ArgumentNullException();

    public House House { get => house; set => house = value; }

    private House house;
  }
}
