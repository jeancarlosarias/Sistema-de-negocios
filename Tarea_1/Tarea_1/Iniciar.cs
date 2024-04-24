using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tarea_1.Models;

namespace Tarea_1
{
    internal class Iniciar
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

                // Creando la interfaz
                while (true)
                {
                    int x = empleados.Any() ? empleados.Max(e => e.Id) + 1 : 1;
                    int opcion;
                    int id;
                    float tasa;
                    int horas;
                    Empleado nw;

                    
                    

                    Console.WriteLine("1 - Crear un Empleado\n");
                    Console.WriteLine("2 - Modificar un Empleado\n");
                    Console.WriteLine("3 - Ver empleados\n");

                    Console.Write("Selecciona un opcion: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Digite la tasa salarial del empleado: ");
                            tasa = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite las horas del empleado: ");
                            horas = int.Parse(Console.ReadLine());
                            Console.WriteLine("\n");

                            Empleado empleado = new Empleado(x, tasa, horas);

                            empleados.Add(empleado);
                            empleado.ObtenerData();

                            break;
                        case 2:
                            Console.WriteLine("Ingrese su ID: ");
                            id = int.Parse(Console.ReadLine());

                            var encontrado = empleados.FirstOrDefault(e => e.Id == id);
                            if (encontrado == null)
                             {
                                Console.WriteLine($"El empleado con el ID: {id}, no se encontro en los registros.");

                             }
                            else
                            {
                                 encontrado.Actualizar(encontrado, id);
                            }
                            
                            break;
                        case 3:
                            Console.WriteLine("Empleados: \n");
                            foreach (Empleado e in empleados)
                            {
                                e.ObtenerData();
                              
                            }
                        break;
                        
                      
                    }
                }
            
        }
    }
}
