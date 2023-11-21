using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte_final
{
    public partial class FrmReportePeliculas : Form
    {
       private string[] genero = { "Terror", "Accion", "Comedia", "Suspenso", "Ciencia Ficcion", "Drama" };
        public FrmReportePeliculas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dSPeliculas1.Generoo' Puede moverla o quitarla según sea necesario.
            this.generooTableAdapter.Fill(this.dSPeliculas1.Generoo);
            cboGenero.Items.AddRange(genero);

        }


        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genero;
            genero=cboGenero.SelectedItem.ToString();
            this.sP_OBTENER_PELICULAS_GENTableAdapter.Fill(dSPeliculas.SP_OBTENER_PELICULAS_GEN,genero);
        }

       
    }
}
