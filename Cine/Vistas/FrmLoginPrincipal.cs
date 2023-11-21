using CineFront.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public partial class FrmLoginPrincipal : Form
    {
        public FrmLoginPrincipal()
        {
            InitializeComponent();
        }

        private void btnEntrarALaApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin menu = new FrmLogin();
            menu.FormClosed += MostarFormPrincipal;
            menu.Show();
        }

        private void CerrarFormPrincipal(object sender, FormClosedEventArgs e) //Evento que se va a ocurrir cuando se cierre el form
        {
            this.Close();
        }

        private void MostarFormPrincipal(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }



        private void lblNuevaCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmNuevaCuenta nuevaCuenta = new FrmNuevaCuenta();
            nuevaCuenta.FormClosed += MostarFormPrincipal;
            nuevaCuenta.Show();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del programa?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmLoginPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
