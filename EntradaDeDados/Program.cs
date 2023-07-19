using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.WriteLine("Programa que efetua leitura de dados do usuário:");
            Console.WriteLine("Olá, qual é o seu nome?");
            Console.Write("Digite seu nome: ");
            Console.ReadLine();
            nome = Console.ReadLine();
            //Console.WriteLine(nome+", Bem vinda as aulas de programação");
            Console.WriteLine("{0} bem vindo as aulas de programação", nome);
            Console.ReadKey();

        }
    }
}
