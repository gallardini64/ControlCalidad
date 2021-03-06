﻿using System;

namespace ProyectoBase.Dominio
{
    public class Par : EntityBase
    {
        public DateTime Hora { get; set; }

        private Calidad calidad;

        public Par()
        {

        }
        public Par(DateTime now, string calidad)
        {
            Hora = now;
            Calidad = calidad;
        }

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