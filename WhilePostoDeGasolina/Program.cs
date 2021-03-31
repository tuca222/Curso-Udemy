using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePostoDeGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorAlcool = 0;
            int contadorGasolina = 0;
            int contadorDiesel = 0;

            Console.Write("Insira o tipo de combustivel abastecido " +
                "(1-Alcool, 2-Gasolina, 3-Diesel, 4-Finaliza o programa): ");

            int tipoCombustivel = int.Parse(Console.ReadLine());

            while(tipoCombustivel != 4)
            {
                if (tipoCombustivel == 1)
                {
                    contadorAlcool++;
                }
                else if (tipoCombustivel == 2)
                {
                    contadorGasolina++;
                }
                else if (tipoCombustivel == 3)
                {
                    contadorDiesel++;
                }

                Console.Write("Insira o tipo de combustivel abastecido " +
                "(1-Alcool, 2-Gasolina, 3-Diesel, 4-Finaliza o programa): ");

                tipoCombustivel = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {contadorAlcool}");
            Console.WriteLine($"Gasolina: {contadorGasolina}");
            Console.WriteLine($"Diesel: {contadorDiesel}");




            Console.ReadLine();
        }
    }
}
