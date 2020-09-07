using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Dominio.Contratos
{
    /// <summary>
    /// Contrato de Repositorio basado en el patrón Repository
    /// </summary>
    /// <example>Ver Guía de Arquitectura N-Capas Orientada al Dominio con .NET 4.0 - Pag. 102</example>
    /// <remarks>
    /// Implementación parcial del patrón
    /// </remarks>
    /// <typeparam name="T">Cualquier entidad del dominio que herede de EntityBase</typeparam>
    public interface IRepository<T> : IDisposable
        where T : EntityBase
    {
        IUnitOfWork UnitOfWork { get; }
        void Agregar(T item);
        void Quitar(T item);
        void Modificar(T item);
        T Get(int id);
        IEnumerable<T> GetTodos();
        IEnumerable<T> GetConFiltro(Expression<Func<T, bool>> filtro);
        void DescartarCambios();
        void Refrescar(T item);
    }
}
