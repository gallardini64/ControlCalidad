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
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {

        }

        public void DesactivarControles()
        {
            throw new NotImplementedException();
        }

        private void btReanudar_Click(object sender, EventArgs e)
        {
            btpausar.Visible = true;
            btReanudar.Visible = true;
            _presentador.ReanudarOP();
        }
    }
}
