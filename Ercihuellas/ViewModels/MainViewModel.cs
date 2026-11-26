using System.Threading.Tasks;
using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ercihuellas.Services;

namespace Ercihuellas.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _url;
    private string _host="http://localhost:8080/reports";

    private N8NService _n8nService = new();

    [ObservableProperty] private AvaloniaList<string> _listaRazas = new();
    
    [RelayCommand]
    private async Task ObtenerRazas()
    {
        ListaRazas = await _n8nService.ObtenerRazas();
    }
    
    [RelayCommand]
    private void ConsultarEspecies(object species)
    {
        Url = _host + "/animales/" + species;
    }
    
    [RelayCommand]
    private void ConsultarRazas(object raza)
    {
        Url = _host + "/animales_raza/" + raza;
    }
    
    [RelayCommand]
    private void ConsularInformeTodos()
    {
        Url = _host + "/getReport";
    }
}