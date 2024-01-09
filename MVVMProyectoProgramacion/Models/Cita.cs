using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMProyectoProgramacion.Models
{
    public class Cita // EN MVVM TIENE QUE TODO SER PUBLICO,
                      // ADEMAS DE QUE TODO DEBE TENER GET Y SET
    {
        public int IdCita { get; set; }

        public string Fecha { get; set; }

        public string Hora { get; set; }

        public string Descripcion { get; set; }

        // ID del Medico
        public string IdMedico { get; set; }

        // ID del Usuario
        public string IdUsuario { get; set; }
    }
}
