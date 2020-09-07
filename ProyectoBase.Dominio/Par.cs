using System;

namespace ProyectoBase.Dominio
{
    public class Par
    {
        public DateTime Hora { get; set; }

        private Calidad calidad;

        public String Calidad
        {
            set
            {
                if (value == "Primera")
                {
                    this.calidad = Dominio.Calidad.Primera;
                }
                else
                {
                    this.calidad = Dominio.Calidad.Segunda;
                }
            }
            get
            {
                return calidad.ToString();
            }
        }


    }
}