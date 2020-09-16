using ProyectoBase.InfraestructuraTransversal.IoC;
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
    public partial class VistaInicio : FormBase<PresentadorInicio>, IVistaInicio
    {
        public VistaInicio(PresentadorInicio presentador): base(presentador)
        {
            InitializeComponent();
            Presentador.SetVista(this);
            Presentador.DesplegarVistaInicioDeSesion();
        }

        public void Ocultar()
        {
            Hide();
            this.Opacity = 0;
            this.ShowInTaskbar = false;
        }

        private void VistaInicio_Load(object sender, EventArgs e)
        {
            Ocultar();
            
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }
    }
}
