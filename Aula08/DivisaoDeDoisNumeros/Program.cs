using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisaoDeDoisNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0; //Número que será dividido
            double n2 = 0; //Divisor
            double r = 0; //Resto da divisão
            double q = 0; //Quociente da divisão

            Console.WriteLine("Programa que efetua a divisão de dois números");
            Console.Write("Informe o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            q = n1 / n2;
            r = n1 % n2;

            Console.WriteLine("Resposta da divisão: ");
            Console.WriteLine("{0}/{1}={2}", n1, n2, q);
            Console.WriteLine("Resto: {0}", r);
            Console.ReadKey();
        }
    }
}
