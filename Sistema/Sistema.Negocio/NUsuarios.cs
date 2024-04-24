using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class NUsuarios
    {
        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Buscar(valor);
        }

        public static string Insertar(int idrol, string nombre, string tipodocumento, string numdocumento, string direccion, string telefono, string email, string clave)
        {
            DUsuario Datos = new DUsuario();

            string existe = Datos.Existe(nombre);
            if (existe == "1")
            {
                return "El Usuario ya existe";
            }
            else
            {
                Usuario Obj = new Usuario();
                Obj.RolId = idrol;
                Obj.Nombre = nombre;
                Obj.TipoDocumento = tipodocumento;
                Obj.NumDocumento = numdocumento;
                Obj.Direccion = direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                Obj.Clave = clave;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int idusuario, int idrol, string nombre, string tipodocumento, string numdocumento, string direccion, string telefono, string email, string clave)
        {
            DUsuario Datos = new DUsuario();
            Usuario Obj = new Usuario();
            Obj.UsuarioId = idusuario;
            Obj.RolId = idrol;
            Obj.Nombre = nombre;
            Obj.TipoDocumento = tipodocumento;
            Obj.NumDocumento = numdocumento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Clave = clave;

            return Datos.Actualizar(Obj);

        }


        public static string Eliminar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Desactivar(Id);
        }

        public static DataTable Email(string email)
        {
            DUsuario Datos = new DUsuario();
            return Datos.BuscarEmail(email);
        }

        public static DataTable Login(string email, string clave)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Login(email, clave);
        }
    }
}
