using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Presentadores
{
    // Todos los presentadores deben heredar de presentador Base
    public abstract class PresentadorBase<T>
    {
        protected T Vista;

        public void SetVista(T vista)
        {
         
            Vista = vista;
        }
    }
}
