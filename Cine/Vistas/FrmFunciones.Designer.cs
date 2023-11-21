namespace CineFront.Vistas
{
    partial class FrmFunciones
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunciones));
            dgvFunciones = new DataGridView();
            ColTitulo = new DataGridViewTextBoxColumn();
            ColSalaNro = new DataGridViewTextBoxColumn();
            ColFormato = new DataGridViewTextBoxColumn();
            ColDia = new DataGridViewTextBoxColumn();
            ColHora = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            cboPeliculas = new ComboBox();
            nudCantidad = new NumericUpDown();
            picCerrar = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            btnBuscar = new Button();
            lblPeliculas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.Anchor = AnchorStyles.None;
            dgvFunciones.BackgroundColor = Color.FromArgb(31, 31, 31);
            dgvFunciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFunciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { ColTitulo, ColSalaNro, ColFormato, ColDia, ColHora, ColAcciones });
            dgvFunciones.Location = new Point(3, 210);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersVisible = false;
            dgvFunciones.RowHeadersWidth = 60;
            dgvFunciones.RowTemplate.Height = 29;
            dgvFunciones.Size = new Size(880, 328);
            dgvFunciones.TabIndex = 0;
            dgvFunciones.CellContentClick += dgvFunciones_CellContentClick;
            // 
            // ColTitulo
            // 
            ColTitulo.HeaderText = "Titulo";
            ColTitulo.MinimumWidth = 6;
            ColTitulo.Name = "ColTitulo";
            ColTitulo.ReadOnly = true;
            ColTitulo.Width = 250;
            // 
            // ColSalaNro
            // 
            ColSalaNro.HeaderText = "Sala Nro";
            ColSalaNro.MinimumWidth = 6;
            ColSalaNro.Name = "ColSalaNro";
            ColSalaNro.ReadOnly = true;
            ColSalaNro.Width = 150;
            // 
            // ColFormato
            // 
            ColFormato.HeaderText = "Formato";
            ColFormato.MinimumWidth = 6;
            ColFormato.Name = "ColFormato";
            ColFormato.ReadOnly = true;
            ColFormato.Width = 150;
            // 
            // ColDia
            // 
            ColDia.HeaderText = "Dia";
            ColDia.MinimumWidth = 6;
            ColDia.Name = "ColDia";
            ColDia.ReadOnly = true;
            ColDia.Width = 150;
            // 
            // ColHora
            // 
            ColHora.HeaderText = "Hora";
            ColHora.MinimumWidth = 6;
            ColHora.Name = "ColHora";
            ColHora.ReadOnly = true;
            ColHora.Width = 150;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "Acciones";
            ColAcciones.MinimumWidth = 6;
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Width = 150;
            // 
            // cboPeliculas
            // 
            cboPeliculas.FormattingEnabled = true;
            cboPeliculas.Location = new Point(211, 115);
            cboPeliculas.Margin = new Padding(3, 2, 3, 2);
            cboPeliculas.Name = "cboPeliculas";
            cboPeliculas.Size = new Size(260, 23);
            cboPeliculas.TabIndex = 1;
            cboPeliculas.SelectedIndexChanged += cboPeliculas_SelectedIndexChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.BackColor = Color.FromArgb(46, 52, 63);
            nudCantidad.BorderStyle = BorderStyle.None;
            nudCantidad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nudCantidad.ForeColor = SystemColors.Control;
            nudCantidad.Location = new Point(214, 161);
            nudCantidad.Margin = new Padding(3, 2, 3, 2);
            nudCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.ReadOnly = true;
            nudCantidad.Size = new Size(43, 28);
            nudCantidad.TabIndex = 3;
            nudCantidad.TextAlign = HorizontalAlignment.Center;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.BackColor = Color.FromArgb(46, 52, 63);
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(838, 4);
            picCerrar.Margin = new Padding(4, 4, 4, 4);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(28, 24);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 77;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(120, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 1;
            label1.Text = "Funciones";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(93, 109, 126);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 67);
            panel1.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(35, 161);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 2;
            label2.Text = "Cant. de Entradas:";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.buscar;
            btnBuscar.Location = new Point(477, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(32, 32);
            btnBuscar.TabIndex = 79;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblPeliculas
            // 
            lblPeliculas.AutoSize = true;
            lblPeliculas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeliculas.ForeColor = SystemColors.ControlLightLight;
            lblPeliculas.Location = new Point(115, 113);
            lblPeliculas.Margin = new Padding(2, 0, 2, 0);
            lblPeliculas.Name = "lblPeliculas";
            lblPeliculas.Size = new Size(92, 25);
            lblPeliculas.TabIndex = 80;
            lblPeliculas.Text = "Peliculas:";
            // 
            // FrmFunciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 63);
            ClientSize = new Size(887, 570);
            Controls.Add(lblPeliculas);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(picCerrar);
            Controls.Add(nudCantidad);
            Controls.Add(cboPeliculas);
            Controls.Add(dgvFunciones);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmFunciones";
            Text = "FrmFunciones";
            Load += FrmFunciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFunciones;
        private ComboBox cboPeliculas;
        private NumericUpDown nudCantidad;
        private PictureBox picCerrar;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn ColTitulo;
        private DataGridViewTextBoxColumn ColSalaNro;
        private DataGridViewTextBoxColumn ColFormato;
        private DataGridViewTextBoxColumn ColDia;
        private DataGridViewTextBoxColumn ColHora;
        private DataGridViewButtonColumn ColAcciones;
        private Label lblPeliculas;
    }
}