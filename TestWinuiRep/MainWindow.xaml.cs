using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using Microsoft.UI.Xaml;

namespace TestWinuiRep;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Lang.Text = "test";

        ExtendsContentIntoTitleBar = true;
        SetTitleBar(null);

        Version.Text = "VersionTests";
        Lang.Text = Windows.Globalization.ApplicationLanguages.Languages[0];
    }

    //public static string GetAppVersion()
    //{
    //    var package = Package.Current;
    //    var packageId = package.Id;
    //    var version = packageId.Version;

    //    return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
    //}

    //public static string GetTestVersion()
    //{
    //    StringBuilder sb = new StringBuilder();
    //    Windows.Management.Deployment.PackageManager packageManager = new Windows.Management.Deployment.PackageManager();
    //    foreach (var pkg in packageManager.FindPackages())
    //    {
    //        var version = pkg.Id.Version;
    //        Debug.WriteLine(string.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision));
    //        sb.AppendLine($"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}");
    //    }
    //    return sb.ToString();
    //}
}
