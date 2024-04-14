using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Eleitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                Criar um programa que determine se uma pessoa é um eleitor válido
                16 e 18 anos - voto facultativo
                18 e 65 anos - voto obrigatório
                idade > 65 anos - voto facultativo
            */

            string nome = "";
            int idade = 0;

            Console.WriteLine("Programa que determina a classe do eleitor");
            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 16)
            {
                Console.WriteLine("{0}, você não possui idade para votar.", nome);
            }
            else
            {
                if ((idade > 15 && idade < 18 || idade > 65))
                {
                    Console.WriteLine("{0}, você é um eleitor facultativo.", nome);
                }
                else
                {
                    Console.WriteLine("{0}, seu voto é obrigatório.", nome);
                }
            }
            Console.ReadKey();
        }
    }
}
