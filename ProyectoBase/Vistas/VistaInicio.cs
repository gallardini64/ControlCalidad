using ProyectoBase.InfraestructuraTransversal.IoC;
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
    public partial class VistaInicio : FormBase<PresentadorInicio>, IVistaInicio
    {
        private VistaAcceso acceso;
        public VistaInicio(PresentadorInicio presentador): base(presentador)
        {
            InitializeComponent();
            Presentador.SetVista(this);
            acceso = IoCFactory.Instance.CurrentContainer.Resolve<VistaAcceso>();
            acceso.desplegar();
            
        }

        private void VistaInicio_Load(object sender, EventArgs e)
        {
            Hide();
        }
        protected override void SetVisibleCore(bool value)
        {
            if (!this.IsHandleCreated)
            {
                value = false;
                CreateHandle();
            }
            base.SetVisibleCore(value);
        }
    }
}
