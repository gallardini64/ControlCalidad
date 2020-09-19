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
    public partial class VistaPantallaGeneral : FormBase<PresentadorVistaGeneral>, IVistaGeneral
    {
        public VistaPantallaGeneral(PresentadorVistaGeneral presentador) : base(presentador)
        {
            InitializeComponent();
            Presentador.SetVista(this);
        }
        public void AgregarDefecto(Defecto d)
        {

        }



    }
}
