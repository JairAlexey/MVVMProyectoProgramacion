using MVVMProyectoProgramacion.Services;
using MVVMProyectoProgramacion.ViewModel;

namespace MVVMProyectoProgramacion.Views
{
    public partial class CitaPage : ContentPage
    {
        public APIService _apiService; //Declara una propiedad para el servicio API.

        public CitaPage(APIService apiService) //constructor de la clase
        {
            InitializeComponent(); //Se llama para inicializar la p�gina
            _apiService = apiService;
            BindingContext = new CitaViewModel(Navigation, apiService); //Establece el contexto de enlace de la p�gina a una nueva instancia de CitaViewModel
        }
    }
}