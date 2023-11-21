using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte_Funciones
{
    public partial class FrmReporteFunciones : Form
    {
        public FrmReporteFunciones()
        {
            InitializeComponent();
        }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today.AddDays(-30);
            dtpFechaHasta.Value = DateTime.Today;
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime FechaDesde = dtpFechaDesde.Value;
            DateTime FechaHasta = dtpFechaHasta.Value;
            this.sP_OBTENER_FUNCION_FECHASTableAdapter.Fill(dSFunciones.SP_OBTENER_FUNCION_FECHAS, FechaDesde, FechaHasta);
            this.reportViewer1.RefreshReport();
        }
    }
}
