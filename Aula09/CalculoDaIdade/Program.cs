using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AnoAtual = DateTime.Now.Year;
            int DataNascimento = 0;
            int Idade = 0;

            Console.WriteLine("Programa que calcule a idade de uma pessoa");
            Console.Write("Qual é o seu ano de nascimento? ");
            DataNascimento = Convert.ToInt32(Console.ReadLine());

            //Validar a nada de nascimento
            Idade = AnoAtual - DataNascimento;

            Console.WriteLine("Sua idade é {0} anos ", Idade);
            Console.ReadKey();
        }
    }
}
