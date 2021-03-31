using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosListasFuncionarios
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentarSalario(double aumento)
        {
            Salario += Salario * aumento / 100.0;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
