using Microsoft.UI.Xaml;

namespace TestWinuiRep;

public partial class App : Application
{
    public static MainWindow MainWindow = new();

    public App()
    {
        InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        MainWindow.Activate();

    }
}
