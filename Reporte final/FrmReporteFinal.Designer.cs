namespace Reporte_final
{
    partial class FrmReportePeliculas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPOBTENERPELICULASGENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPeliculas = new Reporte_final.DSPeliculas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.sP_OBTENER_PELICULAS_GENTableAdapter = new Reporte_final.DSPeliculasTableAdapters.SP_OBTENER_PELICULAS_GENTableAdapter();
            this.dSPeliculas1 = new Reporte_final.DSPeliculas();
            this.generooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generooTableAdapter = new Reporte_final.DSPeliculasTableAdapters.GenerooTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPOBTENERPELICULASGENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPeliculas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generooBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPOBTENERPELICULASGENBindingSource
            // 
            this.sPOBTENERPELICULASGENBindingSource.DataMember = "SP_OBTENER_PELICULAS_GEN";
            this.sPOBTENERPELICULASGENBindingSource.DataSource = this.dSPeliculas;
            // 
            // dSPeliculas
            // 
            this.dSPeliculas.DataSetName = "DSPeliculas";
            this.dSPeliculas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sPOBTENERPELICULASGENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporte_final.rPeliculas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 97);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1041, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(276, 26);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 28);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(108, 29);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(160, 24);
            this.cboGenero.TabIndex = 3;
            this.cboGenero.SelectedIndexChanged += new System.EventHandler(this.cboGenero_SelectedIndexChanged);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(48, 32);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 16);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero";
            // 
            // sP_OBTENER_PELICULAS_GENTableAdapter
            // 
            this.sP_OBTENER_PELICULAS_GENTableAdapter.ClearBeforeFill = true;
            // 
            // dSPeliculas1
            // 
            this.dSPeliculas1.DataSetName = "DSPeliculas";
            this.dSPeliculas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generooBindingSource
            // 
            this.generooBindingSource.DataMember = "Generoo";
            this.generooBindingSource.DataSource = this.dSPeliculas1;
            // 
            // generooTableAdapter
            // 
            this.generooTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmReportePeliculas";
            this.Text = "Reporte Peliculas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPOBTENERPELICULASGENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPeliculas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generooBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPOBTENERPELICULASGENBindingSource;
        private DSPeliculas dSPeliculas;
        private DSPeliculasTableAdapters.SP_OBTENER_PELICULAS_GENTableAdapter sP_OBTENER_PELICULAS_GENTableAdapter;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblGenero;
        private DSPeliculas dSPeliculas1;
        private System.Windows.Forms.BindingSource generooBindingSource;
        private DSPeliculasTableAdapters.GenerooTableAdapter generooTableAdapter;
    }
}

