using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoBase.Dominio
{
    public class Horario : EntityBase
    {
        public int CantidadDeHorasOcupadas { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public virtual Turno Turno { get; set; }
        public virtual ICollection<Defecto> Defectos { get; set; }
        public virtual ICollection<Par> Pares { get; set; }


        public Horario()
        {
        }
        public Horario(Turno turno)
        {
            Defectos = new List<Defecto>();
            Pares = new List<Par>();
            Turno = turno;
        }
        public void AgregarPar(int numero,string calidad)
        {
            if(numero > 0)
            {
                Par par = new Par(DateTime.Now, calidad);
                Pares.Add(par);
            }
            if (numero < 0)
            {
                var par = Pares.ToList().LastOrDefault(p => p.Calidad.Equals(calidad));
                Pares.Remove(par);
            }
        }


        public void AgregarDefecto(int numero,EspecificacionDeDefecto especDe, string pie, DateTime now)
        {
            if (numero > 0)
            {
                var defecto = new Defecto(especDe, pie, now);
                Defectos.Add(defecto);
            }
            if (numero < 0)
            {
                var defecto = Defectos.ToList().LastOrDefault(d => d.especificacion == especDe);
                Defectos.Remove(defecto);
            }
        }
        public void QuitarDefecto(EspecificacionDeDefecto especDe)
        {

        }
    }
}