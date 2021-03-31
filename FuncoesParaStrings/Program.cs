using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesParaStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper(); //Trabsforma tudo em maiusculo;
            string s2 = original.ToLower(); //Transforma tudo em minúsculo;
            string s3 = original.Trim(); //Apaga os espaços em branco;

            int n1 = original.IndexOf("bc"); //indice da primeira aparição
            int n2 = original.LastIndexOf("bc"); //indice da ultima aparição

            string s4 = original.Substring(3); //Recorta a string a partir do indice 3
            string s5 = original.Substring(3, 5); //Recorta a string a partir do indice 3 até 5 caracteres(3, 5)
            string s6 = original.Replace('a', 'x'); //subistitui todo caracter a por x ('a', 'x');
            string s7 = original.Replace("abc", "xy"); //subistitui toda string abc por xy ("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original); //Verifica se a string é null ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original); // Verifica se a string é null ou espaço em branco;





            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Maiusculo: -"+ s1 + "-");
            Console.WriteLine("Minusculo: -" + s2 + "-");
            Console.WriteLine("Sem espaços em branco: -" + s3 + "-");
            Console.WriteLine("IndexOF('bc'): " + n1);
            Console.WriteLine("LastIndexOF('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4 + "-");
            Console.WriteLine("Substring(3, 5): " + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty(original): " + b1);
            Console.WriteLine("IsNullOrWhiteSpace(original): " + b2);








            Console.ReadLine();
        }
    }
}
