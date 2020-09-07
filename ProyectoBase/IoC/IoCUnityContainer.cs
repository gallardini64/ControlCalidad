using ProyectoBase.Datos;
using ProyectoBase.Dominio.Contratos;
using ProyectoBase.InfraestructuraTransversal.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace ProyectoBase.IoC
{
    /// <summary>
    /// Implementación de IContainer con Unity
    /// </summary>
    public class IoCUnityContainer : IContainer
    {
        #region Miembros
        private IUnityContainer _container;
        #endregion

        #region Constructor
        public IoCUnityContainer()
        {
            ConfigurarContenedor();
        }
        #endregion

        #region Métodos Privados

        private void ConfigurarContenedor()
        {
            _container = new UnityContainer();
            _container.RegisterType<IQueryableUnitOfWork, Contexto>(new PerResolveLifetimeManager());
            _container.RegisterType(typeof(IRepository<>), typeof(Repository<>), new TransientLifetimeManager());

        }

        #endregion

        #region Miembros de IContainer
        public TService Resolve<TService>()
        {
            return _container.Resolve<TService>();
        }

        public void RegisterType(Type type)
        {
            _container.RegisterType(type);
        }
        #endregion
    }
}
