using ProyectoBase.Dominio;
using ProyectoBase.Dominio.Contratos;
using ProyectoBase.Interfaces;
using ProyectoBase.Presentadores;
using ProyectoBase.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class PresentadorOPTest : PresentadorOP
    {
        public PresentadorOPTest(IRepository<OrdenDeProduccion> repository,
                                 IRepository<EspecificacionDeDefecto> repositoryED,
                                 IRepository<Modelo> repositorymodelo,
                                 IRepository<Color> repositorycolor,
                                 IRepository<Turno> repositoryTurno,
                                 IRepository<Empleado> repositoryEmpleado,
                                 IRepository<LineaDeTrabajo> repositoryLineaDeTrabajo)
                                : base(repository, repositoryED, repositorymodelo, repositorycolor, repositoryTurno,
                                     repositoryEmpleado, repositoryLineaDeTrabajo)
        {

        }
        public PresentadorOPTest()
        {

        }
        public OrdenDeProduccion getOP() => _op;
        public void setVistaSupervisor(IVistaSupervisorDeLinea vista)
        {
            _vistaSL = vista;
        }
        public void setRepositorio(IRepository<OrdenDeProduccion> repository)
        {
            _repository = repository;
        }
        public void setOP(OrdenDeProduccion item)
        {
            _op = item;
        }
        public void setRepositorioTurno(IRepository<Turno> repositoryTurno)
        {
            _repositoryTurno = repositoryTurno;
        }

    }
}
