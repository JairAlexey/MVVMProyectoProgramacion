using MVVMProyectoProgramacion.Services;

namespace MVVMProyectoProgramacion.Views
{
    public partial class NuevaCitaPage : ContentPage
    {
        public APIService _apiService; // Declaraci�n de la variable

        public NuevaCitaPage(APIService apiService)
        {
            InitializeComponent();
            _apiService = apiService; // Asignaci�n de la variable
        }
    }
}

