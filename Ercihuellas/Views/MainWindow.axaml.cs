using Avalonia.Controls;

namespace Ercihuellas.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        NavegadorWeb.IsVisible =  false;
        BarraCarga.IsVisible = false;
        ImagenInicio.IsVisible = true;
    }

    private void Navegacion_completada(object? sender, WebViewNavigationCompletedEventArgs e)
    {
        NavegadorWeb.IsVisible =  true;
        BarraCarga.IsVisible = false;
    }

    private void Navegacion_iniciada(object? sender, WebViewNavigationStartingEventArgs e)
    {
        ImagenInicio.IsVisible = false;
        NavegadorWeb.IsVisible =  false;
        BarraCarga.IsVisible = true;
    }
}