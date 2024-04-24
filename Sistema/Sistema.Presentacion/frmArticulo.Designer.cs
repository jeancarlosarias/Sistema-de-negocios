namespace Sistema.Presentacion
{
    partial class frmArticulo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtboxArticulo = new System.Windows.Forms.TextBox();
            this.bttBuscarArt = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttDesactivarArt = new System.Windows.Forms.Button();
            this.bttActivarArt = new System.Windows.Forms.Button();
            this.chkSeleccionarArt = new System.Windows.Forms.CheckBox();
            this.dtgArticulo = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_Categorias = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttImagen = new System.Windows.Forms.Button();
            this.txtBoxImagen = new System.Windows.Forms.TextBox();
            this.bttEliminarArtMan = new System.Windows.Forms.Button();
            this.bttInsertar = new System.Windows.Forms.Button();
            this.bttActualizar = new System.Windows.Forms.Button();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttGenerar = new System.Windows.Forms.Button();
            this.txtBoxCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(56, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblRegistro);
            this.tabPage1.Controls.Add(this.txtboxArticulo);
            this.tabPage1.Controls.Add(this.bttBuscarArt);
            this.tabPage1.Controls.Add(this.bttEliminar);
            this.tabPage1.Controls.Add(this.bttDesactivarArt);
            this.tabPage1.Controls.Add(this.bttActivarArt);
            this.tabPage1.Controls.Add(this.chkSeleccionarArt);
            this.tabPage1.Controls.Add(this.dtgArticulo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(728, 476);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(121, 16);
            this.lblRegistro.TabIndex = 7;
            this.lblRegistro.Text = "Total de Registros:";
            // 
            // txtboxArticulo
            // 
            this.txtboxArticulo.Location = new System.Drawing.Point(11, 19);
            this.txtboxArticulo.Name = "txtboxArticulo";
            this.txtboxArticulo.Size = new System.Drawing.Size(524, 22);
            this.txtboxArticulo.TabIndex = 6;
            this.txtboxArticulo.TextChanged += new System.EventHandler(this.txtboxArticulo_TextChanged);
            // 
            // bttBuscarArt
            // 
            this.bttBuscarArt.Location = new System.Drawing.Point(597, 12);
            this.bttBuscarArt.Name = "bttBuscarArt";
            this.bttBuscarArt.Size = new System.Drawing.Size(129, 29);
            this.bttBuscarArt.TabIndex = 5;
            this.bttBuscarArt.Text = "Buscar";
            this.bttBuscarArt.UseVisualStyleBackColor = true;
            this.bttBuscarArt.Click += new System.EventHandler(this.button4_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(526, 470);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(156, 29);
            this.bttEliminar.TabIndex = 4;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Visible = false;
            this.bttEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttDesactivarArt
            // 
            this.bttDesactivarArt.Location = new System.Drawing.Point(346, 470);
            this.bttDesactivarArt.Name = "bttDesactivarArt";
            this.bttDesactivarArt.Size = new System.Drawing.Size(150, 29);
            this.bttDesactivarArt.TabIndex = 3;
            this.bttDesactivarArt.Text = "Desactivar";
            this.bttDesactivarArt.UseVisualStyleBackColor = true;
            this.bttDesactivarArt.Visible = false;
            this.bttDesactivarArt.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttActivarArt
            // 
            this.bttActivarArt.Location = new System.Drawing.Point(163, 470);
            this.bttActivarArt.Name = "bttActivarArt";
            this.bttActivarArt.Size = new System.Drawing.Size(149, 29);
            this.bttActivarArt.TabIndex = 2;
            this.bttActivarArt.Text = "Activar";
            this.bttActivarArt.UseVisualStyleBackColor = true;
            this.bttActivarArt.Visible = false;
            this.bttActivarArt.Click += new System.EventHandler(this.bttActivarArt_Click);
            // 
            // chkSeleccionarArt
            // 
            this.chkSeleccionarArt.AutoSize = true;
            this.chkSeleccionarArt.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSeleccionarArt.Location = new System.Drawing.Point(8, 479);
            this.chkSeleccionarArt.Name = "chkSeleccionarArt";
            this.chkSeleccionarArt.Size = new System.Drawing.Size(101, 20);
            this.chkSeleccionarArt.TabIndex = 1;
            this.chkSeleccionarArt.Text = "Seleccionar";
            this.chkSeleccionarArt.UseVisualStyleBackColor = true;
            this.chkSeleccionarArt.CheckedChanged += new System.EventHandler(this.chkSeleccionarArt_CheckedChanged);
            // 
            // dtgArticulo
            // 
            this.dtgArticulo.AllowUserToAddRows = false;
            this.dtgArticulo.AllowUserToDeleteRows = false;
            this.dtgArticulo.AllowUserToOrderColumns = true;
            this.dtgArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dtgArticulo.Location = new System.Drawing.Point(11, 44);
            this.dtgArticulo.Name = "dtgArticulo";
            this.dtgArticulo.ReadOnly = true;
            this.dtgArticulo.RowHeadersWidth = 51;
            this.dtgArticulo.RowTemplate.Height = 24;
            this.dtgArticulo.Size = new System.Drawing.Size(911, 404);
            this.dtgArticulo.TabIndex = 0;
            this.dtgArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulo_CellContentClick);
            this.dtgArticulo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulo_CellContentDoubleClick);
            this.dtgArticulo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulo_CellDoubleClick);
            this.dtgArticulo.DoubleClick += new System.EventHandler(this.dtgArticulo_DoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmb_Categorias);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.bttImagen);
            this.tabPage2.Controls.Add(this.txtBoxImagen);
            this.tabPage2.Controls.Add(this.bttEliminarArtMan);
            this.tabPage2.Controls.Add(this.bttInsertar);
            this.tabPage2.Controls.Add(this.bttActualizar);
            this.tabPage2.Controls.Add(this.txtBoxDescripcion);
            this.tabPage2.Controls.Add(this.txtBoxStock);
            this.tabPage2.Controls.Add(this.txtBoxPrecioVenta);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.bttGuardar);
            this.tabPage2.Controls.Add(this.bttGenerar);
            this.tabPage2.Controls.Add(this.txtBoxCodigoBarra);
            this.tabPage2.Controls.Add(this.txtBoxNombre);
            this.tabPage2.Controls.Add(this.txtBx1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_Categorias
            // 
            this.cmb_Categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Categorias.FormattingEnabled = true;
            this.cmb_Categorias.Location = new System.Drawing.Point(162, 59);
            this.cmb_Categorias.Name = "cmb_Categorias";
            this.cmb_Categorias.Size = new System.Drawing.Size(269, 24);
            this.cmb_Categorias.TabIndex = 24;
            this.cmb_Categorias.SelectedIndexChanged += new System.EventHandler(this.cmb_Categorias_SelectedIndexChanged);
            this.cmb_Categorias.Click += new System.EventHandler(this.cmb_Categorias_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Imagen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Los campos con aterisco (*) son Obligatorios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Precio de venta *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Codigo de Barra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categoria *";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(484, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bttImagen
            // 
            this.bttImagen.Location = new System.Drawing.Point(817, 36);
            this.bttImagen.Name = "bttImagen";
            this.bttImagen.Size = new System.Drawing.Size(117, 23);
            this.bttImagen.TabIndex = 14;
            this.bttImagen.Text = "...";
            this.bttImagen.UseVisualStyleBackColor = true;
            this.bttImagen.Click += new System.EventHandler(this.bttImagen_Click);
            // 
            // txtBoxImagen
            // 
            this.txtBoxImagen.Location = new System.Drawing.Point(569, 36);
            this.txtBoxImagen.Name = "txtBoxImagen";
            this.txtBoxImagen.Size = new System.Drawing.Size(242, 22);
            this.txtBoxImagen.TabIndex = 13;
            // 
            // bttEliminarArtMan
            // 
            this.bttEliminarArtMan.Location = new System.Drawing.Point(311, 516);
            this.bttEliminarArtMan.Name = "bttEliminarArtMan";
            this.bttEliminarArtMan.Size = new System.Drawing.Size(120, 23);
            this.bttEliminarArtMan.TabIndex = 12;
            this.bttEliminarArtMan.Text = "Eliminar";
            this.bttEliminarArtMan.UseVisualStyleBackColor = true;
            this.bttEliminarArtMan.Click += new System.EventHandler(this.bttEliminarArtMan_Click);
            // 
            // bttInsertar
            // 
            this.bttInsertar.Location = new System.Drawing.Point(163, 516);
            this.bttInsertar.Name = "bttInsertar";
            this.bttInsertar.Size = new System.Drawing.Size(120, 23);
            this.bttInsertar.TabIndex = 11;
            this.bttInsertar.Text = "Insertar";
            this.bttInsertar.UseVisualStyleBackColor = true;
            this.bttInsertar.Click += new System.EventHandler(this.bttInsertar_Click);
            // 
            // bttActualizar
            // 
            this.bttActualizar.Location = new System.Drawing.Point(8, 516);
            this.bttActualizar.Name = "bttActualizar";
            this.bttActualizar.Size = new System.Drawing.Size(120, 23);
            this.bttActualizar.TabIndex = 10;
            this.bttActualizar.Text = "Actualizar";
            this.bttActualizar.UseVisualStyleBackColor = true;
            this.bttActualizar.Click += new System.EventHandler(this.bttActualizar_Click);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(163, 385);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(268, 69);
            this.txtBoxDescripcion.TabIndex = 9;
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Location = new System.Drawing.Point(163, 338);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(136, 22);
            this.txtBoxStock.TabIndex = 8;
            // 
            // txtBoxPrecioVenta
            // 
            this.txtBoxPrecioVenta.Location = new System.Drawing.Point(163, 310);
            this.txtBoxPrecioVenta.Name = "txtBoxPrecioVenta";
            this.txtBoxPrecioVenta.Size = new System.Drawing.Size(136, 22);
            this.txtBoxPrecioVenta.TabIndex = 7;
            this.txtBoxPrecioVenta.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(163, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 100);
            this.panel1.TabIndex = 6;
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(311, 160);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(120, 23);
            this.bttGuardar.TabIndex = 5;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // bttGenerar
            // 
            this.bttGenerar.Location = new System.Drawing.Point(163, 160);
            this.bttGenerar.Name = "bttGenerar";
            this.bttGenerar.Size = new System.Drawing.Size(120, 23);
            this.bttGenerar.TabIndex = 4;
            this.bttGenerar.Text = "Generar";
            this.bttGenerar.UseVisualStyleBackColor = true;
            this.bttGenerar.Click += new System.EventHandler(this.bttGenerar_Click);
            // 
            // txtBoxCodigoBarra
            // 
            this.txtBoxCodigoBarra.Location = new System.Drawing.Point(163, 123);
            this.txtBoxCodigoBarra.Name = "txtBoxCodigoBarra";
            this.txtBoxCodigoBarra.Size = new System.Drawing.Size(268, 22);
            this.txtBoxCodigoBarra.TabIndex = 3;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(163, 92);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(268, 22);
            this.txtBoxNombre.TabIndex = 2;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // txtBx1
            // 
            this.txtBx1.Location = new System.Drawing.Point(331, 23);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.ReadOnly = true;
            this.txtBx1.Size = new System.Drawing.Size(100, 22);
            this.txtBx1.TabIndex = 1;
            this.txtBx1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmArticulo";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bttActivarArt;
        private System.Windows.Forms.CheckBox chkSeleccionarArt;
        private System.Windows.Forms.DataGridView dtgArticulo;
        private System.Windows.Forms.Button bttBuscarArt;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button bttDesactivarArt;
        private System.Windows.Forms.TextBox txtboxArticulo;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttGenerar;
        private System.Windows.Forms.TextBox txtBoxCodigoBarra;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.TextBox txtBoxPrecioVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttImagen;
        private System.Windows.Forms.TextBox txtBoxImagen;
        private System.Windows.Forms.Button bttEliminarArtMan;
        private System.Windows.Forms.Button bttInsertar;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Categorias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}