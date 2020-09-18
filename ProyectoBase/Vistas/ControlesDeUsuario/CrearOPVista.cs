using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBase.Dominio;
using ProyectoBase.InfraestructuraTransversal;

namespace ProyectoBase.Vistas
{
    public partial class CrearOPVista : UserControl
    {
        private VistaSupervisorLinea _vista;
        public CrearOPVista()
        {
            InitializeComponent();
        }

        public void setVista(VistaSupervisorLinea vista)
        {
            _vista = vista;
        }



        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            limpiarCampos();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            _vista.confirmarNuevaOrden(bunifuDatepicker1.Value,
                                        (Dominio.Color)cbColor.SelectedItem,
                                        (Modelo)cbModelo.SelectedItem);
        }

        internal void cargarModelosYColor(List<Modelo> modelos, List<Dominio.Color> colores)
        {
            cbColor.DataSource = colores;
            cbModelo.DataSource = modelos;
        }

        public void limpiarCampos()
        {
            tbNumero.Clear();
            bunifuDatepicker1.Value = DateTime.Now;
        }
    }
}
