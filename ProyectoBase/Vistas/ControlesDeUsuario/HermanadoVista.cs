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
    public partial class HermanadoVista : UserControl
    {
        private VistaOP _vista;
        private int contadorPrimera;
        private int contadorSegunda;
        public HermanadoVista()
        {
            InitializeComponent();
        }

        private void btAgregarPrimera_Click(object sender, EventArgs e)
        {
            _vista.agregarPar(Dominio.Calidad.Primera.ToString());
            
            if (lbContadorPrimera.Text == "0")
            {
                contadorPrimera = 0;
            }
            contadorPrimera++;
            lbContadorPrimera.Text = contadorPrimera.ToString();
        }

        internal void setVista(VistaOP vistaOP)
        {
            _vista = vistaOP;
        }

        private void btQuitarPrimera_Click(object sender, EventArgs e)
        {
            

            if (lbContadorPrimera.Text == "0")
            {
                contadorPrimera = 0;

            }
            else
            {
                _vista.QuitarPar(Dominio.Calidad.Primera.ToString());
                contadorPrimera--;
                lbContadorPrimera.Text = contadorPrimera.ToString();
            }
            
        }

        private void btAgregarSegunda_Click(object sender, EventArgs e)
        {
            _vista.agregarPar(Dominio.Calidad.Segunda.ToString());

            if (lbContadorSegunda.Text == "0")
            {
                contadorSegunda = 0;
            }
            contadorSegunda++;
            lbContadorSegunda.Text = contadorSegunda.ToString();
        }

        private void btQuitarSegunda_Click(object sender, EventArgs e)
        {
            if (lbContadorSegunda.Text == "0")
            {
                contadorSegunda = 0;
            }
            else
            {
                _vista.QuitarPar(Dominio.Calidad.Segunda.ToString());
                contadorSegunda--;
                lbContadorSegunda.Text = contadorSegunda.ToString();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            _vista.FinalizarHermanado();
        }
    }
}
