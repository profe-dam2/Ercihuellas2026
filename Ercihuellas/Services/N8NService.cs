using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Avalonia.Collections;

namespace Ercihuellas.Services;

public class N8NService
{
    private string url = "http://192.168.29.12:11000/webhook";

    public async Task<AvaloniaList<string>> ObtenerRazas()
    {
        using HttpClient cliente = new();
        return await cliente.GetFromJsonAsync<AvaloniaList<string>>(url + "/razas");
    }
}