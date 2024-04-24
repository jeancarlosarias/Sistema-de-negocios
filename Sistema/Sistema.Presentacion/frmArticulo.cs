using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Sistema.Presentacion;
using Sistema.Negocio;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using System.Runtime.InteropServices.ComTypes;

namespace Sistema.Presentacion
{
    public partial class frmArticulo : Form
    {

        public frmArticulo()
        {
            InitializeComponent();
        }

        private void Formato()
        {
            dtgArticulo.Columns[0].Visible = false;
            dtgArticulo.Columns[1].Visible = false;
            dtgArticulo.Columns[2].Width = 150;
            dtgArticulo.Columns[3].Width = 100;
            dtgArticulo.Columns[4].Width = 100;
            dtgArticulo.Columns[6].HeaderText = "Precio Venta";
            dtgArticulo.Columns[7].Width = 300;
        }
        private void Buscar()
        {
            dtgArticulo.DataSource = NArticulos.BuscarArticulo(txtboxArticulo.Text);
            this.Formato();
            lblRegistro.Text = $"Total de Registros: {dtgArticulo.RowCount}";
        }
        private void frmArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void chkSeleccionarArt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionarArt.Checked)
            {
                dtgArticulo.Columns[0].Visible = true;
                bttActivarArt.Visible = true;
                bttDesactivarArt.Visible = true;
                bttEliminar.Visible = true;
            }
            else
            {
                dtgArticulo.Columns[0].Visible = false;
                bttActivarArt.Visible = false;
                bttDesactivarArt.Visible = false;
                bttEliminar.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea eliminar este Articulo?", "Sistema de ventas-Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dtgArticulo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NArticulos.EliminarArticulo(codigo);
                            if (respuesta == "OK")
                            {
                                this.MensajeOK($"Se Elimino el articulo: {row.Cells[5].Value}");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea desactivar este Articulo?", "Sistema de ventas-Desactivar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dtgArticulo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NArticulos.DesactivarArticulo(codigo);
                            if (respuesta == "OK")
                            {
                                this.MensajeOK($"Se desactivo el Articulo: {row.Cells[5].Value}");
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

        private void dtgArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgArticulo.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dtgArticulo.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void bttActivarArt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea activar este Articulo?", "Sistema de ventas-Activar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dtgArticulo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NArticulos.ActivarArticulo(codigo);
                            if (respuesta == "OK")
                            {
                                this.MensajeOK($"Se activo el Articulo: {row.Cells[5].Value}");
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
            txtboxArticulo.Clear();
            txtBoxCodigoBarra.Clear();
            txtBx1.Clear();
            cmb_Categorias.Items.Clear();
            txtBoxStock.Clear();
            txtBoxPrecioVenta.Clear();
            txtBoxDescripcion.Clear();
            txtBoxImagen.Clear();
            panel1.BackgroundImage = null;
            pictureBox1.Image = null;
            txtBoxNombre.Clear();

            bttActivarArt.Visible = false;
            bttEliminar.Visible = false;
            bttDesactivarArt.Visible = false;
            chkSeleccionarArt.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtBx1.Clear();
                DataTable dt = new DataTable();
                dt = NArticulos.CategoriaListar();
                foreach (DataRow fila in dt.Rows)
                {
                    var idcat = fila["idcategoria"];
                    var nomb = fila["nombre"].ToString();
                    if (nomb == cmb_Categorias.SelectedItem.ToString())
                    {
                        if (txtBx1.Text == "")
                        {
                            txtBx1.Text = idcat.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Categorias_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_Categorias.Items.Clear();
                DataTable dt = NArticulos.CategoriaListar();
                foreach (DataRow fila in dt.Rows)
                {
                    var nomb = fila["nombre"];
                    cmb_Categorias.Items.Add(nomb);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bttGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
            barcode.IncludeLabel = true;

            panel1.BackgroundImage = barcode.Encode(BarcodeLib.TYPE.CODE128, txtBoxCodigoBarra.Text, Color.Black, Color.White);
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            System.Drawing.Image guardado = (System.Drawing.Image)panel1.BackgroundImage.Clone();
            SaveFileDialog otro = new SaveFileDialog();
            otro.AddExtension = true;
            otro.Filter = "PNG IMAGE(.png) | *.png";
            otro.ShowDialog();

            if (!string.IsNullOrEmpty(otro.FileName))
            {
                guardado.Save(otro.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

            otro.Dispose();

        }

        private void bttImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Imagen files (png) | *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                txtBoxImagen.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf("\\") + 1);
            }
        }

        private void bttInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtBoxNombre.Text == string.Empty && txtBoxCodigoBarra.Text == string.Empty && cmb_Categorias.Text == string.Empty && txtBoxPrecioVenta.Text == string.Empty)
                {
                    this.MensajeError("Debe ingresar todos los campos requeridos");
                }
                else
                {
                    respuesta = NArticulos.InsertarAriculo(int.Parse(txtBx1.Text), txtBoxCodigoBarra.Text, txtBoxNombre.Text, decimal.Parse(txtBoxPrecioVenta.Text), int.Parse(txtBoxStock.Text), txtBoxDescripcion.Text, txtBoxImagen.Text);
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

        private void Listar()
        {
            try
            {
                dtgArticulo.DataSource = NArticulos.ListarArticulo();
                lblRegistro.Text = $"Total de Registros: {dtgArticulo.RowCount}";
                this.Limpiar();
                this.Formato();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dtgArticulo_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dtgArticulo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                bttActualizar.Visible = true;
                bttInsertar.Visible = false;
                txtBx1.Text = dtgArticulo.CurrentRow.Cells["ID"].Value.ToString();
                txtBoxNombre.Text = dtgArticulo.CurrentRow.Cells["Nombre"].Value.ToString();
                txtBoxDescripcion.Text = dtgArticulo.CurrentRow.Cells["Descripcion"].Value.ToString();
                tabControl1.SelectedIndex = 1;

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Seleccione una celda a partir del nombre \nError:{ex.Message}");
            }
        }

        private void bttEliminarArtMan_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void bttActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta;
                if (txtBoxNombre.Text == string.Empty || txtBx1.Text == string.Empty)
                {
                    this.MensajeError("Ingresar los datos indicados");
                }
                else
                {
                    respuesta = NArticulos.ActualizarArticulo(Convert.ToInt32(txtBx1.Text), "",txtBoxCodigoBarra.Text, txtBoxNombre.Text, decimal.Parse(txtBoxPrecioVenta.Text), int.Parse(txtBoxStock.Text), txtBoxDescripcion.Text, txtBoxImagen.Text);
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

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgArticulo.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = dtgArticulo.Rows[e.RowIndex];

                string id = filaSeleccionada.Cells[1].Value.ToString();
                string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string precio = filaSeleccionada.Cells["Precio_Venta"].Value.ToString();
                string stock = filaSeleccionada.Cells["Stock"].Value.ToString();
                string descripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString();


                Limpiar();

                txtBx1.Text = id;
                txtBoxNombre.Text = nombre;
                txtBoxCodigoBarra.Text = codigo;
                txtBoxPrecioVenta.Text = precio;
                txtBoxStock.Text = stock;
                txtBoxDescripcion.Text = descripcion;

                tabControl1.SelectedIndex = 1;
            }
        }
    }
}
