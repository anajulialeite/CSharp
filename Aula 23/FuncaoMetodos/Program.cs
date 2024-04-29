using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoMetodos
{
    internal class Program
    {
        //modificador de acesso tipo nome parâmetros
        //Tudo que esta entre { } representga o conteúdo de uma função
        //função
        public static void ExibirData()
        {
             string data = DateTime.Now.Date.ToString();
            Console.WriteLine(data);
        }

        //função que executa uma ação e recebe parâmetros
        public static void ExibirMensagem(string texto)
        {
            Console.WriteLine(texto);
        }

        //função que executa uma ação, recebe parâmetros e devolve um valor
        public static int CalcularIdade(int anoNascimento)
        {
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - anoNascimento;
            //a função devolve 1 valor
            return idade;
        }

        //função que executa uma ação, recebe parâmetros e devolve um valor
        public static double Somar(double n1, double n2)
        {
            double total = n1 + n2;
            return total;
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo a trabalhar com funções");
            /*ExibirData();
            string name = "Ana Júlia";
            ExibirMensagem("Ana Júlia");
            int idade = CalcularIdade(1992);
            ExibirMensagem("Sua idade é : " + idade);*/
            double numero = 50;
            double total = Somar(numero, 20);
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
