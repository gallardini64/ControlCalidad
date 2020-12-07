using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class OrdenDeProduccionTest
    {
        public Turno t { get; set; }
        public OrdenDeProduccion op { get; set; }
        public Mock<IRepository<OrdenDeProduccion>> _repositoryOP;
        public Mock<PresentadorOPTest> _presentadorOP;
        [TestInitialize]
        public void begin()
        {
            op = new OrdenDeProduccion();
            _repositoryOP = new Mock<IRepository<OrdenDeProduccion>>();
            _presentadorOP = new Mock<PresentadorOPTest>();
            _presentadorOP.Object.setOP(op);
            _presentadorOP.Object.setRepositorio(_repositoryOP.Object);
        }

        [TestMethod]
        public void AgregarUnParDePrimeraAunaOPEnEstadoActivaDentroDeTurno()
        {
            // Arrange
            op.Estado = "Activa";

            Horario h = new Horario(t);
            op.Horarios.Add(h);
            op.HorarioActual = h;

            // Act
            bool parAgregado = op.AgregarPar("Primera");

            // Assert
            Assert.IsTrue(parAgregado);
            Assert.AreEqual(1, op.HorarioActual.Pares.Count);
            Assert.IsTrue(op.HorarioActual.Pares.LastOrDefault().Calidad.Equals("Primera"));

        }

        [TestMethod]
        public void AgregarUnParDePrimeraAunaOPEnEstadoActivaFueraDeTurnoYDentroDeLos10Minutos()
        {
            // Arrange
            op.Estado = "Pausada";
            Horario h = new Horario(t);
            op.Horarios.Add(h);
            op.HorarioActual = h;
            op.HorarioActual.Fin = DateTime.Now.AddMinutes(-5);
            //Se restan 5 min de la hora actual simulando que han pasado desde que la OP se pausó

            // Act
            bool parAgregado = op.AgregarPar("Primera");

            // Assert
            Assert.IsTrue(parAgregado);
            Assert.AreEqual(1, op.HorarioActual.Pares.Count);
            Assert.IsTrue(op.HorarioActual.Pares.LastOrDefault().Calidad.Equals("Primera"));

        }
        [TestMethod]
        public void AgregarUnParDePrimeraAunaOPEnEstadoActivaFueraDeTurnoYFueraDeLos10Minutos()
        {
            // Arrange
            op.Estado = "Pausada";
            Horario h = new Horario(t);
            op.Horarios.Add(h);
            op.HorarioActual = h;
            op.HorarioActual.Fin = DateTime.Now.AddMinutes(-10);

            //Se restan 10 min de la hora actual simulando que ha pasado el tiempo límite de operación desde que la OP se pausó

            // Act
            bool parAgregado = op.AgregarPar("Primera");

            // Assert
            Assert.IsFalse(parAgregado);
            Assert.AreEqual(0, op.HorarioActual.Pares.Count);
            Assert.IsTrue(op.HorarioActual.Pares.Count == 0);

        }

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

            _repositoryOP.Setup(r => r.GetTodos().ToList().Any(op => op.LineaDeTrabajo.Numero == lineaSeleccionada.Numero)).Returns(false);
            // Act
            _presentadorOP.Object.confirmarNuevaOrden(numero, lineaSeleccionada, fecha, color);

            // Assert
            Assert.IsTrue(op.LineaDeTrabajo.Numero == lineaSeleccionada.Numero);


        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange



            // Act


            // Assert


        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange



            // Act


            // Assert


        }

    }
}
