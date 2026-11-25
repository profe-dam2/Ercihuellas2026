using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Ercihuellas.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _url;
    private string _host="http://localhost:8080/reports";

    [RelayCommand]
    private void ConsultarEspecies(object species)
    {
        Url = _host + "/animales/" + species;
    }
    
    [RelayCommand]
    private void ConsularInformeTodos()
    {
        Url = _host + "/getReport";
    }
}