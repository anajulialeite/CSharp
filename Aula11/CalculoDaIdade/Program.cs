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

            //Comando if é um comando de condicional (se)
            //Se a expressão for verdadeira ele vai entrar no escopo do if e executar de forma válida
            //Se a expressão for falsa ele não vai entrar no escopo do if e vai para o escopo do else e executar de forma verdadeira
            //Então temos duas opções usar o duplo if ou if + else
            if (DataNascimento <= AnoAtual)
            {
                Idade = AnoAtual - DataNascimento;
                Console.WriteLine("Sua idade é {0} ano(s) ", Idade);
            }
            else
            {
                Console.WriteLine("Erro!!!! Informe um ano de nascimento válido");
            }
            //if (DataNascimento > AnoAtual)
            //{
                //Console.WriteLine("Erro!!!! Informe um ano de nascimento válido");
            //}
            Console.ReadKey();
        }
    }
}
