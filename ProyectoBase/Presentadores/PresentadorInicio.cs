﻿using ProyectoBase.InfraestructuraTransversal;
using ProyectoBase.InfraestructuraTransversal.IoC;
using ProyectoBase.InfraestructuraTransversal.Seguridad;
using ProyectoBase.Interfaces;
using ProyectoBase.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoBase.Presentadores
{
    public class PresentadorInicio : PresentadorBase<IVistaInicio>
    {
        
        public static VistaSupervisorLinea sup;
        public PresentadorInicio()
        {
            //EJEMPLO Reloj.RelojCambiaHora += OnCambioDeHora;
        }
        public void DesplegarVistaInicioDeSesion()
        {
            PresentadorAcceso presentadorAcceso = new PresentadorAcceso(OtorgarPermiso);
            VistaAcceso acceso = new VistaAcceso(presentadorAcceso);

            acceso.Desplegar();
        }
        public void OtorgarPermiso(object sender, Sesion sesion)
        { 
            // CONVERTIR EN CLASE ESTRATEGIA?
            if (sesion.Usuario.Rol.Id == 1)
            {
                PresentadorOP presentador = IoCFactory.Instance.CurrentContainer.Resolve<PresentadorOP>();
                presentador.AsignarSesionActual(sesion);
                VistaOP vistaOP = new VistaOP(presentador);
                vistaOP.Desplegar();
                var vistaGeneral = IoCFactory.Instance.CurrentContainer.Resolve<VistaPantallaGeneral>();
                vistaGeneral.Show();
            }

        }
        //public virtual void OnCambioDeHora(object sender, bool cambiaHora)
        //{
        //    Vista.MostrarMensaje("hola");
        //}

        //public EventHandler<bool> RelojCambiaHora;
        //public PresentadorInicio()
        //{
        //    RelojCambia();
        //}
        //public virtual void OnRelojCambia(bool cambiaHora)
        //{
        //    RelojCambiaHora.Invoke(this, true);
        //}

        //public async Task RelojCambia()
        //{
        //    while (true)
        //    {
        //        await Task.Delay(10000);
        //        OnRelojCambia(true);
        //    }
        //}
    }
}

