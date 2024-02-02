using Microsoft.UI.Xaml;

using Windows.ApplicationModel;

namespace TestWinuiRep;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ExtendsContentIntoTitleBar = true;
        SetTitleBar(null);

        Version.Text = GetAppVersion();
    }

    public static string GetAppVersion()
    {
        var package = Package.Current;
        var packageId = package.Id;
        var version = packageId.Version;

        return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
    }
}
