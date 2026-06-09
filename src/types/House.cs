namespace BuilderPattern.src.types
{
  public class House
  {
    public House() 
    {
      Roof = "basic";
    }
    public override string ToString() => 
      $"Walls: {Walls}\r\n" +
      $"Doors: {Doors}\r\n" +
      $"Windows: {Windows}\r\n" +
      $"Roof: {Roof}\r\n" +
      $"Has garage: {Garage}.\r\n";
    
    public int Walls { get => walls; set => walls = value; }
    public int Doors { get => doors; set => doors = value; }
    public int Windows { get => windows; set => windows = value; }
    public string? Roof { get => roof; set => roof = value; }
    public bool Garage { get => garage; set => garage = value; }

    private int walls;
    private int doors;
    private int windows;
    private string? roof;
    private bool garage = false;
  }
}
