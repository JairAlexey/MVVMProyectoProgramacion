using MVVMProyectoProgramacion.Services;

namespace MVVMProyectoProgramacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            APIService apiservice = new APIService();
            MainPage = new NavigationPage(new LoginPage(apiservice));
        }
    }
}

