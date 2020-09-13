using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.InfraestructuraTransversal
{
    public static class Reloj
    {
        public static EventHandler<bool> RelojCambiaHora;

        public static void OnRelojCambia(bool cambiaHora)
        {
            RelojCambiaHora?.Invoke(typeof(Reloj), cambiaHora);
        }

        public static async Task CambioDeHora()
        {
            while (true)
            {
                await Task.Delay((60 - DateTime.Now.Minute)*60* 1000); //(min)*60(seg/min)*(1000ms/seg)
                OnRelojCambia(true);
            }
        }


    }
}
