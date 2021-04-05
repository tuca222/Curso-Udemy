using ExercicioFuncionariosDaEmpresaOuTercerizados.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionariosDaEmpresaOuTercerizados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbe of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{(i+1)} Data: ");
                Console.Write("Outsourced (Y, N)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y' || outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(employee);
                }

                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
                Console.WriteLine();
            }

            foreach(Employee e in employees)
            {
                Console.WriteLine(e);
            }




            Console.ReadLine();
        }
    }
}
