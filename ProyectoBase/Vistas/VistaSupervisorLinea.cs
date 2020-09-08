using ProyectoBase.Dominio;
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
    public partial class VistaSupervisorLinea : Form, IVistaOP
    {
        private PresentadorOP _presentador;
        public VistaSupervisorLinea()
        {
            InitializeComponent();
        }

        public void setPresentador(PresentadorOP presentador)
        {
            _presentador = presentador;
        }

        public void Cerrar()
        {
            throw new NotImplementedException();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            throw new NotImplementedException();
        }

        internal void ListarDefectos(ICollection<Defecto> defectos)
        {
            defectoBindingSource.DataSource = defectos.ToList();
        }
    }
}
