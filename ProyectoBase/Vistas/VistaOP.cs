using ProyectoBase.Dominio;
using ProyectoBase.Interfaces;
using ProyectoBase.Presentadores;
using ProyectoBase.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class VistaOP : FormBase<PresentadorOP> , IVistaOP
    {
       
        public VistaOP(PresentadorOP presentador) : base(presentador)
        {
            InitializeComponent();
            Presentador.SetVista(this);
            Presentador.GenerarOtraVista();
            comboBox1.DataSource = Enum.GetValues(typeof(Pie));
            
        }

        public void Desplegar()
        {
            Show();
        }

        private void buttonMas1_Click(object sender, EventArgs e)
        {
            Presentador.AgregarDefecto(1, comboBox1.Text);
        }

       
    }
}
