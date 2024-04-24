using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }
        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOK(string msg)
        {
            MessageBox.Show(msg, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            txtBuscar.Clear();
            txtId.Clear();
            btnActualizar.Visible = false;
            btnInsertar.Visible = true;

            txtNombre.Clear();
            txtId.Clear();
            txtNumDoc.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtDirecc.Clear();

            chkSeleccionar.Checked = false;
        }
        private void Listar()
        {
            try
            {
                dgvListado.DataSource = NPersona.ListarProveedores();
                lblTotal.Text = $"Total de Registros: {dgvListado.RowCount}";
                this.Limpiar();
                this.Formato();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[2].HeaderText = "Tipo Persona";
            dgvListado.Columns[3].HeaderText = "Nombre";
            dgvListado.Columns[4].HeaderText = "Documento";
            dgvListado.Columns[5].HeaderText = "Numer Doc.";
            dgvListado.Columns[6].HeaderText = "Direccion";
            dgvListado.Columns[7].HeaderText = "Telefono";
            dgvListado.Columns[8].HeaderText = "Email";
            dgvListado.Columns[2].Width = 150;
            dgvListado.Columns[3].Width = 300;
            dgvListado.Columns[4].Width = 100;
        }
        private void Buscar()
        {
            dgvListado.DataSource = NPersona.BuscarProveedores(txtBuscar.Text);
            this.Formato();
            lblTotal.Text = $"Total de Registros: {dgvListado.RowCount}";
        }
        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListado.Columns["ID"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["ID"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea eliminar este Proveedor?", "Sistema de ventas-Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NCategoria.Eliminar(codigo);
                            if (respuesta == "OK")
                            {
                                this.MensajeOK($"Se Elimino el proveedor: {row.Cells[3].Value}");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvListado.Columns[0].Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                dgvListado.Columns[0].Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta;
                if (txtNombre.Text == string.Empty)
                {
                    this.MensajeError("Ingresar los datos indicados con (*)");
                }
                else
                {
                    respuesta = NPersona.Actualizar(int.Parse(txtId.Text), "Proveedor", "", txtNombre.Text, cmbTipDoc.SelectedItem.ToString(), txtNumDoc.Text, txtDirecc.Text, txtTel.Text, txtEmail.Text);
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

        private void cmbTipDoc_Click(object sender, EventArgs e)
        {
            cmbTipDoc.Items.Clear();
            cmbTipDoc.Items.Add("CEDULA");
            cmbTipDoc.Items.Add("PASAPORTE");
        }

        private void cmbTipDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtNombre.Text == string.Empty)
                {
                    this.MensajeError("Debe ingresar todos los campos requeridos");
                }
                else
                {
                    respuesta = NPersona.Insertar("Proveedor", txtNombre.Text, cmbTipDoc.SelectedItem.ToString(), txtNumDoc.Text, txtDirecc.Text, txtTel.Text, txtEmail.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvListado.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = dgvListado.Rows[e.RowIndex];

                string id = filaSeleccionada.Cells[1].Value.ToString();
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string tipoDocumento = filaSeleccionada.Cells["Tipo_Documento"].Value.ToString();
                string numDocum = filaSeleccionada.Cells["Num_Documento"].Value.ToString();
                string direccion = filaSeleccionada.Cells["Direccion"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();

                Limpiar();

                txtId.Text = id;
                cmbTipDoc.Text = tipoDocumento;
                txtNombre.Text = nombre;
                txtNumDoc.Text = numDocum;
                txtDirecc.Text = direccion;
                txtTel.Text = telefono;
                txtEmail.Text = email;

                tabGeneral.SelectedIndex = 1;
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
