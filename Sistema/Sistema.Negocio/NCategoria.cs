using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;
using Sistema.Datos;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Negocio
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

        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria Datos = new DCategoria();

            string existe = Datos.Existe(nombre);
            if (existe == "1") 
            {
                return "La Categoría ya existe";
            }
            else
            {
                Categoria Obj = new Categoria();
                Obj.Nombre = nombre;
                Obj.Descripcion = descripcion;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int id, string nombreAnterior, string nombre, string descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria Obj = new Categoria();

            if (nombreAnterior == nombre)
            {
                Obj.IdCategoria = id;
                Obj.Nombre = nombre;
                Obj.Descripcion = descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(nombre);
                if (Existe.Equals("1"))
                {
                    return "La categoría ya existe";
                }
                else
                {

                    Obj.IdCategoria = id;
                    Obj.Nombre = nombre;
                    Obj.Descripcion = descripcion;
                    return Datos.Actualizar(Obj);
                }
            }


        }

        public static string Eliminar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desactivar(Id);
        }
        
    }
}

