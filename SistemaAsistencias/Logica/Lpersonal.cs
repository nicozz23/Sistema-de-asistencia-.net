using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencias.Logica
{
    public class Lpersonal
    {
        public int Id_personal { get; set; }
        public string Nombres { get; set; }
        public string Identificacion { get; set; }
        public string Pais { get; set; }
        public int Id_cargo { get; set; }
        public double Sueldo_por_hora { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }

    }
}
