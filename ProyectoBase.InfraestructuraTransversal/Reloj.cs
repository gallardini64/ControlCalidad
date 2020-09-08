using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProyectoBase.InfraestructuraTransversal
{
    public class Reloj
    {
        public event EventHandler<bool> CambiaHora;

        public void Tiempo(Action metodo)
        {
           
        }
        public void OnCambiaHora()
        {
            CambiaHora?.Invoke(this, true);
        }
    }
}
