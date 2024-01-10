using MVVMProyectoProgramacion.Models;
using MVVMProyectoProgramacion.Views;
using System.Collections.ObjectModel;
using MVVMProyectoProgramacion.Services;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MVVMProyectoProgramacion.ViewModel
{
    public class CitaViewModel //Actúa como el ViewModel en el patrón MVVM.
    {
        public INavigation _navigation; //Campo para manejar la navegación entre páginas.
        public APIService _apiService; //Campo para interactuar con servicios API.

        public ObservableCollection<Cita> ListCitas { get; set; } //Colección observable de citas que se actualiza en la UI cuando hay cambios.
        public ICommand NuevaCitaCommand { get; } //Comando para manejar la acción de crear una nueva cita.
        public ICommand ItemSelectedCommand { get; set; } //Comando para manejar la selección de un elemento de la lista.
        public Cita SelectedItem { get; set; } //Propiedad para la cita seleccionada.

        public CitaViewModel(INavigation navigation, APIService apiService) //Constructor que inicializa el ViewModel, recibe la navegación y el servicio API como parámetros.
        {
            _navigation = navigation;
            _apiService = apiService;
            ListCitas = new ObservableCollection<Cita>();
            LoadCitas();
            NuevaCitaCommand = new Command(async () => await OnNuevaCita());
            ItemSelectedCommand = new Command<Cita>(OnItemSelected);
        }

        private async Task LoadCitas()
        {/*
            try
            {
                ListCitas = await _apiService.GetCitas();
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí, por ejemplo, mostrar un mensaje al usuario
                Debug.WriteLine($"Error al cargar citas: {ex.Message}");
            }*/
        }

        public async Task OnNuevaCita() //Método asíncrono que se ejecuta cuando se activa NuevaCitaCommand, navegando a la página para crear una nueva cita.
        {
            // Navega a la página de nueva cita
            await _navigation.PushAsync(new NuevaCitaPage(_apiService));
        }

        public void OnItemSelected(Cita selectedCita) //Método que se ejecuta cuando se selecciona una cita, donde se puede implementar lógica adicional como navegar a una página de detalles.
        {
            /*if (selectedCita != null)
            {

            }*/
        }
    }
}
