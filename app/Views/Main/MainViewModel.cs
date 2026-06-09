using System.Reflection;

namespace BuilderPattern.app.Views.Main
{
  public class MainViewModel : ObservableObject
  {
    public string Text => $"Builder Pattern Practice - {Assembly.GetEntryAssembly().GetName().Version}";
  }
}
