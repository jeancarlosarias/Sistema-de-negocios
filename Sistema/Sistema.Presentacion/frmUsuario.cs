using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtBoxBuscar.Clear();
            txtBoxClave.Clear();
            txtBoxDireccion.Clear();
            txtBoxEmail.Clear();
            txtBoxNombre.Clear();
            txtBoxBuscarEmail.Clear();
            txtBoxNumDocum.Clear();
            txtBoxTelefono.Clear();
            cmb_tipodoc.Items.Clear();
            txtBoxIdRol.Clear();
            txtBoxIdUsuario.Clear();
            cmb_Roles.Items.Clear();


        }

        private void Formato()
        {
            dtgUsuario.Columns[0].Visible = false;
            dtgUsuario.Columns[1].Visible = false;
            dtgUsuario.Columns[2].Width = 50;
            dtgUsuario.Columns[3].Width = 100;
            dtgUsuario.Columns[4].Width = 100;
            dtgUsuario.Columns[5].Width = 150;
            dtgUsuario.Columns[6].Width = 150;
            dtgUsuario.Columns[6].HeaderText = "Numero Documento";
            dtgUsuario.Columns[5].HeaderText = "Tipo Documento";
            dtgUsuario.Columns[7].Width = 300;
        }
        private void Buscar()
        {
            dtgUsuario.DataSource = NUsuarios.Buscar(txtBoxBuscar.Text);
            this.Formato();
            lblRegistro.Text = $"Total de Registros: {dtgUsuario.RowCount}";
        }
        private void Listar()
        {
            try
            {
                dtgUsuario.DataSource = NUsuarios.Listar();
                lblRegistro.Text = $"Total de Registros: {dtgUsuario.RowCount}";
                this.Limpiar();
                this.Formato();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgUsuario.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dtgUsuario.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void bttBuscarArt_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string msg)
        {
            MessageBox.Show(msg, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttBuscarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxIdUsuario.Clear();
                txtBoxIdRol.Clear();
                DataTable dt = new DataTable();
                dt = NUsuarios.Email(txtBoxBuscarEmail.Text);
                foreach (DataRow fila in dt.Rows)
                {
                    var iduser = fila["idusuario"].ToString();
                    var idrol = fila["idrol"].ToString();
                    var rol = fila["nombre"].ToString();
                    var nombre = fila["nombre1"].ToString();
                    var tipdocum = fila["tipo_documento"].ToString();
                    var numdocum = fila["num_documento"].ToString();
                    var direcc = fila["direccion"].ToString();
                    var telf = fila["telefono"].ToString();
                    var email = fila["email"].ToString();

                    txtBoxIdUsuario.Text = iduser;
                    txtBoxIdRol.Text = idrol;
                    cmb_Roles.Text = rol;
                    txtBoxNombre.Text = nombre;
                    cmb_tipodoc.Text = tipdocum;
                    txtBoxNumDocum.Text = numdocum;
                    txtBoxDireccion.Text = direcc;
                    txtBoxTelefono.Text = telf;
                    txtBoxEmail.Text = email;

                    txtBoxBuscarEmail.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkSeleccionarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionarUsuario.Checked)
            {
                dtgUsuario.Columns[0].Visible = true;
                bttActivarUsuario.Visible = true;
                bttDesactivarUsuario.Visible = true;
                bttEliminarUsuario.Visible = true;
            }
            else
            {
                dtgUsuario.Columns[0].Visible = false;
                bttActivarUsuario.Visible = false;
                bttDesactivarUsuario.Visible = false;
                bttEliminarUsuario.Visible = false;
            }
        }

        private void bttActivarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea activar este Usuario?", "Sistema de ventas-Activar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dtgUsuario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NUsuarios.Activar(codigo);
                            if (respuesta == "OK")
                            {
                                this.MensajeOK($"Se activo el Usuario: {row.Cells[5].Value}");
                                if (chkSeleccionarUsuario.Checked == true)
                                {
                                    chkSeleccionarUsuario.Checked = false;
                                }
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }

                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void bttDesactivarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea desactivar este Usuario?", "Sistema de ventas-Desactivar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dtgUsuario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NUsuarios.Desactivar(codigo);
                            if (respuesta == "OK")
                            {
                                this.MensajeOK($"Se desactivo el Usuario: {row.Cells[5].Value}");
                                if (chkSeleccionarUsuario.Checked == true)
                                {
                                    chkSeleccionarUsuario.Checked = false;
                                }
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }

                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void bttEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea eliminar este Usuario?", "Sistema de ventas-Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dtgUsuario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NUsuarios.Eliminar(codigo);
                            if (respuesta == "OK")
                            {
                                this.MensajeOK($"Se Elimino el Usuario: {row.Cells[5].Value}");
                                if (chkSeleccionarUsuario.Checked == true)
                                {
                                    chkSeleccionarUsuario.Checked = false;
                                }
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }

                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void bttInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtBoxNombre.Text == string.Empty && txtBoxEmail.Text == string.Empty && cmb_Roles.Text == string.Empty && txtBoxClave.Text == string.Empty)
                {
                    this.MensajeError("Debe ingresar todos los campos requeridos");
                }
                else
                {
                    respuesta = NUsuarios.Insertar(int.Parse(txtBoxIdRol.Text), txtBoxNombre.Text, cmb_tipodoc.SelectedItem.ToString(), txtBoxNumDocum.Text, txtBoxDireccion.Text, txtBoxTelefono.Text, txtBoxEmail.Text, txtBoxClave.Text);
                    if (respuesta == "OK")
                    {
                        this.MensajeOK("El registro se insertó de manera correcta");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cmb_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxIdRol.Clear();
                DataTable dt = new DataTable();
                dt = NRol.Listar();
                foreach (DataRow fila in dt.Rows)
                {
                    var idcat = fila["idrol"];
                    var nomb = fila["nombre"].ToString();
                    if (nomb == cmb_Roles.SelectedItem.ToString())
                    {
                        if (txtBoxIdRol.Text == "")
                        {
                            txtBoxIdRol.Text = idcat.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Roles_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_Roles.Items.Clear();
                DataTable dt = NRol.Listar();
                foreach (DataRow fila in dt.Rows)
                {
                    var nomb = fila["nombre"];
                    cmb_Roles.Items.Add(nomb);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bttEliminarU_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void bttActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta;
                if (txtBoxNombre.Text == string.Empty || txtBoxEmail.Text == string.Empty || cmb_Roles.Text == string.Empty)
                {
                    this.MensajeError("Ingresar los datos indicados con (*)");
                }
                else
                {
                    respuesta = NUsuarios.Actualizar(int.Parse(txtBoxIdUsuario.Text), int.Parse(txtBoxIdRol.Text), txtBoxNombre.Text, cmb_tipodoc.SelectedItem.ToString(), txtBoxNumDocum.Text, txtBoxDireccion.Text, txtBoxTelefono.Text, txtBoxEmail.Text, txtBoxClave.Text);
                    if (respuesta == "OK")
                    {
                        this.MensajeOK("Se actualizó el registro de manera correcta");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void cmb_tipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_tipodoc_Click(object sender, EventArgs e)
        {
            cmb_tipodoc.Items.Clear();
            cmb_tipodoc.Items.Add("CEDULA");
            cmb_tipodoc.Items.Add("PASAPORTE");
        }

        private void dtgUsuario_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dtgUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgUsuario.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = dtgUsuario.Rows[e.RowIndex];

                string id = filaSeleccionada.Cells[1].Value.ToString();
                string idRol = filaSeleccionada.Cells["idrol"].Value.ToString();
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string numeroDocumento = filaSeleccionada.Cells["Num_Documento"].Value.ToString();
                string direccion = filaSeleccionada.Cells["Direccion"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();

                Limpiar();

                txtBoxIdUsuario.Text = id;
                txtBoxIdRol.Text = idRol;
                txtBoxNombre.Text = nombre;
                txtBoxNumDocum.Text = numeroDocumento;
                txtBoxDireccion.Text = direccion;
                txtBoxTelefono.Text = telefono;
                txtBoxEmail.Text = email;

                tabControl1.SelectedIndex = 1;
            }
        }
    }
}
