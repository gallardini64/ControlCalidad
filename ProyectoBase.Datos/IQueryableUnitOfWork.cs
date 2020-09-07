using ProyectoBase.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Datos
{
    /// <summary>
    /// El contrato UnitOfWork para la implementación de EF
    /// <remarks>
    /// Este contrato hereda de IUnitOfWork para su uso con código de EF. Se puede completar con
    /// cualquier funcionalidad requerida.
    /// </remarks>
    /// </summary>
    public interface IQueryableUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Devuelve una instancia de DbSet para acceder a entidades del contexto.
        /// </summary>
        /// <typeparam name="T">Cualquier clase que pueda ser persistida</typeparam>
        /// <returns>Colección de entidades del contexto</returns>
        DbSet<T> CrearSet<T>() where T : class;

        /// <summary>
        /// Marca el objeto como modificado en el contexto
        /// </summary>
        /// <typeparam name="T">Cualquier clase que pueda ser persistida</typeparam>
        /// <param name="item">El objeto a modificar</param>
        void SetModificado<T>(T item) where T : class;

        /// <summary>
        /// Refresca los cambios en el objeto desde el origen de datos
        /// </summary>
        /// <typeparam name="T">Cualquier clase que pueda ser persistida</typeparam>
        /// <param name="item">El objeto a refrescar</param>
        void Refrescar<T>(T item) where T : class;
    }
}
