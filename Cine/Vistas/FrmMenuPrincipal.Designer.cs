namespace CineFront.Vistas
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            picCerrar = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelLateral = new Panel();
            panelAcercaDe = new Panel();
            btnIntegrantes = new Button();
            btnAcercaDe = new Button();
            panelSoporte = new Panel();
            btnButacas = new Button();
            btnSoporte = new Button();
            panelArchivo = new Panel();
            btnSalir = new Button();
            btnArchivo = new Button();
            panelLogo = new Panel();
            pictureBox4 = new PictureBox();
            lblHora = new Label();
            lblDate = new Label();
            reloj = new System.Windows.Forms.Timer(components);
            panelChildForm = new Panel();
            lblBienvenida = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLateral.SuspendLayout();
            panelAcercaDe.SuspendLayout();
            panelSoporte.SuspendLayout();
            panelArchivo.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(1214, 5);
            picCerrar.Margin = new Padding(5);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(32, 32);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 77;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(198, 22, 22);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 40);
            panel1.TabIndex = 78;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 7);
            pictureBox3.Margin = new Padding(2, 3, 2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 80;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1172, 14);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelLateral
            // 
            panelLateral.AutoScroll = true;
            panelLateral.Controls.Add(panelAcercaDe);
            panelLateral.Controls.Add(btnAcercaDe);
            panelLateral.Controls.Add(panelSoporte);
            panelLateral.Controls.Add(btnSoporte);
            panelLateral.Controls.Add(panelArchivo);
            panelLateral.Controls.Add(btnArchivo);
            panelLateral.Controls.Add(panelLogo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 40);
            panelLateral.Margin = new Padding(2, 3, 2, 3);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(243, 760);
            panelLateral.TabIndex = 79;
            // 
            // panelAcercaDe
            // 
            panelAcercaDe.BackColor = Color.FromArgb(46, 52, 63);
            panelAcercaDe.Controls.Add(btnIntegrantes);
            panelAcercaDe.Dock = DockStyle.Top;
            panelAcercaDe.Location = new Point(0, 336);
            panelAcercaDe.Margin = new Padding(2, 3, 2, 3);
            panelAcercaDe.Name = "panelAcercaDe";
            panelAcercaDe.Size = new Size(243, 53);
            panelAcercaDe.TabIndex = 90;
            // 
            // btnIntegrantes
            // 
            btnIntegrantes.Dock = DockStyle.Top;
            btnIntegrantes.FlatStyle = FlatStyle.Flat;
            btnIntegrantes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIntegrantes.ForeColor = SystemColors.ControlLightLight;
            btnIntegrantes.Image = (Image)resources.GetObject("btnIntegrantes.Image");
            btnIntegrantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnIntegrantes.Location = new Point(0, 0);
            btnIntegrantes.Margin = new Padding(2, 3, 2, 3);
            btnIntegrantes.Name = "btnIntegrantes";
            btnIntegrantes.Size = new Size(243, 51);
            btnIntegrantes.TabIndex = 5;
            btnIntegrantes.Text = "Integrantes";
            btnIntegrantes.UseVisualStyleBackColor = true;
            btnIntegrantes.Click += btnIntegrantes_Click;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.Dock = DockStyle.Top;
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcercaDe.ForeColor = SystemColors.ControlLightLight;
            btnAcercaDe.Image = (Image)resources.GetObject("btnAcercaDe.Image");
            btnAcercaDe.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcercaDe.Location = new Point(0, 283);
            btnAcercaDe.Margin = new Padding(2, 3, 2, 3);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(243, 53);
            btnAcercaDe.TabIndex = 89;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = true;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // panelSoporte
            // 
            panelSoporte.BackColor = Color.FromArgb(46, 52, 63);
            panelSoporte.Controls.Add(btnButacas);
            panelSoporte.Dock = DockStyle.Top;
            panelSoporte.Location = new Point(0, 230);
            panelSoporte.Margin = new Padding(2, 3, 2, 3);
            panelSoporte.Name = "panelSoporte";
            panelSoporte.Size = new Size(243, 53);
            panelSoporte.TabIndex = 84;
            // 
            // btnButacas
            // 
            btnButacas.Dock = DockStyle.Top;
            btnButacas.FlatStyle = FlatStyle.Flat;
            btnButacas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnButacas.ForeColor = SystemColors.ControlLightLight;
            btnButacas.Image = (Image)resources.GetObject("btnButacas.Image");
            btnButacas.ImageAlign = ContentAlignment.MiddleLeft;
            btnButacas.Location = new Point(0, 0);
            btnButacas.Margin = new Padding(2, 3, 2, 3);
            btnButacas.Name = "btnButacas";
            btnButacas.Size = new Size(243, 53);
            btnButacas.TabIndex = 1;
            btnButacas.Text = "Ver Funciones";
            btnButacas.UseVisualStyleBackColor = true;
            btnButacas.Click += btnButacas_Click;
            // 
            // btnSoporte
            // 
            btnSoporte.Dock = DockStyle.Top;
            btnSoporte.FlatStyle = FlatStyle.Flat;
            btnSoporte.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoporte.ForeColor = SystemColors.ControlLightLight;
            btnSoporte.Image = (Image)resources.GetObject("btnSoporte.Image");
            btnSoporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnSoporte.Location = new Point(0, 177);
            btnSoporte.Margin = new Padding(2, 3, 2, 3);
            btnSoporte.Name = "btnSoporte";
            btnSoporte.Size = new Size(243, 53);
            btnSoporte.TabIndex = 83;
            btnSoporte.Text = "Peliculas";
            btnSoporte.UseVisualStyleBackColor = true;
            btnSoporte.Click += btnSoporte_Click;
            // 
            // panelArchivo
            // 
            panelArchivo.BackColor = Color.FromArgb(46, 52, 63);
            panelArchivo.Controls.Add(btnSalir);
            panelArchivo.Dock = DockStyle.Top;
            panelArchivo.Location = new Point(0, 124);
            panelArchivo.Margin = new Padding(2, 3, 2, 3);
            panelArchivo.Name = "panelArchivo";
            panelArchivo.Size = new Size(243, 53);
            panelArchivo.TabIndex = 82;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 0);
            btnSalir.Margin = new Padding(2, 3, 2, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(243, 53);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnArchivo
            // 
            btnArchivo.Dock = DockStyle.Top;
            btnArchivo.FlatStyle = FlatStyle.Flat;
            btnArchivo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnArchivo.ForeColor = SystemColors.ControlLightLight;
            btnArchivo.Image = (Image)resources.GetObject("btnArchivo.Image");
            btnArchivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchivo.Location = new Point(0, 71);
            btnArchivo.Margin = new Padding(2, 3, 2, 3);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(243, 53);
            btnArchivo.TabIndex = 81;
            btnArchivo.Text = "Archivo";
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox4);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2, 3, 2, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(243, 71);
            panelLogo.TabIndex = 80;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 3);
            pictureBox4.Margin = new Padding(2, 3, 2, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(243, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = SystemColors.ControlLightLight;
            lblHora.Location = new Point(33, 61);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(154, 46);
            lblHora.TabIndex = 81;
            lblHora.Text = "lblHora";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = SystemColors.ControlLightLight;
            lblDate.Location = new Point(33, 15);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(106, 31);
            lblDate.TabIndex = 80;
            lblDate.Text = "lblDate";
            // 
            // reloj
            // 
            reloj.Enabled = true;
            reloj.Tick += reloj_Tick;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(51, 51, 51);
            panelChildForm.Controls.Add(lblBienvenida);
            panelChildForm.Controls.Add(lblHora);
            panelChildForm.Controls.Add(pictureBox5);
            panelChildForm.Controls.Add(lblDate);
            panelChildForm.Controls.Add(pictureBox6);
            panelChildForm.Controls.Add(pictureBox7);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(243, 40);
            panelChildForm.Margin = new Padding(2, 3, 2, 3);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1014, 760);
            panelChildForm.TabIndex = 80;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.ForeColor = SystemColors.ControlLightLight;
            lblBienvenida.Location = new Point(448, 231);
            lblBienvenida.Margin = new Padding(2, 0, 2, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(269, 46);
            lblBienvenida.TabIndex = 84;
            lblBienvenida.Text = "lblBienvenida";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(190, 572);
            pictureBox5.Margin = new Padding(2, 3, 2, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(241, 195);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(402, 411);
            pictureBox6.Margin = new Padding(2, 3, 2, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(368, 392);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 82;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(686, 429);
            pictureBox7.Margin = new Padding(2, 3, 2, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(345, 292);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 83;
            pictureBox7.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1257, 800);
            Controls.Add(panelChildForm);
            Controls.Add(panelLateral);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPrincipal";
            Load += FrmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLateral.ResumeLayout(false);
            panelAcercaDe.ResumeLayout(false);
            panelSoporte.ResumeLayout(false);
            panelArchivo.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picCerrar;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panelLateral;
        private PictureBox pictureBox4;
        private Panel panelLogo;
        private Button btnArchivo;
        private Panel panelArchivo;
        private Button btnSalir;
        private Button btnSoporte;
        private Panel panelSoporte;
        private Button btnButacas;
        private Panel panelAcercaDe;
        private Button btnIntegrantes;
        private Button btnAcercaDe;
        private Label lblDate;
        private Label lblHora;
        private System.Windows.Forms.Timer reloj;
        private Panel panelChildForm;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label lblBienvenida;
    }
}