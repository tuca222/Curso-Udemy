using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxeForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "Arthur", "Jacqueline", "Mathias" };

            //imprimindo com o for
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            //imprimindo com foreach
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }   

            Console.ReadLine();
        }
    }
}
