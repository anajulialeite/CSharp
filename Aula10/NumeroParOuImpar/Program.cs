using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int r = 0;

            Console.WriteLine("Verifica se um número é par ou impar");
            Console.Write("Informe um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            r = n % 2;

            //< > <= >= != (diferente) ==
            if (r > 0)
            {
                Console.WriteLine("O número {0} é impar", n);
            }
            else
            {
                Console.WriteLine("O número {0} é par", n);
            }
            //if (r == 0)
            //{
                //Console.WriteLine("O número {0} é par", n);
            //}
            Console.ReadKey();
        }
    }
}
