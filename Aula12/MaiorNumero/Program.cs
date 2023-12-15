using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para reduzir as variáveis é só tirar n1, n2 e n3
            //Trocar n1 para n e manter o MaiorNumero
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int MaiorNumero = 0;

            //Trocar tudo para n
            Console.WriteLine("Programa que determina o maior número informado");
            Console.Write("Informe o 1° Número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            //Maior número
            MaiorNumero = n1;

            Console.Write("Informe o 2° Número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 > MaiorNumero)
            {
                MaiorNumero = n2;
            }
            Console.Write("Informe o 3° Número: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n3 > MaiorNumero)
            {
                MaiorNumero = n3;
            }
            Console.WriteLine("O maior número é {0}", MaiorNumero);
            Console.ReadKey();
        }
    }
}
