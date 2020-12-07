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
        public Defecto()
        {

        }
        public Defecto(EspecificacionDeDefecto especDe, string pie, DateTime now)
        {
            hora = now;
            Pie = pie;
            especificacion = especDe;
        }

        public string Pie
        {
            set {
                if (value == "DERECHO")
                {
                    this.pie = Dominio.Pie.DERECHO;
                }
                else
                {
                    if (value == "AMBOS")
                    {
                        this.pie = Dominio.Pie.AMBOS;
                    }
                    else
                    {
                        this.pie = Dominio.Pie.IZQUIERDO;
                    }
                }
                
            }
            get
            {
                return pie.ToString();
            }
        }
        public DateTime hora { get; set; }
        public virtual EspecificacionDeDefecto especificacion { get; set; }

    }
}
