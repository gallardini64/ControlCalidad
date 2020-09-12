using ProyectoBase.Interfaces;
using ProyectoBase.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase.Vistas
{
    public partial class VistaAcceso : FormBase<PresentadorAcceso>, IVistaAcceso
    {
        public VistaAcceso(PresentadorAcceso presentador): base(presentador)
        {
            InitializeComponent();
            Presentador.SetVista(this);
        }

        public void Ingresar(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
