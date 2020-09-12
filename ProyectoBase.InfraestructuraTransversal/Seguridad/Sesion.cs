using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.InfraestructuraTransversal.Seguridad
{
    public class Sesion
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public bool IsActiva { get; set; }
    }
}
