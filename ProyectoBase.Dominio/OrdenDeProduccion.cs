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

        public virtual ICollection<Horario> Horarios { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Color Color { get; set; }
        public virtual LineaDeTrabajo LineaDeTrabajo { get; set; }
        public virtual Horario HorarioActual { get; set; }

        private Estado estado;
        public OrdenDeProduccion()
        {
            Horarios = new List<Horario>();
            estado = Dominio.Estado.Activa;

        }
        public void IniciarNuevoHorario(Turno turno)
        {
            Horario h = new Horario(turno);
            Horarios.Add(h);
            HorarioActual = h;
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


        public bool AgregarDefecto(int numero,EspecificacionDeDefecto especDe, string pie, DateTime now)
        {

            if (HorarioActual.Turno.SoyTurnoActual())
            {
                HorarioActual.AgregarDefecto(numero, especDe, pie, now);
                return true;
            }
            else
            {
                if ((int)HorarioActual.Turno.HeFilalizadoHace().TotalMinutes <
                    FactoriaDeEstrategias.GetInstancia().GetEstrategiaTiempoLimite().getMinLimiteDeTiempoDeOperaciones)
                {
                    HorarioActual.AgregarDefecto(numero, especDe, pie, now);
                    return true;
                }
            }
            return false;

        }
        public void ActualizarHorasOcupadas()
        {
            Horarios.LastOrDefault().CantidadDeHorasOcupadas++;
        }
        public void QuitarDefecto(EspecificacionDeDefecto especDe)
        {
            var defecto = HorarioActual.Defectos.LastOrDefault(d => d.especificacion == especDe);
            HorarioActual.Defectos.Remove(defecto);
        }
        public void CrearNuevoHorario(Turno turnoActual)
        {
            var p = new Horario(turnoActual);
            Horarios.Add(p);
        }
        public bool ActualizarPares(int numero,string calidad)
        {
            if (HorarioActual.Turno.SoyTurnoActual())
            {
                HorarioActual.AgregarPar(numero,calidad);
                return true;
            }
            else
            {
                if ((int) HorarioActual.Turno.HeFilalizadoHace().TotalMinutes < 
                    FactoriaDeEstrategias.GetInstancia().GetEstrategiaTiempoLimite().getMinLimiteDeTiempoDeOperaciones)
                {
                    HorarioActual.AgregarPar(numero,calidad);
                    return true;
                }
            }
            return false;
        }

        public void PausarOP()
        {
            Estado = "Pausada";
            HorarioActual.Fin = DateTime.Now;
        }
    }
    
}
