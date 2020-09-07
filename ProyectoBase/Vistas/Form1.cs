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
    public partial class Form1 : FormBase<PresentadorEjemplo> , IEjemplo
    {
        

        public Form1(PresentadorEjemplo presentador) : base(presentador)
        {
            InitializeComponent();
            Presentador.SetVista(this);
        }
    }
}
