using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Dominio
{
    /// <summary>
    /// Clase base para las entidades del dominio
    /// Todas las clases que desean ser persistidas deben extender de EntityBase
    /// </summary>
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }

        public virtual bool IsNew()
        {
            return Id == 0;
        }
    }
}
