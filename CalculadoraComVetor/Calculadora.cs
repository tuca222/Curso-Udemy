using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComVetor
{
    class Calculadora
    {

        //Modo errado
        public static double Soma(double[] vetorNumeros)
        {
            double soma = 0;
            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                soma += vetorNumeros[i];
            }
            return soma;
        }
        //Modo certo
        public static double Somar(params double[] vetor)
        {
            double soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }

        //Modo errado
        public static void Triplica(double x)
        {
            x *= 3;
        }

        //Modo certo
        public static void Triplicar(ref double x)
        {
            x *= 3;
        }

        public static void Triple(double x, out double resultado)
        {
            resultado = x * 3;
        }

    }
}
