using ProyectoBase.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Interfaces
{
    public interface IVistaGeneral : IVistaInteractiva
    {
        void AgregarDefecto(Defecto d);
    }
}
