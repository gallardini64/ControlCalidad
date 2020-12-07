using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProyectoBase.Dominio;
using ProyectoBase.Dominio.Contratos;
using ProyectoBase.Interfaces;
using ProyectoBase.Vistas;

namespace Prueba
{
    [TestClass]
    public class OrdenDeProduccionTest
    {
        public Turno t { get; set; }
        public OrdenDeProduccion op { get; set; }
        public Mock<IRepository<OrdenDeProduccion>> _repositoryOP;
        public Mock<PresentadorOPTest> _presentadorOP;
        public Mock<IVistaSupervisorDeLinea> _vistaSL;
        [TestInitialize]
        public void begin()
        {
            op = new OrdenDeProduccion();
            _repositoryOP = new Mock<IRepository<OrdenDeProduccion>>();
            _presentadorOP = new Mock<PresentadorOPTest>();
            _vistaSL = new Mock<IVistaSupervisorDeLinea>();

            _presentadorOP.Object.setOP(op);
            _presentadorOP.Object.setRepositorio(_repositoryOP.Object);
            _presentadorOP.Object.setVistaSupervisor(_vistaSL.Object);

        }

        [TestMethod]
        public void ActualizarParesAgregandoParDePrimeraAunaOPEnEstadoActivaDentroDeTurno()
        {
            // Arrange
            op.Estado = "Activa";

            Horario h = new Horario(t);
            op.Horarios.Add(h);
            op.HorarioActual = h;

            // Act
            bool parAgregado = op.ActualizarPares(1,"Primera");

            // Assert
            Assert.IsTrue(parAgregado);
            Assert.AreEqual(1, op.HorarioActual.Pares.Count);
            Assert.IsTrue(op.HorarioActual.Pares.LastOrDefault().Calidad.Equals("Primera"));

        }

        [TestMethod]
        public void ActualizarParesAgregandoParDePrimeraEnUnaOPEnEstadoPausadaDentroDeLos10MinutosLimite()
        {
            // Arrange
            op.Estado = "Pausada";
            Horario h = new Horario(t);
            op.Horarios.Add(h);
            op.HorarioActual = h;
            op.HorarioActual.Fin = DateTime.Now.AddMinutes(-5);
            //Se restan 5 min de la hora actual simulando que han pasado desde que la OP se pausó

            // Act
            bool parAgregado = op.ActualizarPares(1,"Primera");

            // Assert
            Assert.IsTrue(parAgregado);
            Assert.AreEqual(1, op.HorarioActual.Pares.Count);
            Assert.IsTrue(op.HorarioActual.Pares.LastOrDefault().Calidad.Equals("Primera"));

        }
        [TestMethod]
        public void ActualizarParesAgregandoParDePrimeraEnUnaOPEnEstadoPausadaFueraDeLos10MinutosLimite()
        {
            // Arrange
            op.Estado = "Pausada";
            Horario h = new Horario(t);
            op.Horarios.Add(h);
            op.HorarioActual = h;
            op.HorarioActual.Fin = DateTime.Now.AddMinutes(-10);

            //Se restan 10 min de la hora actual simulando que ha pasado el tiempo límite de operación desde que la OP se pausó

            // Act
            bool parAgregado = op.ActualizarPares(1,"Primera");

            // Assert
            Assert.IsFalse(parAgregado);
            Assert.AreEqual(0, op.HorarioActual.Pares.Count);
            Assert.IsTrue(op.HorarioActual.Pares.Count == 0);

        }
        [TestMethod] 
        public void ActualizarDefectoDentroDeTurnoAgregandoDefectosSegunElTipoYPie() 
        {
            // Arrange
            op.Estado = "Activa";
            Horario h = new Horario(t);
            op.Horarios.Add(h);
            op.HorarioActual = h;

            EspecificacionDeDefecto especDe1 = new EspecificacionDeDefecto() { Id = 1, descripcion = "Suela despegada", Tipo = Tipo.Observado.ToString() };
            EspecificacionDeDefecto especDe2 = new EspecificacionDeDefecto() { Id = 1, descripcion = "Asimetria", Tipo = Tipo.Reprocesado.ToString() };
            
            // Act
            op.AgregarDefecto(1,especDe1, "IZQUIERDO", DateTime.Now);
            op.AgregarDefecto(1,especDe1, "DERECHO", DateTime.Now);
            op.AgregarDefecto(1,especDe2, "IZQUIERDO", DateTime.Now);
            op.AgregarDefecto(1,especDe2, "DERECHO", DateTime.Now);

            // Assert
            Assert.IsTrue(op.HorarioActual.Defectos.Where(d => d.especificacion == especDe1 && d.Pie.Equals("IZQUIERDO")).Count() == 1);
            Assert.IsTrue(op.HorarioActual.Defectos.Where(d => d.especificacion == especDe1 && d.Pie.Equals("DERECHO")).Count() == 1);
            Assert.IsTrue(op.HorarioActual.Defectos.Where(d => d.especificacion == especDe2 && d.Pie.Equals("IZQUIERDO")).Count() == 1);
            Assert.IsTrue(op.HorarioActual.Defectos.Where(d => d.especificacion == especDe2 && d.Pie.Equals("DERECHO")).Count() == 1);
        }
        [TestMethod]
        public void ActualizarDefectoDentroDeTurnoQuitandoDefectosSegunElTipoYPie()
        {
            // Arrange
            op.Estado = "Activa";
            Horario h = new Horario(t);
            op.Horarios.Add(h);
            op.HorarioActual = h;

            EspecificacionDeDefecto especDe1 = new EspecificacionDeDefecto() { Id = 1, descripcion = "Suela despegada", Tipo = Tipo.Observado.ToString() };
            EspecificacionDeDefecto especDe2 = new EspecificacionDeDefecto() { Id = 1, descripcion = "Asimetria", Tipo = Tipo.Reprocesado.ToString() };
            op.HorarioActual.Defectos.Add(new Defecto(especDe1, "IZQUIERDO", DateTime.Now));
            op.HorarioActual.Defectos.Add(new Defecto(especDe1, "DERECHO", DateTime.Now));
            op.HorarioActual.Defectos.Add(new Defecto(especDe2, "IZQUIERDO", DateTime.Now));
            op.HorarioActual.Defectos.Add(new Defecto(especDe2, "DERECHO", DateTime.Now));
            // Act
            op.AgregarDefecto(-1, especDe1, "IZQUIERDO", DateTime.Now);
            op.AgregarDefecto(-1, especDe1, "DERECHO", DateTime.Now);
            op.AgregarDefecto(-1, especDe2, "IZQUIERDO", DateTime.Now);
            op.AgregarDefecto(-1, especDe2, "DERECHO", DateTime.Now);

            // Assert
            Assert.IsTrue(op.HorarioActual.Defectos.Where(d => d.especificacion == especDe1 && d.Pie.Equals("IZQUIERDO")).Count() == 0);
            Assert.IsTrue(op.HorarioActual.Defectos.Where(d => d.especificacion == especDe1 && d.Pie.Equals("DERECHO")).Count() == 0);
            Assert.IsTrue(op.HorarioActual.Defectos.Where(d => d.especificacion == especDe2 && d.Pie.Equals("IZQUIERDO")).Count() == 0);
            Assert.IsTrue(op.HorarioActual.Defectos.Where(d => d.especificacion == especDe2 && d.Pie.Equals("DERECHO")).Count() == 0);
        }


