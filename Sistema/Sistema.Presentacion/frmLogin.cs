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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bttAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = NUsuarios.Login(textBox1.Text.Trim(), textBox2.Text.Trim());
                if(dt.Rows.Count <= 0 ) 
                {
                    MessageBox.Show("El email o la clave son incorrectos", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (Convert.ToBoolean(dt.Rows[0][4]) == false) 
                    {
                        MessageBox.Show("Este usuario esta inactivo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmPrincipal frm = new frmPrincipal();
                        frm.IdUsuario = Convert.ToInt32(dt.Rows[0][0]);
                        Variables.IdUsuario = Convert.ToInt32(dt.Rows[0][0]);
                        frm.IdRol = Convert.ToInt32(dt.Rows[0][1]);
                        frm.Rol = Convert.ToString(dt.Rows[0][2]);
                        frm.Nombre = Convert.ToString(dt.Rows[0][3]);
                        frm.Estado = Convert.ToBoolean(dt.Rows[0][4]);
                        frm.Show();
                        this.Hide(); // Oculta uno y muestra el otro.
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
