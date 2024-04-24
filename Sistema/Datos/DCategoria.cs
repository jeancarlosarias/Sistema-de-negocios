using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCategoria
    {
        //Listar las categorias,
        //ver todas
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable(); // Creamos una tabla
            SqlConnection sqlcon = new SqlConnection(); // Hacemos una nueva conexion

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion(); // Buscamos dentro de la clase conexion
                SqlCommand comando = new SqlCommand("categoria_listar", sqlcon); // Hacemos un nuevo comando para listar categoria con la conexion
                comando.CommandType = CommandType.StoredProcedure; // Le decimos que tipo de comando es
                sqlcon.Open(); // Inicamos la conexion
                Resultado = comando.ExecuteReader(); // Almacenamos en una variable
                Tabla.Load(Resultado); // Y lo cargamos en la tabla
                return Tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }
        //Busca una categoria
        public DataTable Buscar(string valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable(); // Creamos una tabla
            SqlConnection sqlcon = new SqlConnection(); // Hacemos una nueva conexion

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion(); // Buscamos dentro de la clase conexion
                SqlCommand comando = new SqlCommand("categoria_buscar", sqlcon); // Hacemos un nuevo comando para listar categoria con la conexion
                comando.CommandType = CommandType.StoredProcedure; // Le decimos que tipo de comando es
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlcon.Open(); // Inicamos la conexion
                Resultado = comando.ExecuteReader(); // Almacenamos en una variable
                Tabla.Load(Resultado); // Y lo cargamos en la tabla
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }

        public string Existe(string valor)
        {
            string Respuesta = "";

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().crearConexion(); // Buscamos dentro de la clase conexion
                SqlCommand comando = new SqlCommand("categoria_existe", sqlcon); // Hacemos un nuevo comando para listar categoria con la conexion
                comando.CommandType = CommandType.StoredProcedure; // Le decimos que tipo de comando es
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                sqlcon.Open(); // Inicamos la conexion
                comando.ExecuteNonQuery(); 
                Respuesta = Convert.ToString(parExiste.Value);
                
            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Respuesta;
        }

        public string Insertar(Categoria obj)
        {
            string Respuesta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion(); // Buscamos dentro de la clase conexion
                SqlCommand comando = new SqlCommand("categoria_insertar", sqlcon); // Hacemos un nuevo comando para listar categoria con la conexion
                comando.CommandType = CommandType.StoredProcedure; // Le decimos que tipo de comando es
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                sqlcon.Open(); // Inicamos la conexion
                Respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
                
            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Respuesta;

        }

        public string Actualizar(Categoria obj)
        {
            string Respuesta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion(); // Buscamos dentro de la clase conexion
                SqlCommand comando = new SqlCommand("categoria_actualizar", sqlcon); // Hacemos un nuevo comando para listar categoria con la conexion
                comando.CommandType = CommandType.StoredProcedure; // Le decimos que tipo de comando es
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.IdCategoria;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                sqlcon.Open(); // Inicamos la conexion
                Respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";

            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Respuesta;

        }

        public string Eliminar(int idcategoria)
        {
            string Respuesta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion(); // Buscamos dentro de la clase conexion
                SqlCommand comando = new SqlCommand("categoria_eliminar", sqlcon); // Hacemos un nuevo comando para listar categoria con la conexion
                comando.CommandType = CommandType.StoredProcedure; // Le decimos que tipo de comando es
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = idcategoria;
                sqlcon.Open(); // Inicamos la conexion
                Respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Respuesta;

        }

        public string Activar(int idcategoria)
        {
            string Respuesta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion(); // Buscamos dentro de la clase conexion
                SqlCommand comando = new SqlCommand("categoria_activar", sqlcon); // Hacemos un nuevo comando para listar categoria con la conexion
                comando.CommandType = CommandType.StoredProcedure; // Le decimos que tipo de comando es
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = idcategoria;
                sqlcon.Open(); // Inicamos la conexion
                Respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";

            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Respuesta;

        }

        public string Desactivar(int idcategoria)
        {
            string Respuesta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion(); // Buscamos dentro de la clase conexion
                SqlCommand comando = new SqlCommand("categoria_desactivar", sqlcon); // Hacemos un nuevo comando para listar categoria con la conexion
                comando.CommandType = CommandType.StoredProcedure; // Le decimos que tipo de comando es
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = idcategoria;
                sqlcon.Open(); // Inicamos la conexion
                Respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";

            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Respuesta;

        }


    }
}
