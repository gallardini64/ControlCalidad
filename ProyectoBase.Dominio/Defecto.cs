using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Dominio
{
    public class Defecto : EntityBase
    {
        private Pie pie;

        public String Pie
        {
            set {
                if (value == "DERECHO")
                {
                    this.pie = Dominio.Pie.DERECHO;
                }
                else
                {
                    this.pie = Dominio.Pie.IZQUIERDO;
                }
            }
            get
            {
                return pie.ToString();
            }
        }
        public DateTime hora { get; set; }
        public EspecificacionDeDefecto especificacion { get; set; }

    }
}
