using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean empregado = false;
            Boolean fiador = false;
            String entrada = "";

            Console.WriteLine("Empréstimo.....");
            //Entrada de dados
            Console.WriteLine("Possui fiador (s/n): ");
            entrada = Console.ReadLine();

            if (entrada == "s" || entrada == "S")
            {
                fiador = true;
            }

            Console.WriteLine("Está empregado (s/n): ");
            entrada = Console.ReadLine();
            if (entrada == "s" || entrada == "S")
            {
                empregado = true;
            }
            //Processamento
            // || significa OU
            // segue a lógica da tabela verdade do OU
            if (empregado == true || fiador == true)
            {
                Console.WriteLine("Parabéns!!!!! Seu empréstimo foi liberado.");
            }
            else
            {
                Console.WriteLine("Seu empréstimo não foi liberado.");
            }
            Console.ReadKey();
        }
    }
}
