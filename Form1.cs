using BuilderPattern.app.Views;
using BuilderPattern.app.Views.Main;

namespace BuilderPattern
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    public Form1(MainViewModel mainViewModel)
    {
      InitializeComponent();

      this.mainViewModel = mainViewModel;

      CreateBindings();
    }
    public Form1(MainViewModel mainViewModel,
      BuilderViewModel builderViewModel)
    {
      InitializeComponent();

      this.mainViewModel = mainViewModel;
      this.builderViewModel = builderViewModel;

      CreateBindings();
    }

    private void CreateBindings()
    {
      DataBindings.Add(nameof(Text), mainViewModel, nameof(mainViewModel.Text), true, DataSourceUpdateMode.Never);
    }

    public void btnCreate_Click(object sender, EventArgs e)
    {
      builderViewModel.Create(
        (int)numericUpDown1.Value,
        (int)numericUpDown2.Value, 
        (int)numericUpDown3.Value,
        "Test",
        true);
      this.textBox1.Text = builderViewModel.Builder.House.ToString();
    }

    private readonly MainViewModel mainViewModel;
    private readonly BuilderViewModel builderViewModel;
  }
}