        // PRUEBAS CON MOCKS
        [TestMethod]
        public void ConfirmarNuevaOPConLineaSeleccionadaDisponible()
        {
            // Arrange

            int numero = 2445;
            LineaDeTrabajo lineaSeleccionada = new LineaDeTrabajo();
            lineaSeleccionada.Numero = 4;
            
            DateTime fecha = new DateTime(2020, 12, 6, 10, 0, 0);
            op.Modelo = new Modelo(1, "Sport");
            Color color = new Color(1, "Azul");
            
            List<Turno> turnos = new List<Turno>() {
                            
                new Turno(){ Id = 1, Inicio = 8, Fin = 16 },
                new Turno(){Id = 2, Inicio = 16, Fin = 0}
             };
            Mock<IRepository<Turno>> _repositoryTurno = new Mock<IRepository<Turno>>();
            _repositoryTurno.Setup(r => r.GetTodos()).Returns(turnos);
            _presentadorOP.Object.setRepositorioTurno(_repositoryTurno.Object);
            _repositoryOP.Setup(r => r.GetConFiltro(op => op.Estado == Estado.Activa.ToString() && op.LineaDeTrabajo.Numero == lineaSeleccionada.Numero)).Returns((IEnumerable<OrdenDeProduccion>)null);
           
            // Act
            _presentadorOP.Object.confirmarNuevaOrden(numero, lineaSeleccionada, fecha, color);

            // Assert
            Assert.AreSame(op.LineaDeTrabajo, lineaSeleccionada);
        }

        [TestMethod]
        public void ConfirmarNuevaOPConLineaSeleccionadaOcupada()
        {
            // Arrange

            int numero = 2445;
            LineaDeTrabajo lineaSeleccionada = new LineaDeTrabajo();
            lineaSeleccionada.Numero = 4;

            DateTime fecha = new DateTime(2020, 12, 6, 10, 0, 0);
            op.Modelo = new Modelo(1, "Sport");
            Color color = new Color(1, "Azul");

            List<Turno> turnos = new List<Turno>() {

                new Turno(){ Id = 1, Inicio = 8, Fin = 16 },
                new Turno(){ Id = 2, Inicio = 16, Fin = 0}
             };
            Mock<IRepository<Turno>> _repositoryTurno = new Mock<IRepository<Turno>>();
            _repositoryTurno.Setup(r => r.GetTodos()).Returns(turnos);
            _presentadorOP.Object.setRepositorioTurno(_repositoryTurno.Object);
            IEnumerable<OrdenDeProduccion> opEncontrada = new List<OrdenDeProduccion>() { new OrdenDeProduccion() { LineaDeTrabajo = new LineaDeTrabajo() { Id = 4, Numero = 4 } } };

            _repositoryOP.Setup(r => r.GetConFiltro(op => op.Estado == Estado.Activa.ToString() && op.LineaDeTrabajo.Numero == lineaSeleccionada.Numero)).Returns(opEncontrada);

            // Act
            _presentadorOP.Object.confirmarNuevaOrden(numero, lineaSeleccionada, fecha, color);

            // Assert
            Assert.IsTrue(op.LineaDeTrabajo == null);
        }
    }
}
