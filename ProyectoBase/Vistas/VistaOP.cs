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
            CargarDefectos();
            Presentador.GenerarOtraVista();
            cbPie.DataSource = Enum.GetValues(typeof(Pie));
            btAgregar.Enabled = false;
            btQuitar.Enabled = false;
            btParPrimera.Enabled = false;
        }

        private void CargarDefectos()
        {
            var especificacionDeDefectos = Presentador.ObtenerEspecificacionesDefectos();
            bindingSourceED.DataSource = especificacionDeDefectos;
            foreach (DataGridViewRow item in DataGridDefectos.Rows)
            {
                item.Cells[2].Value = 0;
            }
            
        }

        public void Desplegar()
        {
            Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            int id = (int)DataGridDefectos.SelectedRows[0].Cells[3].Value;
            var pie = cbPie.Text;
            Presentador.AgregarDefecto(id, pie);
            agregarDefectoATabla();
        }
        private void quitar_Click(object sender, EventArgs e)
        {
            int id = (int)DataGridDefectos.SelectedRows[0].Cells[3].Value;
            Presentador.QuitarDefecto(id);
            quitarDefectoDeTabla();
        }
        private void agregarDefectoATabla()
        {
            var rowselected = DataGridDefectos.SelectedRows;
            if (rowselected[0].Cells[2].Value == null)
            {
                rowselected[0].Cells[2].Value = 0;
            }
            int contador = (int)rowselected[0].Cells[2].Value;
            contador++;
            rowselected[0].Cells[2].Value = contador;
        }
        private void quitarDefectoDeTabla()
        {
            var rowselected = DataGridDefectos.SelectedRows;
            if (rowselected[0].Cells[2].Value == null)
            {
                rowselected[0].Cells[2].Value = 0;
            }
            if ((int)rowselected[0].Cells[2].Value != 0)
            {
                int contador = (int)rowselected[0].Cells[2].Value;
                contador--;
                rowselected[0].Cells[2].Value = contador;
            }
        }

        private void VistaOP_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp(sender, e);
        }

        private void VistaOP_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }

        private void VistaOP_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Cerrar();
            }
            catch (Exception)
            {

               
            }
            
        }

        public void ActivarControles(OrdenDeProduccion op)
        {
            btAgregar.Enabled = true;
            btQuitar.Enabled = true;
            btParPrimera.Enabled = true;
            tbOpNum.Text = op.Numero.ToString();
            tbFec.Text = op.Fecha.ToString();
            tbTurno.Text = op.Periodos.LastOrDefault().Turno.ToString();
        }

        public void DesactivarControles()
        {
            btAgregar.Enabled = false;
            btQuitar.Enabled = false;
            btHermanado.Enabled = true;
        }
    }
}
