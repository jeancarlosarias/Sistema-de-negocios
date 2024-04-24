using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor) 
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(valor);

        }

        public static string Insertar(string Nombre, string descripcion)
        {
            DCategoria Datos = new DCategoria();

            string Existe = Datos.Existe(Nombre);
            if (Existe == "1") 
            {
                return "La categoria ya existe";
            }
            else
            {
                Categoria obj = new Categoria();
                obj.Nombre = Nombre;
                obj.Descripcion = descripcion;
                return Datos.Insertar(obj);
            }
        }

        public static string Eliminar(int valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Eliminar(valor);
        }

        public static string Actualizar(int id, string nombre, string descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria obj = new Categoria();
            obj.IdCategoria = id;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return Datos.Actualizar(obj);
        }
        
        public static string Activar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desactivar(id);
        }

    }
}
