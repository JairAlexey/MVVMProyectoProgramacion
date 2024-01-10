using MVVMProyectoProgramacion.ViewModel;

namespace MVVMProyectoProgramacion.Views;

public partial class CitaPage : ContentPage
{
    public CitaPage()
    {
        InitializeComponent();
        BindingContext = new CitaViewModel();
    }
}
