using System;

namespace ProyectoBase.Dominio
{
    public class Turno :EntityBase
    {
        public int Inicio { get; set; }
        public int Fin { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}