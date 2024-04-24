using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;


namespace Presentacion
{
    public partial class FRMCategoria : Form
    {
        

        public FRMCategoria()
        {
            InitializeComponent();
        }
        // Listar las categorias

        private void Listar()
        {
            try
            {
                dgvListado.DataSource = NCategoria.Listar();
                this.Formato();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Metodo para buscar una categoria
        private void Buscar()
        {
            dgvListado.DataSource = NCategoria.Buscar(txtBuscar.Text);
            this.Formato();
            lblTotal.Text = $"Total de Registros: {dgvListado.RowCount}";
        }

        private void FRMCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void Formato()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[2].Width = 150;
            dgvListado.Columns[3].Width = 300;
            dgvListado.Columns[3].HeaderText = "Descripcion";
            dgvListado.Columns[4].Width = 100;
       }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // Mensaje de Error
        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string msg)
        {
            MessageBox.Show(msg, "Sistema de ventas");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
