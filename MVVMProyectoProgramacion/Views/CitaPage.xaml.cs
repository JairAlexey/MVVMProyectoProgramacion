using MVVMProyectoProgramacion.Services;
using MVVMProyectoProgramacion.ViewModel;

namespace MVVMProyectoProgramacion.Views
{
    public partial class CitaPage : ContentPage
    {
        public APIService _apiService; //Declara una propiedad para el servicio API.

        public CitaPage(APIService apiService) //constructor de la clase
        {
            InitializeComponent(); //Se llama para inicializar la página
            _apiService = apiService;
            BindingContext = new CitaViewModel(Navigation, apiService); //Establece el contexto de enlace de la página a una nueva instancia de CitaViewModel
        }
    }
}