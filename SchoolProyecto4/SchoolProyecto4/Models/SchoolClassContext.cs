using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProyecto4.Models
{
    public class SchoolClassContext
    {
        public int IdColegio { get; set; }
        public string NombreColegio { get; set; }
        public string Telefono { get; set; }
        public int IdComuna { get; set; }
        public int IdCargo { get; set; }
    }
}