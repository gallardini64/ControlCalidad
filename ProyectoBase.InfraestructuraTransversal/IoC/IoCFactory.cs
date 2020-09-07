using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.InfraestructuraTransversal.IoC
{
    public sealed class IoCFactory
    {
        //Investigar: Patrón Singleton: https://docs.microsoft.com/en-us/previous-versions/msp-n-p/ff650849(v=pandp.10)
        #region Singleton
        //Inicialización "perezosa": https://docs.microsoft.com/en-us/dotnet/api/system.lazy-1?view=netcore-3.1
        private readonly static Lazy<IoCFactory> _instance = new Lazy<IoCFactory>(() => new IoCFactory());

        /// <summary>
        /// Obtiene un singleton de la clase IoCFactory
        /// </summary>
        public static IoCFactory Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        #endregion

        #region Miembros
        IContainer _CurrentContainer;

        /// <summary>
        /// Obtiene el IConteiner configurado
        /// </summary>
        public IContainer CurrentContainer
        {
            get
            {
                if (_CurrentContainer == null)
                    throw new InvalidOperationException("Configurar el contenedor antes de usarlo");
                return _CurrentContainer;
            }
        }
        #endregion

        #region Métodos
        public void SetContainer(IContainer container)
        {
            _CurrentContainer = container;
        }
        #endregion
    }
}
