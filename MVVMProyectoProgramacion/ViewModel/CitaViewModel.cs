using MVVMProyectoProgramacion.Models;
using System.Collections.ObjectModel;
using MVVMProyectoProgramacion.Services;
using System.Threading.Tasks;

namespace MVVMProyectoProgramacion.ViewModel;

public class CitaViewModel
{
    private APIService _apiService;
    public ObservableCollection<Cita> ListCitas { get; private set; }

    public CitaViewModel()
    {
        _apiService = new APIService(); // Asegúrate de implementar la inyección de dependencias si es necesario
        ListCitas = new ObservableCollection<Cita>();
        LoadCitas();
    }

    private async void LoadCitas()
    {
        int idUsuarioInt = Preferences.Get("idusuario", 0);
        string idUsuario = idUsuarioInt.ToString();
        if (idUsuarioInt != 0)
        {
            var listaCitas = await _apiService.getCita(idUsuario);
            if (listaCitas != null)
            {
                foreach (var cita in listaCitas)
                {
                    ListCitas.Add(cita);
                }
            }
        }
    }
}
