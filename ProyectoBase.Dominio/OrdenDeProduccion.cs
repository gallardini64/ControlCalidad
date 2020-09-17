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
        public ICollection<Defecto> Defectos { get; set; }
        public ICollection<Par> Pares { get; set; }
        public ICollection<Periodo> Periodos { get; set; }
        public Modelo Modelo { get; set; }
        public Color Color { get; set; }
        
        private Estado estado;
        public OrdenDeProduccion()
        {
            Defectos = new List<Defecto>();
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
        public LineaDeTrabajo LineaDeTrabajo { get; set; }

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
    }
    
}
