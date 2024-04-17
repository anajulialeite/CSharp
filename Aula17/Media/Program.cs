using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tl = 0; //quantidade de números 
            double num = 0; //número informado pelo usuário
            double total = 0; //soma dos números 
            double media = 0; //média dos números
            int i = 0; //contador do for

            // O Double consegue representar o número 2x maior que o Float

            Console.WriteLine("Programa que calcula a média dos números: ");
            Console.Write("Quantos números deseja informar: ");
            tl = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= tl; i++)
            {
                Console.Write("informe um número: ");
                num = Convert.ToDouble(Console.ReadLine());
                //total = total + num;
                total += num;
            }
            media = num / tl;
            Console.WriteLine("Total: "+total);
            Console.WriteLine("Média: {0}",media);
            Console.ReadKey();
        }
        
    }
}
