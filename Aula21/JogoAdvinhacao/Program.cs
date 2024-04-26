using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdvinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] perguntas = new string[10]
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            string[] perguntas =
               
            {
                "O que tem capa mas não voa.",
                "sem sair do seu cantinho é capaz de viajar ao redor do mundo.",
                "É alta quando está jovem e baixinha quando fica velha. Além disso, é rápida quando é magra e lenta quando é gorda."
            };
            //array de respostas
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            string[] respostas =
            {
                "Livro",
                "Selo",
                "Vela"
            };

            string jogar = "s"; //controla a repetição do programa
            string resposta = ""; //armazena a leitura da resposta do usuário
            int index = 0;

            while (jogar == "s")
            {
                //escolher a pergunta
                Random rand = new Random();
                index = rand.Next(0,perguntas.Length); //dentro da faixa de valores do array 0.. tamanho -1
                Console.WriteLine("Pergunta: {0}", perguntas[index]);
                Console.WriteLine("resposta: ");
                resposta = Console.ReadLine();
                if(resposta.ToUpper() != respostas[index].ToUpper())
                {
                    Console.WriteLine("Que pena, Você errou!!!");
                }else
                {
                    Console.WriteLine("Parabéns!!!! Você acertou!!!!");
                }
                Console.Write("Deseja jogar novamente s/n: ");
                jogar = Console.ReadLine();
            }

        }
    }
}
