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

        private void VistaInicio_Load(object sender, EventArgs e)
        {
          Hide();
        }

    }
}
