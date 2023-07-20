using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0; //área
            double b = 0; //base
            double h = 0; //altura
            string entrada = "";

            Console.WriteLine("Área de um triângulo");
            Console.WriteLine("Informe a base do triângulo: ");
            entrada = Console.ReadLine();
            b = Convert.ToDouble(entrada);
            
            Console.WriteLine("Informe a altura do triângulo: ");
            entrada = Console.ReadLine();
            h = Convert.ToDouble(entrada);

            a = (b * h) / 2;

            Console.WriteLine("Área de um triângulo");
            Console.WriteLine("Base " + b);
            Console.WriteLine("Altura " + h);
            Console.WriteLine("Área " + a);
            Console.ReadKey();
        }
    }
}
