using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.InfraestructuraTransversal.Seguridad
{
    public sealed class FactoriaDeSesiones
    { 
        //Investigar: Patrón Singleton: https://docs.microsoft.com/en-us/previous-versions/msp-n-p/ff650849(v=pandp.10)
        #region Singleton
        //Inicialización "perezosa": https://docs.microsoft.com/en-us/dotnet/api/system.lazy-1?view=netcore-3.1
        private readonly static Lazy<FactoriaDeSesiones> _instance = new Lazy<FactoriaDeSesiones>(() => new FactoriaDeSesiones());

        /// <summary>
        /// Obtiene un singleton de la clase IoCFactory
        /// </summary>
        public static FactoriaDeSesiones Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        #endregion

        public Sesion IniciarSesion(Usuario usuario, string password)
        {
            if (Autenticar(usuario, password) == true) return new Sesion(usuario);
            else return null;
        }
        public bool Autenticar(Usuario usuario, string password)
        {
            if (usuario.Password == password) return true;
            else return false;
        }
    }
}