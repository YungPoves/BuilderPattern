using BuilderPattern.app.Views;
using BuilderPattern.app.Views.Main;

namespace BuilderPattern.app
{
  public class CompositionRoot
  {
    public CompositionRoot()
    {
      MainViewModel mainViewModel = new MainViewModel();
      BuilderViewModel builderViewModel = new BuilderViewModel();

      Form = new Form1(mainViewModel, builderViewModel);
    }

    public Form Form;
  }
}
