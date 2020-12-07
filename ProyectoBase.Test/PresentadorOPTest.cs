using ProyectoBase.Dominio;
using ProyectoBase.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Test
{
    public class PresentadorOPTest: Presentadores.PresentadorOP
    {
        public PresentadorOPTest(IRepository<OrdenDeProduccion> repository,
                                 IRepository < EspecificacionDeDefecto > repositoryED,
                                 IRepository < Modelo > repositorymodelo,
                                 IRepository < Color > repositorycolor,
                                 IRepository < Turno > repositoryTurno,
                                 IRepository < Empleado > repositoryEmpleado,
                                 IRepository < LineaDeTrabajo > repositoryLineaDeTrabajo)
                                :base(repository, repositoryED, repositorymodelo, repositorycolor, repositoryTurno,
                                     repositoryEmpleado, repositoryLineaDeTrabajo)
        {

        }
        public OrdenDeProduccion getOP() => _op;
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
