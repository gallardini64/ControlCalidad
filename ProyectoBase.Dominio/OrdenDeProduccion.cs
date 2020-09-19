using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Dominio
{
    public class OrdenDeProduccion : EntityBase
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public virtual ICollection<Defecto> Defectos { get; set; }
        public virtual ICollection<Par> Pares { get; set; }
        public virtual ICollection<Periodo> Periodos { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Color Color { get; set; }
        public virtual LineaDeTrabajo LineaDeTrabajo { get; set; }

        private Estado estado;
        public OrdenDeProduccion()
        {
            Periodos = new List<Periodo>();
            Defectos = new List<Defecto>();
            estado = Dominio.Estado.Activa;
            Pares = new List<Par>();
        }
        public string Estado
        {
            set
            {
                if (value == "Activa")
                {
                    this.estado = Dominio.Estado.Activa;
                }
                else
                {
                    if (value == "Pausada")
                    {
                        this.estado = Dominio.Estado.Pausada;
                    }
                    else
                    {
                        this.estado = Dominio.Estado.Finalizada;
                    } 
                }
            }
            get
            {
                return estado.ToString();
            }
        }


        public void AgregarDefecto(EspecificacionDeDefecto especDe, string pie, DateTime now)
        {
            var defecto = new Defecto(especDe, pie, now);
            Defectos.Add(defecto);
        }
        public void ActualizarHorasOcupadas()
        {
            Periodos.LastOrDefault().cantidadDeHorasOcupadas++;
            // TODO //
        }

        public void QuitarDefecto(EspecificacionDeDefecto especDe)
        {
            var defecto = Defectos.LastOrDefault(d => d.especificacion == especDe);
            Defectos.Remove(defecto);
        }

        public void agregarTurno(Turno turnoActual)
        {
            var p = new Periodo(turnoActual);
            Periodos.Add(p);
        }

        public void AgregarPar(string calidad)
        {
            Par par = new Par(DateTime.Now, calidad);
            Pares.Add(par);
        }
    }
    
}
