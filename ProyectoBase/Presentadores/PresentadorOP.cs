using ProyectoBase.Datos;
using ProyectoBase.Dominio;
using ProyectoBase.Dominio.Contratos;
using ProyectoBase.InfraestructuraTransversal;
using ProyectoBase.InfraestructuraTransversal.IoC;
using ProyectoBase.Interfaces;
using ProyectoBase.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Presentadores
{
    public class PresentadorOP : PresentadorBase<IVistaOP>
    {
        private VistaSupervisorLinea _vistaSL;
        private OrdenDeProduccion _op = new OrdenDeProduccion();
        private readonly IRepository<OrdenDeProduccion> _repository;
        private readonly IRepository<EspecificacionDeDefecto> _repositoryED;

        internal void ActualizarOP()
        {
            throw new NotImplementedException();
        }

        public PresentadorOP(IRepository<OrdenDeProduccion> repository, IRepository<EspecificacionDeDefecto> repositoryED)
        {
            _repository = repository;
            _repositoryED = repositoryED;
            Reloj.RelojCambiaHora += guardarDatosHora;
        }

        public void setVistaSL(VistaSupervisorLinea vista)
        {
            _vistaSL = vista;
            _vistaSL.Show();
        }
        #region EVENTOS CU6
        public void AgregarDefecto(int v, string text)
        {
            var especDe = _repositoryED.Get(v);
            _op.AgregarDefecto(especDe, text, DateTime.Now);
            ActualizarVistaDatos();
        }
        private void guardarDatosHora(object sender,bool cambiaHora = true)
        {
            _op.ActualizarHorasOcupadas();
            // TO DO //
        }
        #endregion



        internal void GenerarOtraVista()
        {
            setVistaSL(IoCFactory.Instance.CurrentContainer.Resolve<VistaSupervisorLinea>());
        }
        internal void ActualizarVistaDatos()
        {
            _vistaSL.ListarDefectos(_op.Defectos);
        }

    }
}
