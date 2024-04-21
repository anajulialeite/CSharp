using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int count = 0;
            int i = 0;
            int exit = 1;

            while (exit != 0)
            {
                Console.WriteLine("Número Primo");
                Console.Write("Informe um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                count = 0;
                i = 1;
                while (i <= num)
                {
                    //5%1=0
                    if (num % i == 0)
                    {
                        count++;
                    }
                    i++; //i=i+1
                }
                if (count == 2)
                {
                    Console.WriteLine("O valor informado é um número primo");
                }
                else
                {
                    Console.WriteLine("O valor informado não é um número primo");
                }
                Console.ReadKey();

                //Controle de repetição do programa
                Console.Write("Digite 0 para sair: ");
                exit = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
