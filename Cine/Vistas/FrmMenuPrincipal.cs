using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Vistas
{
    public partial class FrmMenuPrincipal : Form
    {
        private Cliente Cliente;
        int cont = 0;
        int cont2 = 0;
        public FrmMenuPrincipal(Cliente cliente)
        {
            InitializeComponent();
            Cliente = cliente;
        }

        private void PersonalizarDiseño()
        {
            //ocultar paneles de submenú
            panelArchivo.Visible = false;
            panelSoporte.Visible = false;
            //panelTransaccion.Visible = false;
            //panelReportes.Visible = false;
            panelAcercaDe.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelArchivo.Visible == true)
                panelArchivo.Visible = false;
            if (panelSoporte.Visible == true)
                panelSoporte.Visible = false;
            //if (panelTransaccion.Visible == true)
            //    panelTransaccion.Visible = false;
            //if (panelReportes.Visible == true)
            //    panelReportes.Visible = false;
            if (panelAcercaDe.Visible == true)
                panelAcercaDe.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            PersonalizarDiseño();
            lblBienvenida.Text = $"¡Hola {Cliente.Nombre}!";
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            FrmSalir mens = new FrmSalir();
            mens.Show();
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            cont++;
            cont2++;
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //if (cont == 600)
            //{
            //    Pic.Visible = true;
            //}
        }

        //archivos
        private void btnArchivo_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(panelArchivo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmSalir mens = new FrmSalir();
            mens.Show();
            OcultarSubMenu();
        }

        //soporte
        private void btnSoporte_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSoporte);
        }

        private void btnButacas_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new FrmFunciones(Cliente));
            //FrmFunciones fun = new FrmFunciones();
            //fun.Show();
            OcultarSubMenu();
        }

        //transaccion

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            //MostrarSubMenu(panelTransaccion);
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new FrmInsertarPelicula());
            //FrmInsertarPelicula pel = new FrmInsertarPelicula();
            //pel.Show();
            OcultarSubMenu();
        }

        //reportes

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            //MostrarSubMenu(panelReportes);
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {

        }

        //acerca de..
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelAcercaDe);
        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new FrmIntegrantes());
            //FrmIntegrantes inte = new FrmIntegrantes();
            //inte.Show();
            OcultarSubMenu();
        }


        private Form activeForm = null;
        private void AbrirFormSecundario(Form childFrom)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childFrom);
            panelChildForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
