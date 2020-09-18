﻿using ProyectoBase.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Interfaces
{
    public interface IVistaOP: IVistaInteractiva
    {
        void Desplegar();
        void ActivarControles(OrdenDeProduccion op);
        void DesactivarControles();
    }
}
