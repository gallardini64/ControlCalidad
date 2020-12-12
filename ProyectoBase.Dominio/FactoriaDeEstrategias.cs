using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Dominio
{
    public class FactoriaDeEstrategias
    {

        private static FactoriaDeEstrategias Instancia { get; set; } = null;

        public static FactoriaDeEstrategias GetInstancia()
        {
            return Instancia ?? (Instancia = new FactoriaDeEstrategias());
        }
        public EstrategiaTiempoLimite GetEstrategiaTiempoLimite() 
        {
            return new EstrategiaTiempoLimite();
        }



    }
}
