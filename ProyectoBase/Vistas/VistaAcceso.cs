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

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp(sender, e);
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Ingresar(tbUsuario.Text, tbPass.Text);
        }

        public void Ingresar(string username, string password)
        {
            Presentador.Ingresar(username, password);
        }

        public void desplegar()
        {
            Show();
        }
    }
}
