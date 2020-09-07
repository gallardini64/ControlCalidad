using System;

namespace ProyectoBase.Dominio
{
    public class Turno :EntityBase
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Descripcion { get; set; }
    }
}