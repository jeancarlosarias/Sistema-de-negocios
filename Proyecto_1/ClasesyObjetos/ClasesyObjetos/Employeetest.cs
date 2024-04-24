using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClasesyObjetos
{
    internal class Employeetest
    {
        static void Main(string[] args)
        {
            // Crear Empleado

            var Empleado = new ComissionEmployee("Jean Carlos", "Arias", "1452", 1000.84M, 0.06M);

            // Mostrar informacion

            Console.WriteLine("Informacion de un empleado por comision: \n");
            Console.WriteLine(Empleado.ToString());
            ComissionEmployee empleado = null;

            while (true)
            {
                int opcion;
                string firstName;
                string lastName;
                string socialSecurityNumber;
                decimal grossSales;
                decimal commissionRate;

                Console.WriteLine("1 - Crear un Empleado por comision\n");
                Console.WriteLine("2 - Ver datos del Empleado\n");

                Console.Write("Selecciona un opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Digite el nombre del empleado: ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Digite el apellido del empleado: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Digite el numero de seguridad social del empleado: ");
                        socialSecurityNumber = Console.ReadLine();
                        Console.WriteLine("Digite las ventas brutas del empleado: ");
                        grossSales = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite la tasa de comisiones del empleado: ");
                        commissionRate = decimal.Parse(Console.ReadLine());
                        empleado = new ComissionEmployee(firstName, lastName, socialSecurityNumber, grossSales, commissionRate);
                        break;
                    case 2:
                        Console.WriteLine(empleado.ToString());
                        break;

                }
            }
        }
        
       

    }
}
