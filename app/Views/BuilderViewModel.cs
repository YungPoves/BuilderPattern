using BuilderPattern.src;
using BuilderPattern.src.types;

namespace BuilderPattern.app.Views
{
  public class BuilderViewModel
  {
    public BuilderViewModel()
    {
      builder = new HouseBuilder();
    }

    public void Create(int walls, int doors, int windows, string roof, bool garage)
    {
      builder.SetWalls(walls);
      builder.SetDoors(doors);
      builder.SetWindows(windows);
      builder.SetRoof(roof);
      builder.SetGarage(garage);
    }

    #region Properties
    public HouseBuilder Builder { get => builder; set => builder = value; }
    #endregion

    #region Fields
    private HouseBuilder builder;
    private House house;
    #endregion
  }
}
