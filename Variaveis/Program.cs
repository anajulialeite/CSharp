using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //tipo nome valor
            string texto;
            texto = "Variável";
            Console.WriteLine(texto);
            texto = "Ana Júlia de Lima Aguiar Leite";
            Console.WriteLine(texto);
            Console.ReadKey();*/

            int n1 = 2;
            int n2 = 4;

            Console.WriteLine(n1 + " > " + n2 + " = " + (n1 > n2));
            Console.WriteLine(n1 + " < " + n2 + " = " + (n1 < n2));
            Console.WriteLine(n1 + " != " + n2 + " = " + (n1 != n2));
            Console.WriteLine(n1 + " == " + n2 + " = " + (n1 == n2));
            Console.ReadKey();


        }
    }
}
