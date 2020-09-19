using ProyectoBase.Dominio;
using ProyectoBase.Dominio.Contratos;
using ProyectoBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Presentadores
{
    public class PresentadorVistaGeneral : PresentadorBase<IVistaGeneral>
    {
        private IRepository<OrdenDeProduccion> _repository;

        internal void ActualizarPantalla(object sender, Defecto d)
        {
            Vista.AgregarDefecto(d);
        }
    }
}
