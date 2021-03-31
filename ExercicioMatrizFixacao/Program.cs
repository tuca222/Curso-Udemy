using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatrizFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as dimenções da matriz (Linhas e Colunas):  ");
            string[] dimencao = Console.ReadLine().Split(' ');
            int nLinhas = int.Parse(dimencao[0]);
            int nColunas = int.Parse(dimencao[1]);

            int[,] matriz = new int[nLinhas, nColunas];

            Console.WriteLine("Entre com a sua matriz respeitando as dimenções: ");

            //lendo a matriz
            for (int i = 0; i < nLinhas; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < nColunas; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
                
            }


            Console.WriteLine();
            Console.Write("Insira o numero que você detelhes: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLinhas; i++)
            {
                for (int j = 0; j < nColunas; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Posição {i}, {j}: ");
                        if (j > 0)
                        {
                            Console.WriteLine($"A esqueda: {matriz[i, j-1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Em cima: {matriz[i - 1, j]}");
                        }
                        if (j < nColunas - 1)
                        {
                            Console.WriteLine($"A direita: {matriz[i, j + 1]}");
                        }
                        if (i < nLinhas - 1)
                        {
                            Console.WriteLine($"Em baixo: {matriz[i + 1, j]}");
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
