using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Interfaces
{
    //Todas las interfaces de vistas deben heredar de esta
    public interface IVistaInteractiva
    {
        void Cerrar();
        void MostrarMensaje(string mensaje, bool esError = false);
    }
}
