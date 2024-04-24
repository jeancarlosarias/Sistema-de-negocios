using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Models
{
    internal class Empleado
    {
        public int Id { get; set; }
        public float Tasa_Salarial { get; set; }
        public int Max_Horas { get; set;}

        // Constructor
        public Empleado(int id, float tasa_Salarial, int max_Horas) 
        { 
            Id = id;
            Tasa_Salarial = tasa_Salarial;
            Max_Horas = max_Horas;
        }
        // Crear empleado
        public static Empleado Crear(int id, float tasa, int horas)
        {
           Empleado empleado = new Empleado(id, tasa, horas);
            
           return empleado;
           
        }
        // Actualizar
        public void Actualizar(Empleado encontrado, int id)
        {
                Console.WriteLine($"Introduce la nueva tasa salarial: ");
                encontrado.Tasa_Salarial = float.Parse(Console.ReadLine());
                Console.WriteLine($"Introduce la nueva Hora maxima: ");
                encontrado.Max_Horas = int.Parse(Console.ReadLine());

                encontrado.ObtenerData();
            
        }
        public void ObtenerData()
        {
            // Presentacion
            Console.WriteLine($"El empleado de ID: {Id}\n" +
                $"Tasa Salarial: {Tasa_Salarial}\n" +
                $"Maximo de Horas: {Max_Horas}\n");
        }


    }
}
