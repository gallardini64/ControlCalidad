using ProyectoBase.Dominio;
using ProyectoBase.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Datos
{
    /// <summary>
    /// Implementación del patrón Repository de forma genérica
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T>
        where T : EntityBase
    {
        #region Members
        private readonly IQueryableUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        /// <summary>
        /// Crea una nueva instancia del repositorio
        /// </summary>
        /// <param name="unitOfWork">Unit of Work asociada</param>
        public Repository(IQueryableUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException("unitOfWork");
        }
        #endregion

        public IUnitOfWork UnitOfWork => _unitOfWork;   

        public void Agregar(T item)
        {
            if (item != null)
            {
                GetSet().Add(item);
            }
        }

        public void Quitar(T item)
        {
            if (item != null)
            {
                GetSet().Remove(item);
            }
        }

        public void Modificar(T item)
        {
            if (item != null)
            {
                _unitOfWork.SetModificado(item);
            }
        }

        public T Get(int id)
        {
            return id != 0 ? GetSet().Find(id) : null;
        }

        public IEnumerable<T> GetTodos()
        {
            return GetSet();
        }

        public IEnumerable<T> GetConFiltro(Expression<Func<T, bool>> filtro)
        {
            return GetSet().Where(filtro);
        }

        public void DescartarCambios()
        {
            _unitOfWork.RevertirCambios();
        }

        public void Refrescar(T item)
        {
            if (item != null)
            {
                _unitOfWork.Refrescar(item);
            }
        }

        #region IDisposable Miembros
        /// <summary>
        /// <see cref="M:System.IDisposable.Dispose"/>
        /// </summary>
        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }
        #endregion

        #region Métodos Privados

        IDbSet<T> GetSet()
        {
            return _unitOfWork.CrearSet<T>();
        }
        #endregion
    }
}
