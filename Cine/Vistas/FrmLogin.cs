using CineBack.Entidades;
using CineFront.Servicios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CineFront.Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario userLogeando = new Usuario();
                userLogeando.User = txtUsuario.Text.ToString();
                userLogeando.Pass = Conversor.ConvertirSha256(txtContraseña.Text);

                string url = $"https://localhost:7095/login?usuario={userLogeando.User}&pass={userLogeando.Pass}";

                var cliente = await ClienteSingleton.GetInstancia().GetAsync(url);

                Usuario user = JsonConvert.DeserializeObject<Usuario>(cliente);

                if (user.Cliente.IdCliente != 0)
                {
                    if (user.Rol == "user")
                    {
                        IniciarSesion(user.Cliente);
                    }
                    else if (user.Rol == "admin")
                    {
                        IniciarSesionGerente();
                    }

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Text = string.Empty;
                    txtContraseña.Text = string.Empty;
                    txtUsuario.Focus();
                }
            }

        }

        private void IniciarSesionGerente()
        {
            this.Hide();
            FrmMenuPrincipalGerente gerente = new FrmMenuPrincipalGerente();
            gerente.FormClosed += Logout;
            gerente.Show();
        }

        private void IniciarSesion(Cliente cliente)
        {
            this.Hide();
            FrmMenuPrincipal menu = new FrmMenuPrincipal(cliente);
            menu.FormClosed += Logout;
            menu.Show();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private void Logout(object sender, FormClosedEventArgs e) //Evento que se va a ocurrir cuando se cierre el form
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtUsuario.Focus();
            this.Show();
        }

        private void piCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxOcultar_Click(object sender, EventArgs e)
        {
            picBoxMostrar.BringToFront();
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void picBoxMostrar_Click(object sender, EventArgs e)
        {
            picBoxOcultar.BringToFront();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
            Limpieza();
            txtUsuario.Focus();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void Limpieza()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
