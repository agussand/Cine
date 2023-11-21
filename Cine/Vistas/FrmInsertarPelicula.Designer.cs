namespace CineFront
{
    partial class FrmInsertarPelicula
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsertarPelicula));
            lblTitulo = new Label();
            lblDirector = new Label();
            lblIdioma = new Label();
            lblGenero = new Label();
            lblClasificacion = new Label();
            lblDuracion = new Label();
            lblSala = new Label();
            lblDia = new Label();
            lblHora = new Label();
            txtTitulo = new TextBox();
            txtDirector = new TextBox();
            cboIdioma = new ComboBox();
            cboGenero = new ComboBox();
            cboClasificacion = new ComboBox();
            nudDuracion = new NumericUpDown();
            cboSala = new ComboBox();
            dtpDia = new DateTimePicker();
            dtpHora = new DateTimePicker();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            picCerrar = new PictureBox();
            lblPelicula = new Label();
            lblFuncion = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(161, 207);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(73, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título:";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDirector.ForeColor = SystemColors.ControlLightLight;
            lblDirector.Location = new Point(141, 263);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(96, 28);
            lblDirector.TabIndex = 2;
            lblDirector.Text = "Director:";
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdioma.ForeColor = SystemColors.ControlLightLight;
            lblIdioma.Location = new Point(151, 372);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(82, 28);
            lblIdioma.TabIndex = 3;
            lblIdioma.Text = "Idioma:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenero.ForeColor = SystemColors.ControlLightLight;
            lblGenero.Location = new Point(150, 316);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(85, 28);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género:";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClasificacion.ForeColor = SystemColors.ControlLightLight;
            lblClasificacion.Location = new Point(102, 483);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(136, 28);
            lblClasificacion.TabIndex = 5;
            lblClasificacion.Text = "Clasificación:";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuracion.ForeColor = SystemColors.ControlLightLight;
            lblDuracion.Location = new Point(133, 425);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(103, 28);
            lblDuracion.TabIndex = 6;
            lblDuracion.Text = "Duración:";
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSala.ForeColor = SystemColors.ControlLightLight;
            lblSala.Location = new Point(606, 207);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(56, 28);
            lblSala.TabIndex = 7;
            lblSala.Text = "Sala:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDia.ForeColor = SystemColors.ControlLightLight;
            lblDia.Location = new Point(613, 257);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(49, 28);
            lblDia.TabIndex = 8;
            lblDia.Text = "Día:";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = SystemColors.ControlLightLight;
            lblHora.Location = new Point(600, 308);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(63, 28);
            lblHora.TabIndex = 9;
            lblHora.Text = "Hora:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.Location = new Point(235, 203);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(153, 34);
            txtTitulo.TabIndex = 10;
            // 
            // txtDirector
            // 
            txtDirector.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDirector.Location = new Point(235, 253);
            txtDirector.Margin = new Padding(3, 4, 3, 4);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(153, 34);
            txtDirector.TabIndex = 11;
            // 
            // cboIdioma
            // 
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(235, 368);
            cboIdioma.Margin = new Padding(3, 4, 3, 4);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(153, 36);
            cboIdioma.TabIndex = 12;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(235, 309);
            cboGenero.Margin = new Padding(3, 4, 3, 4);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(153, 36);
            cboGenero.TabIndex = 13;
            // 
            // cboClasificacion
            // 
            cboClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClasificacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(235, 479);
            cboClasificacion.Margin = new Padding(3, 4, 3, 4);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(153, 36);
            cboClasificacion.TabIndex = 14;
            // 
            // nudDuracion
            // 
            nudDuracion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudDuracion.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracion.Location = new Point(235, 423);
            nudDuracion.Margin = new Padding(3, 4, 3, 4);
            nudDuracion.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(135, 34);
            nudDuracion.TabIndex = 15;
            // 
            // cboSala
            // 
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(665, 203);
            cboSala.Margin = new Padding(3, 4, 3, 4);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(153, 36);
            cboSala.TabIndex = 16;
            // 
            // dtpDia
            // 
            dtpDia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDia.Format = DateTimePickerFormat.Short;
            dtpDia.Location = new Point(665, 252);
            dtpDia.Margin = new Padding(3, 4, 3, 4);
            dtpDia.Name = "dtpDia";
            dtpDia.Size = new Size(153, 34);
            dtpDia.TabIndex = 17;
            // 
            // dtpHora
            // 
            dtpHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(665, 303);
            dtpHora.Margin = new Padding(3, 4, 3, 4);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(153, 34);
            dtpHora.TabIndex = 18;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(31, 31, 31);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlLightLight;
            btnAceptar.Location = new Point(568, 665);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(141, 59);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(31, 31, 31);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(273, 665);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 59);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(93, 109, 126);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-5, -3);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 93);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(137, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 46);
            label1.TabIndex = 1;
            label1.Text = "Agregar películas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.BackColor = Color.FromArgb(46, 52, 63);
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(967, 20);
            picCerrar.Margin = new Padding(5);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(32, 32);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 76;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPelicula.ForeColor = SystemColors.ControlLightLight;
            lblPelicula.Location = new Point(195, 129);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(143, 46);
            lblPelicula.TabIndex = 77;
            lblPelicula.Text = "Película";
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuncion.ForeColor = SystemColors.ControlLightLight;
            lblFuncion.Location = new Point(670, 129);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(148, 46);
            lblFuncion.TabIndex = 78;
            lblFuncion.Text = "Función";
            // 
            // FrmInsertarPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 63);
            ClientSize = new Size(1014, 760);
            Controls.Add(lblFuncion);
            Controls.Add(lblPelicula);
            Controls.Add(picCerrar);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dtpHora);
            Controls.Add(dtpDia);
            Controls.Add(cboSala);
            Controls.Add(nudDuracion);
            Controls.Add(cboClasificacion);
            Controls.Add(cboGenero);
            Controls.Add(cboIdioma);
            Controls.Add(txtDirector);
            Controls.Add(txtTitulo);
            Controls.Add(lblHora);
            Controls.Add(lblDia);
            Controls.Add(lblSala);
            Controls.Add(lblDuracion);
            Controls.Add(lblClasificacion);
            Controls.Add(lblGenero);
            Controls.Add(lblIdioma);
            Controls.Add(lblDirector);
            Controls.Add(lblTitulo);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmInsertarPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Pelicula";
            Load += FrmInsertarPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblDirector;
        private Label lblIdioma;
        private Label lblGenero;
        private Label lblClasificacion;
        private Label lblDuracion;
        private Label lblSala;
        private Label lblDia;
        private Label lblHora;
        private TextBox txtTitulo;
        private TextBox txtDirector;
        private ComboBox cboIdioma;
        private ComboBox cboGenero;
        private ComboBox cboClasificacion;
        private NumericUpDown nudDuracion;
        private ComboBox cboSala;
        private DateTimePicker dtpDia;
        private DateTimePicker dtpHora;
        private Button btnAceptar;
        private Button btnCancelar;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox picCerrar;
        private Label lblPelicula;
        private Label lblFuncion;
    }
}