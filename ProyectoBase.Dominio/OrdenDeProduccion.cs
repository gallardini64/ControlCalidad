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
        public IEnumerable<Defecto> Defectos { get; set; }
        public IEnumerable<Par> Pares { get; set; }
        public IEnumerable<Periodo> Periodos { get; set; }
        public Modelo Modelo { get; set; }
        public Color Color { get; set; }
        private Estado estado;

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

    }
    
}
