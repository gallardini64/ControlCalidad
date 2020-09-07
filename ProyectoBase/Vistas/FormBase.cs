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
    }
}
