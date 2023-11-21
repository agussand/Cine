using CineBack.Entidades;
using CineFront.Servicios;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Vistas
{
    public partial class FrmNuevaCuenta : Form
    {
        Usuario nuevoUsuario = null;
        public FrmNuevaCuenta()
        {
            InitializeComponent();
            nuevoUsuario = new Usuario();
        }

        private void FrmNuevaCuenta_Load(object sender, EventArgs e)
        {
            CargarEdades();
            txtPass.UseSystemPasswordChar = true;
            txtConfirmarPass.UseSystemPasswordChar = true;
        }

        private void CargarEdades()
        {
            for (int i = 10; i < 99; i++)
            {
                cboEdad.Items.Add(i.ToString());
            }
        }




        private async Task<bool> ValidarAsync()
        {
            if (!VerificarCliente())
            {
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese un usuario", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool usuarioExistente = await VerificarUsusario(txtUsuario.Text.ToString());

            if (!usuarioExistente)
            {
                MessageBox.Show("Nombre de ususario ya utilizado, ingrese uno diferente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Focus();
                //Puede mostrar algo mas para verificar la contraseña
            }
            if (!txtPass.Text.Equals(txtConfirmarPass.Text))
            {
                MessageBox.Show("Las contraseñas deben ser iguales", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarPass.Text = string.Empty;
                txtPass.Focus();
                return false;
            }
            return true;
        }

        private bool VerificarCliente()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))//Tendria q verificar q no ingrese numeros
            {
                MessageBox.Show("Ingrese un nombre válido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text.ToString()))//Tendria q verificar q no ingrese numeros
            {
                MessageBox.Show("Ingrese un apellido válido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtContacto.Text.ToString()))
            {
                MessageBox.Show("Ingrese un contacto válido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("Ingrese un número de DNI válido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(cboEdad.Items[cboEdad.SelectedIndex].ToString(), out _))
            {
                MessageBox.Show("Ingrese una edad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async Task<bool> VerificarUsusario(string user)
        {
            bool validacion;
            string url = $"https://localhost:7095/usuario?usuario={txtUsuario.Text}";
            var res = await ClienteSingleton.GetInstancia().GetAsync(url);
            validacion = JsonConvert.DeserializeObject<bool>(res);
            return validacion;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            bool validacion = await ValidarAsync();
            if (validacion)
            {
                nuevoUsuario.User = txtUsuario.Text;
                nuevoUsuario.Pass = txtPass.Text;
                nuevoUsuario.Pass = Conversor.ConvertirSha256(nuevoUsuario.Pass);
                nuevoUsuario.Cliente.Nombre = txtNombre.Text;
                nuevoUsuario.Cliente.Apellido = txtApellido.Text;
                nuevoUsuario.Cliente.Contacto = txtContacto.Text;
                //Dependiendo la edad el tipo de cliente
                nuevoUsuario.Cliente.Dni = int.Parse(txtDni.Text.ToString());

                string url = "https://localhost:7095/RegistrarCliente";
                string userJson = JsonConvert.SerializeObject(nuevoUsuario);

                string resultado = await ClienteSingleton.GetInstancia().PostAsync(url, userJson);

                bool creado;

                creado = JsonConvert.DeserializeObject<bool>(resultado);

                if (creado)
                {
                    MessageBox.Show($"¡Bienvenid@ {nuevoUsuario.Cliente.Nombre}!", "Usuario creado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }



            }
        }

        private void picBoxOcultar_Click(object sender, EventArgs e)
        {
            picBoxMostrar.BringToFront();
            txtPass.UseSystemPasswordChar = false;
        }

        private void picBoxMostrar_Click(object sender, EventArgs e)
        {
            picBoxOcultar.BringToFront();
            txtPass.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del programa?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
