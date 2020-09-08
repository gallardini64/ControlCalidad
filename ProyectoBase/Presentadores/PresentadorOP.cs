using ProyectoBase.Datos;
using ProyectoBase.Dominio;
using ProyectoBase.Dominio.Contratos;
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
        }

        public void setVistaSL(VistaSupervisorLinea vista)
        {
            _vistaSL = vista;
            _vistaSL.Show();
        }
        #region EVENTOS CU6
        private void AgregarDefecto(int v, string text)
        {
            var especDe = _repositoryED.Get(v);
            _op.AgregarDefecto(especDe, text, DateTime.Now);
            ActualizarVistaDatos();
        }
        #endregion



        private void GenerarOtraVista()
        {
            setVistaSL(IoCFactory.Instance.CurrentContainer.Resolve<VistaSupervisorLinea>());
        }

       




        private void ActualizarVistaDatos()
        {
            _vistaSL.ListarDefectos(_op.Defectos);
        }

    }
}
