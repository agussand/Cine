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
    public partial class FrmSalir : Form
    {
        public FrmSalir()
        {
            InitializeComponent();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
