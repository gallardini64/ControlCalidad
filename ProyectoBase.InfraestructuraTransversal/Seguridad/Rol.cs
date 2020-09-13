using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.InfraestructuraTransversal.Seguridad
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Rol(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
