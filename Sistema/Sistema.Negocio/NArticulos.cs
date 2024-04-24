using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class NArticulos
    {
        public static DataTable ListarArticulo()
        {
            DArticulos Datos = new DArticulos();
            return Datos.ListarArticulo();
        }

        public static DataTable BuscarArticulo(string valor)
        {
            DArticulos Datos = new DArticulos();
            return Datos.BuscarArticulo(valor);
        }

        public static string InsertarAriculo(int idcategoria ,string codigo, string nombre, decimal precio_venta, int stock, string descripcion, string imagen)
        {
            DArticulos Datos = new DArticulos();

            string existe = Datos.ExisteArticulo(nombre);
            if (existe == "1")
            {
                return "El articulo ya existe";
            }
            else
            {
                Articulo Obj = new Articulo();
                Obj.IdCategoria = idcategoria;
                Obj.Codigo = codigo;
                Obj.Nombre = nombre;
                Obj.Precio_venta = precio_venta;
                Obj.Stock = stock;
                Obj.Descripcion = descripcion;
                Obj.Imagen = imagen;
                return Datos.InsertarArticulo(Obj);
            }
        }

        public static string ActualizarArticulo(int id, string nombreAnterior, string codigo, string nombre, decimal precio_venta, int stock, string descripcion, string imagen)
        {
            DArticulos Datos = new DArticulos();
            Articulo Obj = new Articulo();

            if (nombreAnterior == nombre)
            {
                Obj.IdArticulo = id;
                Obj.Codigo = codigo;
                Obj.Nombre = nombre;
                Obj.Precio_venta = precio_venta;
                Obj.Stock = stock;
                Obj.Descripcion = descripcion;
                Obj.Imagen = imagen;

                return Datos.ActualizarArticulo (Obj);
            }
            else
            {
                string Existe = Datos.ExisteArticulo(nombre);
                if (Existe.Equals("1"))
                {
                    return "El articulo ya existe";
                }
                else
                {
                    Obj.IdArticulo = id;
                    Obj.Codigo = codigo;
                    Obj.Nombre = nombre;
                    Obj.Precio_venta = precio_venta;
                    Obj.Stock = stock;
                    Obj.Descripcion = descripcion;
                    Obj.Imagen = imagen;

                    return Datos.ActualizarArticulo(Obj);
                }
            }


        }

        public static string EliminarArticulo(int Id)
        {
            DArticulos Datos = new DArticulos();
            return Datos.EliminarAriculo(Id);
        }

        public static string ActivarArticulo(int Id)
        {
            DArticulos Datos = new DArticulos();
            return Datos.ActivarArticulo(Id);
        }

        public static string DesactivarArticulo(int Id)
        {
            DArticulos Datos = new DArticulos();
            return Datos.DesactivarArticulo(Id);
        }

        public static DataTable CategoriaListar()
        {
            DArticulos Datos = new DArticulos();
            return Datos.ListarCategorias();
        }

        public static DataTable BuscarArticuloCodigo(string valor)
        {
            DArticulos Datos = new DArticulos();
            return Datos.BuscarArticuloCodigo(valor);
        }


    }
}
