using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;

            Console.WriteLine("Tabuada de um número");
            Console.Write("Informe um Número: ");
            //Entrada de dados
            n = Convert.ToInt32(Console.ReadLine());
            //Exiba a tuabuada utilizando o While
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
                i++;
            }
            /*
            //Exibe a tabuada utilizando o for
            //1- Iniciar o contador
            //2- Teste condicional
            //3- Comando altera o contador
            int i = 0;
            for (i = 1; i <= 10; i++)
            {
                 Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
            }
            */

            Console.ReadKey();
        }
    }
}
