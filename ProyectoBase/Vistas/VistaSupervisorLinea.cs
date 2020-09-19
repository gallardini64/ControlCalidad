using ProyectoBase.Dominio;
using ProyectoBase.Interfaces;
using ProyectoBase.Presentadores;
using ProyectoBase.Vistas.ControlesDeUsuario;
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
    public partial class VistaSupervisorLinea : Form, IVistaOP
    {
        private PresentadorOP _presentador;
        protected int mov;
        protected int movX;
        protected int movY;
        public VistaSupervisorLinea()
        {
            InitializeComponent();
            crearOPVista1.Visible = false;
            crearOPVista1.setVista(this);
        }

        public void setPresentador(PresentadorOP presentador)
        {
            _presentador = presentador;
            
        }

        public void Cerrar()
        {
            throw new NotImplementedException();
        }

        internal void confirmarNuevaOrden(int numero,LineaDeTrabajo linea, DateTime fecha, Dominio.Color color, Modelo modelo)
        {
            _presentador.confirmarNuevaOrden(numero,linea, fecha, color, modelo);
            crearOPVista1.Cerrar();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            throw new NotImplementedException();
        }

        internal void ListarDefectos(ICollection<Defecto> defectos)
        {
            defectoBindingSource.DataSource = defectos.ToList();
        }

        public void Desplegar()
        {
            Show();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            var modelos = _presentador.getModelos();
            var colores = _presentador.getColores();
            var lineasDeTrabajo = _presentador.getLineasDeTrabajo();

            crearOPVista1.cargarModelosColoresYLineas(lineasDeTrabajo, modelos, colores);
            crearOPVista1.Show();
            _presentador.crearNuevaOrden();
        }

        private void btpausar_Click(object sender, EventArgs e)
        {
            btpausar.Visible = false;
            btFinalizar.Enabled = false;
            btReanudar.Visible = true;
            _presentador.PausarOP();
        }
        public void ActivarControles()
        {
            _presentador.ActivarControles();
            btCrear.Enabled = false;
            btpausar.Enabled = true;
            btFinalizar.Enabled = true;
        }

        public void ActivarControles(OrdenDeProduccion op)
        {
            CargarOrden(op);
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Finalizar OP", "¿desea finalizar la orden de producción?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
            {
                _presentador.FinalizarOP();
                LimpiarTabla();
            }
            
        }

        private void LimpiarTabla()
        {
           
        }

        public void DesactivarControles()
        {
           
        }

        private void btReanudar_Click(object sender, EventArgs e)
        {
            btpausar.Visible = true;
            btpausar.Enabled = true;
            btReanudar.Visible = false;
            btFinalizar.Enabled = true;
            _presentador.ReanudarOP();
        }
        #region movimiento
        private void VistaSupervisorLinea_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp(sender, e);
        }
        private void VistaSupervisorLinea_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }
        
        protected void mouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        protected void mouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        protected void mouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void VistaSupervisorLinea_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }


        #endregion
        public void CargarOrden(OrdenDeProduccion op)
        {
            btCrear.Enabled = false;
            btpausar.Enabled = false;
            btReanudar.Enabled = true;
            btFinalizar.Enabled = true;
            ListarDefectos(op.Defectos);
        }
    }
}
