﻿using MVVMProyectoProgramacion.Services;
using MVVMProyectoProgramacion.Views;

namespace MVVMProyectoProgramacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            APIService apiservice = new APIService();
            MainPage = new NavigationPage(new CitaPage(apiservice));
        }
    }
}

