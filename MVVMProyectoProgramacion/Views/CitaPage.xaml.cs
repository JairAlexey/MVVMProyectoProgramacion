using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using MVVMProyectoProgramacion.Models;
using System.Collections.ObjectModel;
using MVVMProyectoProgramacion.Services;
using System.Diagnostics;
using MVVMProyectoProgramacion.ViewModel;

namespace MVVMProyectoProgramacion;

public partial class CitaPage : ContentPage
{
    ObservableCollection<Cita> citas;
    private readonly APIService _APIService;
    public CitaPage(APIService apiservice)
    {
        InitializeComponent();
        BindingContext = new CitaViewModel(); //NECESARIO PARA ENLAZAR CON EL VIEWMODEL
        _APIService = apiservice;

    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        int idUsuarioInt = Preferences.Get("idusuario", 0);
        string idUsuario = idUsuarioInt.ToString();

        if (idUsuarioInt != 0)
        {
            List<Cita> ListaCitas = await _APIService.getCita(idUsuario);

            if (ListaCitas != null)
            {
                citas = new ObservableCollection<Cita>(ListaCitas);
                listaCitas.ItemsSource = citas;
            }
            else
            {
                Debug.WriteLine("La lista de citas es nula.");
            }
        }


    }

    private async void OnClickNuevaCita(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NuevaCitaPage(_APIService));
    }
    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        Cita cita = e.SelectedItem as Cita;
        await Navigation.PushAsync(new DetailsCitaPage(_APIService)
        {
            BindingContext = cita,
        });
    }
}