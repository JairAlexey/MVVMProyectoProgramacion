﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMProyectoProgramacion.Models
{
    public class Medico
    {
        public int IdMedico { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Nacionalidad { get; set; }

        public string Especialidad { get; set; }
    }
}
