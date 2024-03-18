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
            $"FrameworkDescription {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}" +
            $"OSDescription {System.Runtime.InteropServices.RuntimeInformation.OSDescription}";

        Version.Text = $"{SysInfoText}";
        Lang.Text = Windows.Globalization.ApplicationLanguages.Languages[0];
    }
}
