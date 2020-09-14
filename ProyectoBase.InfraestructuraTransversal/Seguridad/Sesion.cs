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
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public bool IsActiva { get; set; }

        public Sesion(Usuario usuario)
        {
            Usuario = usuario;
            Inicio = DateTime.Now;
            IsActiva = true;
        }
       public void Finalizar()
        {
            IsActiva = false;
            Fin = DateTime.Now;
        }
    }
}
