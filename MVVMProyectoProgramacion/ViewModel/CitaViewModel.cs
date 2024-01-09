using MVVMProyectoProgramacion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMProyectoProgramacion.ViewModel
{
    public class CitaViewModel
    {
        public ObservableCollection<Cita> ListCitas { get; set; }
        public CitaViewModel() 
        {
            ListCitas = new ObservableCollection<Cita>(); 
        }  
    }
}
