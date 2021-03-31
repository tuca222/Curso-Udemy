using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista1 = new List<string>();

            lista1.Add("Arthur");
            lista1.Add("Jacqueline");
            lista1.Add("Mathias");
            lista1.Add("Jurerê");
            lista1.Add("Isa");
            lista1.Insert(0, "Jade");
            lista1.Insert(1, "Alysson");

            foreach (string nome in lista1) //Imprimindo a lista
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Quantidade de números na lista: " + lista1.Count);

            string primeiroNomeComA = lista1.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com A: " + primeiroNomeComA);

            string ultimoNomeComA = lista1.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome com A: " + ultimoNomeComA);

            int posicaoPrimeiroNomeComJ = lista1.FindIndex(x => x[0] == 'J');
            Console.WriteLine("Primeira posição do nome que começa com J: " + posicaoPrimeiroNomeComJ);

            int posicaoUltimoNomeComJ = lista1.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine("Ultima posição do nome que começa com J: " + posicaoUltimoNomeComJ);

            Console.WriteLine("------------------------------------------");

            List<string> lista2 = lista1.FindAll(x => x[0] == 'J');
            Console.Write("Lista de nomes que começam com J: ");
            Console.WriteLine();
            foreach (string nome in lista2)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------------------------------");

            List<string> lista3 = lista1.FindAll(x => x.Length == 7);
            Console.Write("Lista de nomes de tamanho 7: ");
            Console.WriteLine();
            foreach(string nome in lista3)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------------------------------");

            lista1.Remove("Arthurr"); // nao vai remover pq arthurr nao tem na lista;

            foreach(string nome in lista1)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------------------------------");

            lista1.RemoveAll(x => x[0] == 'J');
            foreach(string nome in lista1)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------------------------------");

            lista1.RemoveAt(1);
            foreach(string nome in lista1)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------------------------------");

            lista1.Insert(0, "Arthur");
            lista1.Insert(1, "Jacqueline");
            foreach (string nome in lista1)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------------------------------");


            lista1.RemoveRange(0, 2);

            foreach (string nome in lista1)
            {
                Console.WriteLine(nome);
            }




            Console.ReadLine();
        }
    }
}
