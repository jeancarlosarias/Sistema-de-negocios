namespace Sistema.Presentacion
{
    partial class frmUsuario
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
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.bttBuscarUsuario = new System.Windows.Forms.Button();
            this.bttEliminarUsuario = new System.Windows.Forms.Button();
            this.bttDesactivarUsuario = new System.Windows.Forms.Button();
            this.bttActivarUsuario = new System.Windows.Forms.Button();
            this.chkSeleccionarUsuario = new System.Windows.Forms.CheckBox();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bttBuscarEmail = new System.Windows.Forms.Button();
            this.txtBoxBuscarEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxIdRol = new System.Windows.Forms.TextBox();
            this.cmb_Roles = new System.Windows.Forms.ComboBox();
            this.bttActualizar = new System.Windows.Forms.Button();
            this.bttEliminarU = new System.Windows.Forms.Button();
            this.bttInsertar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNumDocum = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxClave = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.cmb_tipodoc = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(954, 583);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblRegistro);
            this.tabPage1.Controls.Add(this.txtBoxBuscar);
            this.tabPage1.Controls.Add(this.bttBuscarUsuario);
            this.tabPage1.Controls.Add(this.bttEliminarUsuario);
            this.tabPage1.Controls.Add(this.bttDesactivarUsuario);
            this.tabPage1.Controls.Add(this.bttActivarUsuario);
            this.tabPage1.Controls.Add(this.chkSeleccionarUsuario);
            this.tabPage1.Controls.Add(this.dtgUsuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 554);
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
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(11, 19);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(524, 22);
            this.txtBoxBuscar.TabIndex = 6;
            // 
            // bttBuscarUsuario
            // 
            this.bttBuscarUsuario.Location = new System.Drawing.Point(597, 12);
            this.bttBuscarUsuario.Name = "bttBuscarUsuario";
            this.bttBuscarUsuario.Size = new System.Drawing.Size(129, 29);
            this.bttBuscarUsuario.TabIndex = 5;
            this.bttBuscarUsuario.Text = "Buscar";
            this.bttBuscarUsuario.UseVisualStyleBackColor = true;
            this.bttBuscarUsuario.Click += new System.EventHandler(this.bttBuscarArt_Click);
            // 
            // bttEliminarUsuario
            // 
            this.bttEliminarUsuario.Location = new System.Drawing.Point(526, 470);
            this.bttEliminarUsuario.Name = "bttEliminarUsuario";
            this.bttEliminarUsuario.Size = new System.Drawing.Size(156, 29);
            this.bttEliminarUsuario.TabIndex = 4;
            this.bttEliminarUsuario.Text = "Eliminar";
            this.bttEliminarUsuario.UseVisualStyleBackColor = true;
            this.bttEliminarUsuario.Visible = false;
            this.bttEliminarUsuario.Click += new System.EventHandler(this.bttEliminarUsuario_Click);
            // 
            // bttDesactivarUsuario
            // 
            this.bttDesactivarUsuario.Location = new System.Drawing.Point(346, 470);
            this.bttDesactivarUsuario.Name = "bttDesactivarUsuario";
            this.bttDesactivarUsuario.Size = new System.Drawing.Size(150, 29);
            this.bttDesactivarUsuario.TabIndex = 3;
            this.bttDesactivarUsuario.Text = "Desactivar";
            this.bttDesactivarUsuario.UseVisualStyleBackColor = true;
            this.bttDesactivarUsuario.Visible = false;
            this.bttDesactivarUsuario.Click += new System.EventHandler(this.bttDesactivarUsuario_Click);
            // 
            // bttActivarUsuario
            // 
            this.bttActivarUsuario.Location = new System.Drawing.Point(163, 470);
            this.bttActivarUsuario.Name = "bttActivarUsuario";
            this.bttActivarUsuario.Size = new System.Drawing.Size(149, 29);
            this.bttActivarUsuario.TabIndex = 2;
            this.bttActivarUsuario.Text = "Activar";
            this.bttActivarUsuario.UseVisualStyleBackColor = true;
            this.bttActivarUsuario.Visible = false;
            this.bttActivarUsuario.Click += new System.EventHandler(this.bttActivarUsuario_Click);
            // 
            // chkSeleccionarUsuario
            // 
            this.chkSeleccionarUsuario.AutoSize = true;
            this.chkSeleccionarUsuario.Location = new System.Drawing.Point(8, 479);
            this.chkSeleccionarUsuario.Name = "chkSeleccionarUsuario";
            this.chkSeleccionarUsuario.Size = new System.Drawing.Size(101, 20);
            this.chkSeleccionarUsuario.TabIndex = 1;
            this.chkSeleccionarUsuario.Text = "Seleccionar";
            this.chkSeleccionarUsuario.UseVisualStyleBackColor = true;
            this.chkSeleccionarUsuario.CheckedChanged += new System.EventHandler(this.chkSeleccionarUsuario_CheckedChanged);
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.AllowUserToOrderColumns = true;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dtgUsuario.Location = new System.Drawing.Point(11, 44);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.RowHeadersWidth = 51;
            this.dtgUsuario.RowTemplate.Height = 24;
            this.dtgUsuario.Size = new System.Drawing.Size(911, 404);
            this.dtgUsuario.TabIndex = 0;
            this.dtgUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulo_CellContentClick);
            this.dtgUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellDoubleClick);
            this.dtgUsuario.DoubleClick += new System.EventHandler(this.dtgUsuario_DoubleClick);
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
            this.tabPage2.Controls.Add(this.cmb_tipodoc);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtBoxIdUsuario);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.bttBuscarEmail);
            this.tabPage2.Controls.Add(this.txtBoxBuscarEmail);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtBoxIdRol);
            this.tabPage2.Controls.Add(this.cmb_Roles);
            this.tabPage2.Controls.Add(this.bttActualizar);
            this.tabPage2.Controls.Add(this.bttEliminarU);
            this.tabPage2.Controls.Add(this.bttInsertar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBoxNumDocum);
            this.tabPage2.Controls.Add(this.txtBoxTelefono);
            this.tabPage2.Controls.Add(this.txtBoxDireccion);
            this.tabPage2.Controls.Add(this.txtBoxEmail);
            this.tabPage2.Controls.Add(this.txtBoxClave);
            this.tabPage2.Controls.Add(this.txtBoxNombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "ID Rol:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "ID User:";
            // 
            // txtBoxIdUsuario
            // 
            this.txtBoxIdUsuario.Location = new System.Drawing.Point(158, 21);
            this.txtBoxIdUsuario.Name = "txtBoxIdUsuario";
            this.txtBoxIdUsuario.ReadOnly = true;
            this.txtBoxIdUsuario.Size = new System.Drawing.Size(36, 22);
            this.txtBoxIdUsuario.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(576, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Buscar el Email para actualizar usuario.";
            // 
            // bttBuscarEmail
            // 
            this.bttBuscarEmail.Location = new System.Drawing.Point(823, 19);
            this.bttBuscarEmail.Name = "bttBuscarEmail";
            this.bttBuscarEmail.Size = new System.Drawing.Size(115, 26);
            this.bttBuscarEmail.TabIndex = 24;
            this.bttBuscarEmail.Text = "Buscar";
            this.bttBuscarEmail.UseVisualStyleBackColor = true;
            this.bttBuscarEmail.Click += new System.EventHandler(this.bttBuscarEmail_Click);
            // 
            // txtBoxBuscarEmail
            // 
            this.txtBoxBuscarEmail.Location = new System.Drawing.Point(494, 21);
            this.txtBoxBuscarEmail.Name = "txtBoxBuscarEmail";
            this.txtBoxBuscarEmail.Size = new System.Drawing.Size(323, 22);
            this.txtBoxBuscarEmail.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Rol *:";
            // 
            // txtBoxIdRol
            // 
            this.txtBoxIdRol.Location = new System.Drawing.Point(365, 21);
            this.txtBoxIdRol.Name = "txtBoxIdRol";
            this.txtBoxIdRol.ReadOnly = true;
            this.txtBoxIdRol.Size = new System.Drawing.Size(36, 22);
            this.txtBoxIdRol.TabIndex = 21;
            // 
            // cmb_Roles
            // 
            this.cmb_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Roles.FormattingEnabled = true;
            this.cmb_Roles.Location = new System.Drawing.Point(158, 51);
            this.cmb_Roles.Name = "cmb_Roles";
            this.cmb_Roles.Size = new System.Drawing.Size(121, 24);
            this.cmb_Roles.TabIndex = 20;
            this.cmb_Roles.SelectedIndexChanged += new System.EventHandler(this.cmb_Roles_SelectedIndexChanged);
            this.cmb_Roles.Click += new System.EventHandler(this.cmb_Roles_Click);
            // 
            // bttActualizar
            // 
            this.bttActualizar.Location = new System.Drawing.Point(44, 506);
            this.bttActualizar.Name = "bttActualizar";
            this.bttActualizar.Size = new System.Drawing.Size(89, 23);
            this.bttActualizar.TabIndex = 19;
            this.bttActualizar.Text = "Actualizar";
            this.bttActualizar.UseVisualStyleBackColor = true;
            this.bttActualizar.Click += new System.EventHandler(this.bttActualizar_Click);
            // 
            // bttEliminarU
            // 
            this.bttEliminarU.Location = new System.Drawing.Point(297, 506);
            this.bttEliminarU.Name = "bttEliminarU";
            this.bttEliminarU.Size = new System.Drawing.Size(101, 23);
            this.bttEliminarU.TabIndex = 17;
            this.bttEliminarU.Text = "Eliminar";
            this.bttEliminarU.UseVisualStyleBackColor = true;
            this.bttEliminarU.Click += new System.EventHandler(this.bttEliminarU_Click);
            // 
            // bttInsertar
            // 
            this.bttInsertar.Location = new System.Drawing.Point(168, 506);
            this.bttInsertar.Name = "bttInsertar";
            this.bttInsertar.Size = new System.Drawing.Size(93, 23);
            this.bttInsertar.TabIndex = 16;
            this.bttInsertar.Text = "Insertar";
            this.bttInsertar.UseVisualStyleBackColor = true;
            this.bttInsertar.Click += new System.EventHandler(this.bttInsertar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Clave *:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email *:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Los campos con (*) deben estar llenos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre *:";
            // 
            // txtBoxNumDocum
            // 
            this.txtBoxNumDocum.Location = new System.Drawing.Point(158, 239);
            this.txtBoxNumDocum.Name = "txtBoxNumDocum";
            this.txtBoxNumDocum.Size = new System.Drawing.Size(243, 22);
            this.txtBoxNumDocum.TabIndex = 5;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(158, 311);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(243, 22);
            this.txtBoxTelefono.TabIndex = 4;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(158, 377);
            this.txtBoxDireccion.Multiline = true;
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(243, 83);
            this.txtBoxDireccion.TabIndex = 3;
            this.txtBoxDireccion.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(625, 106);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(243, 22);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // txtBoxClave
            // 
            this.txtBoxClave.Location = new System.Drawing.Point(625, 182);
            this.txtBoxClave.Name = "txtBoxClave";
            this.txtBoxClave.Size = new System.Drawing.Size(243, 22);
            this.txtBoxClave.TabIndex = 1;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(158, 103);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(243, 22);
            this.txtBoxNombre.TabIndex = 0;
            // 
            // cmb_tipodoc
            // 
            this.cmb_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipodoc.FormattingEnabled = true;
            this.cmb_tipodoc.Location = new System.Drawing.Point(155, 179);
            this.cmb_tipodoc.Name = "cmb_tipodoc";
            this.cmb_tipodoc.Size = new System.Drawing.Size(246, 24);
            this.cmb_tipodoc.TabIndex = 29;
            this.cmb_tipodoc.SelectedIndexChanged += new System.EventHandler(this.cmb_tipodoc_SelectedIndexChanged);
            this.cmb_tipodoc.Click += new System.EventHandler(this.cmb_tipodoc_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 583);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button bttBuscarUsuario;
        private System.Windows.Forms.Button bttEliminarUsuario;
        private System.Windows.Forms.Button bttDesactivarUsuario;
        private System.Windows.Forms.Button bttActivarUsuario;
        private System.Windows.Forms.CheckBox chkSeleccionarUsuario;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBoxNumDocum;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxClave;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.Button bttEliminarU;
        private System.Windows.Forms.Button bttInsertar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxIdRol;
        private System.Windows.Forms.ComboBox cmb_Roles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxIdUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttBuscarEmail;
        private System.Windows.Forms.TextBox txtBoxBuscarEmail;
        private System.Windows.Forms.ComboBox cmb_tipodoc;
    }
}