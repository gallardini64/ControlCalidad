using ProyectoBase.InfraestructuraTransversal.IoC;
using ProyectoBase.Interfaces;
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
    /// <summary>
    /// Clase base para formularios
    /// <remarks>
    /// Ofrece funcionalidades comunes a todos los formularios
    /// </remarks>
    /// </summary>
    public class FormBase<T> : Form, IVistaInteractiva
    {
        protected T Presentador;
        #region Movimiento
        protected int mov;
        protected int movX;
        protected int movY;
        #endregion

        public FormBase()
        {

        }
        public FormBase(T presentador)
        {
            Presentador = presentador;
        }

        /// <summary>
        /// Navega hacia un formulario y lo visualiza como un cuadro de diálogo
        /// </summary>
        /// <typeparam name="T">Tipo del formulario</typeparam>
        protected void NavegarComoDialogo<P>()
        where P : Form
        {
            var vista = IoCFactory.Instance.CurrentContainer.Resolve<P>();
            vista?.ShowDialog();
            vista?.Dispose();
        }

        public void Cerrar()
        {
            Close();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            MessageBox.Show(mensaje, "PAV", MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.ResumeLayout(false);

        }

        protected void FormBase_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }
        protected void mouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX =e.X;
            movY =e.Y;
        }
        protected void mouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        protected void mouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
