using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProyecto4.Models
{
    public class Salas
    {
        public int IdSala { get; set; }
        public string TipoSala { get; set; }
        public string NombreSala { get; set; }
        public int Capacidad { get; set; }
        public int IdColegio { get; set; }
    }
}