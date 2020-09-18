using ProyectoBase.Datos;
using ProyectoBase.Dominio;
using ProyectoBase.Dominio.Contratos;
using ProyectoBase.InfraestructuraTransversal;
using ProyectoBase.InfraestructuraTransversal.IoC;
using ProyectoBase.InfraestructuraTransversal.Seguridad;
using ProyectoBase.Interfaces;
using ProyectoBase.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase.Presentadores
{
    public class PresentadorOP : PresentadorBase<IVistaOP>
    {
        private VistaSupervisorLinea _vistaSL;
        private OrdenDeProduccion _op = new OrdenDeProduccion();
        private readonly IRepository<OrdenDeProduccion> _repository;
        private readonly IRepository<EspecificacionDeDefecto> _repositoryED;
        private readonly IRepository<Modelo> _repositoryModelo;
        private readonly IRepository<Color> _repositoryColor;
        private readonly IRepository<Turno> _repositoryTurno;

        public PresentadorOP(IRepository<OrdenDeProduccion> repository, 
                             IRepository<EspecificacionDeDefecto> repositoryED,
                             IRepository<Modelo> repositorymodelo,
                             IRepository<Color> repositorycolor,
                             IRepository<Turno> repositoryTurno)
        {
            _repositoryModelo = repositorymodelo;
            _repositoryTurno = repositoryTurno;
            _repositoryColor = repositorycolor;
            _repository = repository;
            _repositoryED = repositoryED;
            Reloj.RelojCambiaHora += guardarDatosHora;

        }

        internal void confirmarNuevaOrden(DateTime fecha, Color color, Modelo modelo)
        {
            List<Turno> turnos = _repositoryTurno.GetTodos().ToList();
            Turno turnoActual = new Turno();
            foreach (var turno in turnos)
            {
                if (turno.Inicio.Hour >= DateTime.Now.Hour && turno.Fin.Hour <= DateTime.Now.Hour)
                {
                    turnoActual = turno;
                }
            }
            _op.Modelo = modelo;
            _op.Color = color;
            _op.agregarTurno(turnoActual);
            
        }

        internal void ActualizarOP()
        {
            throw new NotImplementedException();
        }

        internal List<EspecificacionDeDefecto> ObtenerEspecificacionesDefectos()
        {
            var especificacionesDefectos = _repositoryED.GetTodos();
            return especificacionesDefectos.ToList();
        }

        internal void crearNuevaOrden()
        {
            _op = new OrdenDeProduccion();
        }

        internal List<Modelo> getModelos()
        {
            return _repositoryModelo.GetTodos().ToList();
        }

        internal List<Color> getColores()
        {
            return _repositoryColor.GetTodos().ToList();
        }

        public void setVistaSL(VistaSupervisorLinea vista)
        {
            _vistaSL = vista;
            _vistaSL.setPresentador(this);
            _vistaSL.Show();
        }
        #region EVENTOS CU6
        public void AgregarDefecto(int id, string pie)
        {
            var especDe = _repositoryED.Get(id);
            _op.AgregarDefecto(especDe, pie, DateTime.Now);
            ActualizarVistaDatos();
        }
        private void guardarDatosHora(object sender,bool cambiaHora = true)
        {
            _op.ActualizarHorasOcupadas();
            _repository.Modificar(_op);
        }

        internal void QuitarDefecto(int id)
        {
            var especDe = _repositoryED.Get(id);
            _op.QuitarDefecto(especDe);
            ActualizarVistaDatos();
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
