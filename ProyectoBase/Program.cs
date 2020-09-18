using ProyectoBase.InfraestructuraTransversal;
using ProyectoBase.InfraestructuraTransversal.IoC;
using ProyectoBase.IoC;
using ProyectoBase.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Inicializa el contenedor de DI
            IoCFactory.Instance.SetContainer(new IoCUnityContainer());
            Reloj.CambioDeHora();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(IoCFactory.Instance.CurrentContainer.Resolve<VistaOP>());
            }
            catch (NullReferenceException)
            {

               
            }
            
        }
    }
}
