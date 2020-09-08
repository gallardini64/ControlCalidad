using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Dominio
{
    public abstract class Empleado : EntityBase
    {
        public int Documento { get; set; }
        public string Apellido_Nombre { get; set; }
        public string Email { get; set; }
    }
}
