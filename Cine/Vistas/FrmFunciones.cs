using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineFront.Servicios;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    public partial class FrmFunciones : Form
    {

        private List<Funcion> lFunciones = null;
        private Cliente cliente;
        public FrmFunciones(Cliente cliente)
        {
            InitializeComponent();
            lFunciones = new List<Funcion>();
            this.cliente = cliente;
        }

        private async Task CargarPeliculasAsync()
        {
            string url = "https://localhost:7095/peliculas";
            var datos = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<Pelicula> lPeliculas = JsonConvert.DeserializeObject<List<Pelicula>>(datos);
            cboPeliculas.DataSource = lPeliculas;
            cboPeliculas.ValueMember = "IdPelicula";
            cboPeliculas.DisplayMember = "Titulo";
            cboPeliculas.SelectedIndex = -1;
            cboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task<List<Funcion>> GetFunciones(string pelicula)
        {
            string url = "https://localhost:7095/funciones";
            string jsonPelicula = JsonConvert.SerializeObject(pelicula);

            var dataJson = await ClienteSingleton.GetInstancia().PostAsync(url, pelicula);
            List<Funcion> lfunciones = JsonConvert.DeserializeObject<List<Funcion>>(dataJson);
            return lfunciones;
        }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            CargarPeliculasAsync();
            dgvFunciones.Rows.Clear();
        }

        private async void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunciones.CurrentCell.ColumnIndex == 5)
            {
                bool resultado;
                string url = $"https://localhost:7095/butacas/estado?id_funcion={lFunciones[dgvFunciones.CurrentRow.Index].FuncionId}&cantidad={int.Parse(nudCantidad.Value.ToString())}";
                var res = await ClienteSingleton.GetInstancia().GetAsync(url);
                resultado = JsonConvert.DeserializeObject<bool>(res);
                if (resultado)
                {
                    Venta nuevaVenta = new Venta(cliente);
                    FrmButacas frmButacas = new FrmButacas(lFunciones[dgvFunciones.CurrentRow.Index], int.Parse(nudCantidad.Value.ToString()), nuevaVenta);
                    frmButacas.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("la cantidad de entradas es inválida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudCantidad.Value = 1;
                }
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboPeliculas.SelectedIndex != -1)
            {
                dgvFunciones.Rows.Clear();
                Pelicula peliculaSelecc = (Pelicula)cboPeliculas.Items[cboPeliculas.SelectedIndex];
                string url = $"https://localhost:7095/funciones?pelicula={peliculaSelecc.IdPelicula}";
                var resp = await ClienteSingleton.GetInstancia().GetAsync(url);
                lFunciones = JsonConvert.DeserializeObject<List<Funcion>>(resp);

                dgvFunciones.Rows.Clear();
                if (lFunciones != null)
                {
                    foreach (Funcion f in lFunciones)
                    {
                        dgvFunciones.Rows.Add(new object[] { f.Pelicula.Titulo, f.oSala.IdSala, f.oSala.TipoSala, f.DiaMostrar, f.HoraMostrar, "Comprar" });
                    }
                    dgvFunciones.ClearSelection();
                }
            }
        }

        private async void cboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboPeliculas.SelectedIndex != -1)
            //{
            //    dgvFunciones.Rows.Clear();
            //    Pelicula peliculaSelecc = (Pelicula)cboPeliculas.Items[cboPeliculas.SelectedIndex];
            //    string url = $"https://localhost:7095/funciones?pelicula={peliculaSelecc.IdPelicula}";
            //    var resp = await ClienteSingleton.GetInstancia().GetAsync(url);
            //    lFunciones = JsonConvert.DeserializeObject<List<Funcion>>(resp);

            //    dgvFunciones.Rows.Clear();
            //    if (lFunciones != null)
            //    {
            //        foreach (Funcion f in lFunciones)
            //        {
            //            dgvFunciones.Rows.Add(new object[] { f.Pelicula.Titulo, f.oSala.IdSala, f.oSala.TipoSala, f.DiaMostrar, f.HoraMostrar, "Comprar" });
            //        }
            //        dgvFunciones.ClearSelection();
            //    }
            //}
        }
    }
}
