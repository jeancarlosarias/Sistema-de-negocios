using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private string Base; //
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool seguridad;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor = "Jean-Capone-30022132\\SQLEXPRESS";
            this.Usuario = "";
            this.Clave = "";
            this.seguridad = true;
        }

        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            
            try
            {
                cadena.ConnectionString = "Server" + this.Servidor + "Database" + this.Base + ";";
                if (this.seguridad)// Si nos vamos a logear con la autentificacion de windows
                {
                    cadena.ConnectionString += "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString += "User Id=" + this.Usuario + ";Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;

        }

        public static Conexion getInstancia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
