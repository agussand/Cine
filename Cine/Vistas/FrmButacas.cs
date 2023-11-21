using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
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

namespace CineFront.Vistas
{
    public partial class FrmButacas : Form
    {
        private Funcion oFuncion;
        private IFuncionDao servicio;
        private Venta nuevaVenta;
        private int cantIngresada;
        private int butacasSeleccionadas = 0;
        private string[] formasPago = { "Efectivo", "Débito", "Crédito" };

        public FrmButacas(Funcion funcion, int cantidad, Venta venta)
        {
            InitializeComponent();
            servicio = new FuncionDao();
            nuevaVenta = venta;
            oFuncion = funcion;
            cantIngresada = cantidad;
        }

        private async void CargarButacas()
        {
            OrdenarControles();

            string url = $"https://localhost:7095/butacas?sala={oFuncion.oSala.IdSala}&funcion={oFuncion.FuncionId}";
            var resp = await ClienteSingleton.GetInstancia().GetAsync(url);
            oFuncion.oSala.lButacas = JsonConvert.DeserializeObject<List<Butaca>>(resp);

            Butaca[] arrButacas = oFuncion.oSala.lButacas.ToArray();

            for (int i = 0; i < pnButacas.Controls.Count; i++)
            {
                pnButacas.Controls[i].Tag = arrButacas[i]; //Almacena una Butaca en el control
                pnButacas.Controls[i].Text = arrButacas[i].FilaCol;
                if (arrButacas[i].Estado == Estado.Libre)
                {
                    pnButacas.Controls[i].BackColor = Color.Lime;
                }
                else if (arrButacas[i].Estado == Estado.Ocupado)
                {
                    pnButacas.Controls[i].Enabled = false;
                    pnButacas.Controls[i].BackColor = Color.Red;
                }
                else
                {
                    pnButacas.Controls[i].Enabled = false;
                    pnButacas.Controls[i].BackColor = Color.Red;
                }
                pnButacas.Controls[i].Click += Butaca_Color;
                pnButacas.Controls[i].Click += SelecButacas_Click;
            }
        }


        private void SelecButacas_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Butaca butaca)
            {
                Entrada nuevaEntrada = new Entrada(butaca);
                if (nuevaVenta.AgregarEntrada(nuevaEntrada))
                {
                    dgvButacasSeleccionadas.Rows.Clear();
                    foreach (Entrada entrada in nuevaVenta.lEntradas)
                    {
                        dgvButacasSeleccionadas.Rows.Add(new object[] { entrada.Butaca.FilaCol, entrada.Precio });
                    }
                    butacasSeleccionadas++;
                    lblButacasSelecc.Text = $"Butacas seleccionadas: {butacasSeleccionadas}/{cantIngresada}";
                    CalcularTotales();
                }
                else
                {
                    dgvButacasSeleccionadas.Rows.Clear();
                    nuevaVenta.QuitarEntrada(nuevaEntrada);
                    foreach (Entrada entrada in nuevaVenta.lEntradas)
                    {
                        dgvButacasSeleccionadas.Rows.Add(new object[] { entrada.Butaca.FilaCol, entrada.Precio });
                    }
                    butacasSeleccionadas--;
                    lblButacasSelecc.Text = $"Butacas seleccionadas: {butacasSeleccionadas.ToString()}/{cantIngresada}";
                    CalcularTotales();
                }
            }
        }

        private void Butaca_Color(object sender, EventArgs e)
        {
            Button botonSeleccionado = (Button)sender;
            if (botonSeleccionado.BackColor == Color.Yellow)
            {
                botonSeleccionado.BackColor = Color.Lime;
            }
            else
            {
                botonSeleccionado.BackColor = Color.Yellow;
            }
        }

        private void OrdenarControles()
        {
            List<Button> listaBotones = pnButacas.Controls.OfType<Button>().ToList();
            listaBotones = listaBotones.OrderBy(b => int.Parse(b.Text)).ToList();
            pnButacas.Controls.Clear();
            pnButacas.Controls.AddRange(listaBotones.ToArray());
        }

        private void btnBorrarSeleccion_Click(object sender, EventArgs e)
        {
            dgvButacasSeleccionadas.Rows.Clear();
            nuevaVenta.lEntradas.Clear();
            foreach (Entrada entrada in nuevaVenta.lEntradas)
            {
                dgvButacasSeleccionadas.Rows.Add(new object[] { entrada.Butaca.FilaCol, entrada.Precio });
            }
            foreach (Button b in pnButacas.Controls)
            {
                if (b.BackColor == Color.Yellow)
                {
                    b.BackColor = Color.Lime;
                }
            }
            pnButacas.Enabled = true;
            butacasSeleccionadas = 0;
            lblButacasSelecc.Text = $"Butacas seleccionadas: {butacasSeleccionadas.ToString()}/{cantIngresada}";
            btnBorrarSeleccion.Enabled = false;
        }

        private void lblButacasSelecc_TextChanged(object sender, EventArgs e)
        {
            if (butacasSeleccionadas == cantIngresada)
            {
                pnButacas.Enabled = false;
                btnBorrarSeleccion.Enabled = true;
            }
        }

        private void CalcularTotales()
        {
            txtTotal.Text = nuevaVenta.CalcularTotal().ToString();
        }

        private void FrmButacas_Load(object sender, EventArgs e)
        {
            CargarButacas();
            CargarComboFP();
            lblButacasSelecc.Text += $"0/{cantIngresada}";
            this.Text += oFuncion.oSala.IdSala.ToString();
            lblPelicula.Text = oFuncion.Pelicula.Titulo;
            lblHora.Text = oFuncion.HoraMostrar;
        }

        private void CargarComboFP()
        {
            cboFormasPago.Items.AddRange(formasPago);
        }

        private async void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                foreach (Entrada entrada in nuevaVenta.lEntradas)
                {
                    entrada.Funcion = oFuncion;
                }

                string ventaJson = JsonConvert.SerializeObject(nuevaVenta);
                string url = "https://localhost:7095/nuevaVenta";
                var respuesta = await ClienteSingleton.GetInstancia().PostAsync(url, ventaJson);

                bool validacion = JsonConvert.DeserializeObject<bool>(respuesta);
                if (validacion)
                {
                    MessageBox.Show("Venta realizada con éxito!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la venta", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool Validar()
        {
            if (butacasSeleccionadas < cantIngresada)
            {
                MessageBox.Show("Le faltan butacas por asignar!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboFormasPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una forma de pago!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar su compra?", "Salir..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboFormasPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nuevaVenta.lEntradas.Count > 0)
            {
                foreach (Entrada entrada in nuevaVenta.lEntradas)
                {
                    entrada.FormaPago = cboFormasPago.SelectedIndex + 1;
                }
            }
        }
    }
}
