using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            //double[,] matriz = new double[3, 2]; // matriz - 3 linhas / 2 colunas

            //Console.WriteLine(matriz.Length); //numero total de argumentos na matriz

            //Console.WriteLine(matriz.Rank);

            //Console.WriteLine(matriz.GetLength(0)); //numero de linhas
            //Console.WriteLine(matriz.GetLength(1)); // numero de colunas

            //Exercicio
            Console.Write("Insira um numero inteiro N para dimensionar a matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            Console.WriteLine();
            Console.WriteLine("Entre com a matriz: ");
            
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            int contadorNegativos = 0;

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        contadorNegativos++;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Quantidade de numeros negativos na matriz: " + contadorNegativos);




            Console.ReadLine();
        }
    }
}
