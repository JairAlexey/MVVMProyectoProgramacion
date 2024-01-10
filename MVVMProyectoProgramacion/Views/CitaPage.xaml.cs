using MVVMProyectoProgramacion.Services;
using MVVMProyectoProgramacion.ViewModel;

namespace MVVMProyectoProgramacion.Views
{
    public partial class CitaPage : ContentPage
    {
        private APIService _apiService;

        public CitaPage(APIService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
            BindingContext = new CitaViewModel(Navigation, apiService);
        }
    }
}