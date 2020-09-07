using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.InfraestructuraTransversal.IoC
{
    /// <summary>
    /// Contrato base para registrar y resolver dependencias
    /// </summary>
    public interface IContainer
    {
        TService Resolve<TService>();
        void RegisterType(Type type);
    }
}
