using ProyectoBase.Dominio;
using ProyectoBase.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Interfaces
{
    public interface IVistaSupervisorDeLinea : IVistaInteractiva
    {
        void CargarOrden(OrdenDeProduccion op);
        void MostrarObjetivo(int objetivo);
        void ListarDefectos(ICollection<Defecto> defectos);
        void setPresentador(PresentadorOP presentadorOP);
        void Show();
    }
}
