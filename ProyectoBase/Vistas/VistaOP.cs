using ProyectoBase.Dominio;
using ProyectoBase.Interfaces;
using ProyectoBase.Presentadores;
using ProyectoBase.Vistas;
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

namespace ProyectoBase
{
    public partial class VistaOP : FormBase<PresentadorOP> , IVistaOP
    {
        private List<DefectoAgregar> _panelesDefecto = new List<DefectoAgregar>();
        public VistaOP(PresentadorOP presentador) : base(presentador)
        {
            InitializeComponent();
            Presentador.SetVista(this);
            CargarDefectosDeReprocesado();
            CargarDefectosDeObservado();
            Presentador.GenerarOtraVista();
            Presentador.CargarOPPausada();
            cbPie.DataSource = Enum.GetValues(typeof(Pie));
            btAgregarParPrimera.Enabled = false;
            hermanadoVista1.setVista(this);
        }

        private void CargarDefectosDeReprocesado()
        {
                  
            List<EspecificacionDeDefecto> especificacionDeDefectos = Presentador.ObtenerEspecificacionesDefectosReprocesado();
            int cant = especificacionDeDefectos.Count;
            for (int i = 0; i < cant; i++)
            {
                DefectoAgregar panel = new DefectoAgregar();
                panel.setParametros(this, especificacionDeDefectos[i].Id);
                panel.Location = new Point(defectoAgregarRep.Location.X, defectoAgregarRep.Location.Y + 90 * i);
                pReprocesado.Controls.Add(panel);
                _panelesDefecto.Add(panel);
            }
            //bindingSourceED.DataSource = especificacionDeDefectos;
            //foreach (DataGridViewRow item in DataGridDefectos.Rows)
            //{
            //    item.Cells[2].Value = 0;
            //}
        }
        private void CargarDefectosDeObservado()
        {
            List<EspecificacionDeDefecto> especificacionDeDefectos = Presentador.ObtenerEspecificacionesDefectosObservado();
            int cant = especificacionDeDefectos.Count;
            for (int i = 0; i < cant; i++)
            {
                DefectoAgregar panel = new DefectoAgregar();
                panel.setParametros(this, especificacionDeDefectos[i].Id);
                panel.Location = new Point(defectoAgregarObs.Location.X, defectoAgregarRep.Location.Y + 90 * i);
                pObservado.Controls.Add(panel);
                _panelesDefecto.Add(panel);
            }
        }

        internal void QuitarPar(string calidad)
        {
            Presentador.quitarPar(calidad);
        }

        internal void agregarPar(string calidad)
        {
            Presentador.AgregarPar(calidad);
        }

        public void Desplegar()
        {
            Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            int id = (int)DataGridDefectos.SelectedRows[0].Cells[3].Value;
            string pie = cbPie.Text;
            AgregarDefecto(id,pie);
        }
        public void AgregarDefecto(int id, string pie)
        {
            Presentador.AgregarDefecto(id, pie);
            //agregarDefectoATabla();
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

        internal void FinalizarHermanado()
        {
            hermanadoVista1.Visible = false;
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
            foreach (DefectoAgregar item in _panelesDefecto)
            {
                item.Activar();
            }
            btAgregarParPrimera.Enabled = true;
            btQuitarParPrimera.Enabled = true;
            tbOpNum.Text = op.Numero.ToString();
            tbFec.Text = op.Fecha.ToString();
            tbTurno.Text = Presentador.ObtenerTurnoActual().ToString();
        }

        public void DesactivarControles()
        {
            foreach (DefectoAgregar item in _panelesDefecto)
            {
                item.Desactivar();
            }
            btAgregarParPrimera.Enabled = false;
            btQuitarParPrimera.Enabled = false;
            btHermanado.Enabled = true;
        }

        private void btParPrimera_Click(object sender, EventArgs e)
        {
            agregarParPrimera();
        }
       
        public void agregarParPrimera()
        {
            Presentador.AgregarPar("Primera");
        }

        private void btHermanado_Click(object sender, EventArgs e)
        {
            hermanadoVista1.Visible = true;
        }

        public void CargarOrden(OrdenDeProduccion op)
        {
            
        }

        #region Movimiento
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


        #endregion
        public void LimpiarCamposOP()
        {
            tbFec.Text = "";
            tbOpNum.Text = "";
            tbTurno.Text = "";
        }



    }
}
