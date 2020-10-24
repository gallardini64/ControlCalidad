using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase.Vistas.ControlesDeUsuario
{
    public partial class DefectoAgregar : UserControl
    {
        private VistaOP _vistaOP;
        private int _id;
        public DefectoAgregar()
        {
            InitializeComponent();
        }
        public void Desactivar()
        {
            btnAgregarDefectoDer.Enabled = false;
            btnAgregarDefectoIzq.Enabled = false;
            btnQuitarDefectoDer.Enabled = false;
            btnQuitarDefectoIzq.Enabled = false;
        }
        public void Activar()
        {
            btnAgregarDefectoDer.Enabled = true;
            btnAgregarDefectoIzq.Enabled = true;
            btnQuitarDefectoDer.Enabled = true;
            btnQuitarDefectoIzq.Enabled = true;
        }
        public void setParametros(VistaOP vistaOP, int id)
        {
            _vistaOP = vistaOP;
            _id = id;
            lbDefecto.Text = "Defecto " + _id;
        }
        public void btQuitar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarDefectoDer_Click(object sender, EventArgs e)
        {
            _vistaOP.AgregarDefecto(_id, "DERECHO");
        }

        private void btnAgregarDefectoIzq_Click(object sender, EventArgs e)
        {
            _vistaOP.AgregarDefecto(_id,"IZQUIERDO");
        }
    }
}
