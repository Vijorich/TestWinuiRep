using System;
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

        var SysInfoText = $"ProcessArchitecture {System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}\n" +
            $"RuntimeIdentifier {System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier}\n" +
            $"OSArchitecture {System.Runtime.InteropServices.RuntimeInformation.OSArchitecture}\n" +
            $"FrameworkDescription {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}";

        Version.Text = $"{SysInfoText}";
        Lang.Text = Windows.Globalization.ApplicationLanguages.Languages[0];
    }

    public string architectureString(Windows.System.ProcessorArchitecture architecture)
    {
        return architecture switch
        {
            Windows.System.ProcessorArchitecture.X86 => "x86",
            Windows.System.ProcessorArchitecture.Arm => "arm",
            Windows.System.ProcessorArchitecture.X64 => "x64",
            Windows.System.ProcessorArchitecture.Neutral => "neutral",
            Windows.System.ProcessorArchitecture.Unknown => "unknown",
            Windows.System.ProcessorArchitecture.Arm64 => "arm64",
            Windows.System.ProcessorArchitecture.X86OnArm64 => "x86OnArm64",
            _ => "???"
        };
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
