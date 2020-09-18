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
            LimpiarCampos();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            _vista.confirmarNuevaOrden(int.Parse(tbNumero.Text),
                                        (LineaDeTrabajo) cbLinea.SelectedValue,dpFecha.Value,
                                        (Dominio.Color)cbColor.SelectedItem,
                                        (Modelo)cbModelo.SelectedItem);
            _vista.ActivarControles();
        }

        internal void cargarModelosColoresYLineas(List<LineaDeTrabajo> lineas,List<Modelo> modelos, List<Dominio.Color> colores)
        {
            cbColor.DataSource = colores;
            cbModelo.DataSource = modelos;
            cbLinea.DataSource = lineas;
        }

        public void LimpiarCampos()
        {
            tbNumero.Clear();
            dpFecha.Value = DateTime.Now;
        }
        public void Cerrar()
        {
            LimpiarCampos();
            this.Hide();
        }
    }
}
