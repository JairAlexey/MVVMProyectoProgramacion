using MVVMProyectoProgramacion.Services;

namespace MVVMProyectoProgramacion.Views
{
    public partial class NuevaCitaPage : ContentPage
    {
        public APIService _apiService; // Declaración de la variable

        public NuevaCitaPage(APIService apiService)
        {
            InitializeComponent();
            _apiService = apiService; // Asignación de la variable
        }
    }
}

