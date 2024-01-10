using MVVMProyectoProgramacion.Models;
using MVVMProyectoProgramacion.Views;
using System.Collections.ObjectModel;
using MVVMProyectoProgramacion.Services;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MVVMProyectoProgramacion.ViewModel
{
    public class CitaViewModel
    {
        private INavigation _navigation;
        private APIService _apiService;

        public ObservableCollection<Cita> ListCitas { get; set; }
        public ICommand NuevaCitaCommand { get; }
        public ICommand ItemSelectedCommand { get; set; }
        public Cita SelectedItem { get; set; }

        public CitaViewModel(INavigation navigation, APIService apiService)
        {
            _navigation = navigation;
            _apiService = apiService;
            ListCitas = new ObservableCollection<Cita>();
            LoadCitas();
            NuevaCitaCommand = new Command(async () => await OnNuevaCita());
            ItemSelectedCommand = new Command<Cita>(OnItemSelected);
        }

        private async Task LoadCitas()
        {
            //ListCitas = await _apiService.GetCitas();
        }

        private async Task OnNuevaCita()
        {
            // Navega a la página de nueva cita
            await _navigation.PushAsync(new NuevaCitaPage(_apiService));
        }

        private void OnItemSelected(Cita selectedCita)
        {
            if (selectedCita != null)
            {
                // Implementa la lógica de selección aquí
                // Ejemplo: Navegar a una nueva página de detalles
            }
        }
    }
}
