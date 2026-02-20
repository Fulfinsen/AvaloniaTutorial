using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using Avalonia;

namespace BatchProcess3;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void CelsiusChanged_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(Celsius.Text) || Celsius.Text == "-")
        {
            Fahrenheit.Text = "";
        }
        else if (double.TryParse(Celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}