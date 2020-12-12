using System;
using System.Runtime.Remoting.Messaging;

namespace ProyectoBase.Dominio
{
    public class Turno :EntityBase
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }

        public override string ToString()
        {
            return $"{ Inicio.Hour + " " +  Fin.Hour}";
        }
        public bool SoyTurnoActual()
        {
            if (DateTime.Now.Ticks >= Inicio.Ticks && DateTime.Now.Ticks <= Fin.Ticks) return true;
            else return false;
        }
        public TimeSpan HeFilalizadoHace()
        {
            return DateTime.Now.Subtract(Fin);
        }
    }
}