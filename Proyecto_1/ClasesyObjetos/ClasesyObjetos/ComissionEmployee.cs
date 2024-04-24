using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyObjetos
{
    class ComissionEmployee
    {
        //PropiedadesAUTOgenerados
        public string FirstName { get;}
        public string LastName { get;}
        public string SocialSecurityNumber { get; }
        public decimal Salary { get;}

        //Atributos
        private decimal grossSales;
        private decimal comissionRate;

        //Propiedades para los atributos

        public decimal GrossSales
        {
            get 
            { 
                return grossSales; 
            }
            set 
            { 
                if (value < 0)
                {
                    Console.WriteLine("Error: 'las ventas deben ser 0 o mas'");
                    return;
                } 
                grossSales = value;
            }
        }

        public decimal ComissionRate
        {
            get
            {
                return comissionRate;
            }
            set
            {
                if (value < 0 || value >= 1)
                {
                    Console.WriteLine("Error: 'la tasa de comisiones debe ser menor que 1'");
                    return;
                }
                comissionRate = value;
            }
        }

        //Constructor

        public ComissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal comisionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            GrossSales = grossSales;
            comissionRate = comisionRate;
        }

        // Comportamientos o funciones
        public decimal Earnings()
        {
            return grossSales * comissionRate;
        }

        public override string ToString()
        {
            return $"Empleado por comision: {FirstName} {LastName}\n" +
                $"Numero de Seguridad Social: {SocialSecurityNumber}\n" +
                $"Ventas Brutas: {GrossSales:C}\n" +
                $"Tasa de comision: {ComissionRate}\n" +
                $"Ganancias del empleado: {Earnings():C}\n";
        }


    }
}
