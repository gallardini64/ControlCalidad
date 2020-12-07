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
        public EventHandler<Defecto> agregaDefecto;
        protected IVistaSupervisorDeLinea _vistaSL;
        protected OrdenDeProduccion _op;
        protected  IRepository<OrdenDeProduccion> _repository;
        protected  IRepository<EspecificacionDeDefecto> _repositoryED;
        protected  IRepository<Modelo> _repositoryModelo;
        protected  IRepository<Color> _repositoryColor;
        protected  IRepository<Turno> _repositoryTurno;
        protected  IRepository<Empleado> _repositoryEmpleado;
        protected  IRepository<LineaDeTrabajo> _repositoryLineaDeTrabajo;
        protected Sesion _sesionSupLinea;
        //private Sesion _sesionSupCalidad;

        public PresentadorOP(IRepository<OrdenDeProduccion> repository, 
                             IRepository<EspecificacionDeDefecto> repositoryED,
                             IRepository<Modelo> repositorymodelo,
                             IRepository<Color> repositorycolor,
                             IRepository<Turno> repositoryTurno,
                             IRepository<Empleado> repositoryEmpleado,
                             IRepository<LineaDeTrabajo> repositoryLineaDeTrabajo)
        {
            _repositoryModelo = repositorymodelo;
            _repositoryTurno = repositoryTurno;
            _repositoryColor = repositorycolor;
            _repository = repository;
            _repositoryED = repositoryED;
            _repositoryEmpleado = repositoryEmpleado;
            _repositoryLineaDeTrabajo = repositoryLineaDeTrabajo;
            Reloj.RelojCambiaHora += guardarDatosHora;
            
        }
        public PresentadorOP()
        {
        }

        public void CargarOPPausada()
        {
            var ordenes = _repository.GetTodos().ToList();
            _op = ordenes.LastOrDefault(e => e.Estado == Dominio.Estado.Pausada.ToString());
            if (_op != null)
            {
                Vista.ActivarControles(_op);
                Vista.CargarOrden(_op);
                _vistaSL.CargarOrden(_op);
            }
            
        }

        internal void AgregarPar(string calidad)
        {
            _op.ActualizarPares(1,calidad);
        }

        internal void quitarPar(string calidad)
        {
            _op.HorarioActual.Pares.Remove(_op.HorarioActual.Pares.LastOrDefault(e => e.Calidad == calidad));
        }

        internal void AsignarSesionActual(Sesion sesion)
        {
            _sesionSupLinea = sesion;
        }

        internal void PausarOP()
        {
            _op.PausarOP();
            Vista.DesactivarControles();
            _repository.Modificar(_op);

        }

        internal void ActivarControles()
        {
            Vista.ActivarControles(_op);
        }

        internal void ReanudarOP()
        {
            _op.Estado = "Activa";
            _repository.Modificar(_op);
            Vista.ActivarControles(_op);
        }

        internal void LimpiarCamposOP()
        {
            Vista.LimpiarCamposOP();
        }
        #region CU2

        internal void crearNuevaOrden()
        {
            _op = new OrdenDeProduccion();
        }
       public void SeleccionarModelo(int sku)
        {
            _op.Modelo = _repositoryModelo.GetTodos().FirstOrDefault(m => m.SKU == sku);
            _vistaSL.MostrarObjetivo(_op.Modelo.Objetivo); 
        }
        public void confirmarNuevaOrden(int numero, LineaDeTrabajo linea, DateTime fecha, Color color)
        {
            List<Turno> turnos = _repositoryTurno.GetTodos().ToList();
            Turno turnoActual = new Turno();
            foreach (var turno in turnos)
            {
                if (DateTime.Now.Hour >= turno.Inicio && DateTime.Now.Hour <= turno.Fin)
                {
                    turnoActual = turno;
                }
            }
            if (_repository.GetConFiltro(op => op.Estado == Estado.Activa.ToString() && op.LineaDeTrabajo.Numero == linea.Numero) == null)
            {
                _op.Numero = numero;
                _op.LineaDeTrabajo = linea;
                _op.Fecha = fecha;
                _op.Color = color;
                _op.CrearNuevoHorario(turnoActual);
                _repository.Agregar(_op);
            }
            else
            {
                _vistaSL.MostrarMensaje("La linea seleccionada ya se encuentra ocupada");
            }

        }
       public Turno ObtenerTurnoActual()
        {
            List<Turno> turnos = _repositoryTurno.GetTodos().ToList();
            Turno turnoActual = turnos.FirstOrDefault(t => DateTime.Now.Hour >= t.Inicio && DateTime.Now.Hour <= t.Fin);
            return turnoActual;

            //foreach (var turno in turnos)
            //{
            //    if (DateTime.Now.Hour >= turno.Inicio.Hour && DateTime.Now.Hour <= turno.Fin.Hour)
            //    {
            //        turnoActual = turno;
            //    }
            //}

        }
        internal void FinalizarOP()
        {
            _op.Estado = "Finalizada";
            _repository.Modificar(_op);
            Vista.DesactivarControles();

        }

        internal List<EspecificacionDeDefecto> ObtenerEspecificacionesDefectos()
        {
            var especificacionesDefectos = _repositoryED.GetTodos();
            return especificacionesDefectos.ToList();
        }
        internal List<EspecificacionDeDefecto> ObtenerEspecificacionesDefectosObservado()
        {
            var especificacionesDefectos = _repositoryED.GetTodos().Where(e => e.Tipo.Equals("Observado"));
            return especificacionesDefectos.ToList();
        }
        internal List<EspecificacionDeDefecto> ObtenerEspecificacionesDefectosReprocesado()
        {
            var especificacionesDefectos = _repositoryED.GetTodos().Where(e => e.Tipo.Equals("Reprocesado")); ;
            return especificacionesDefectos.ToList();
        }

        internal List<Modelo> getModelos()
        {
            return _repositoryModelo.GetTodos().ToList();
        }

        internal void ParAPrimera()
        {
            _op.ActualizarPares(1,Dominio.Calidad.Primera.ToString());
        }

        internal List<Color> getColores()
        {
            return _repositoryColor.GetTodos().ToList();
        }
       
        internal List<LineaDeTrabajo> getLineasDeTrabajo()
        {
            return _repositoryLineaDeTrabajo.GetTodos().ToList();
        }





        #endregion

        #region EVENTOS CU6
        public void AgregarDefecto(int id, string pie)
        {
            var especDe = _repositoryED.Get(id);
            _op.AgregarDefecto(1,especDe, pie, DateTime.Now);
            OnAgregaDefecto(_op.HorarioActual.Defectos.LastOrDefault());
            ActualizarVistaDatos();
        }

        private void OnAgregaDefecto(Defecto d)
        {
            agregaDefecto?.Invoke(this, d);
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
            _vistaSL.ListarDefectos(_op.HorarioActual.Defectos);
        }
        public void setVistaSL(IVistaSupervisorDeLinea vista)
        {
            _vistaSL = vista;
            _vistaSL.setPresentador(this);
            _vistaSL.Show();
        }
    }
}
