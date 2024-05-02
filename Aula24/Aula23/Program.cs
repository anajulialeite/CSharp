using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula23
{
    internal class Program
    {
        static int ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Sistema Matemático");
            Console.WriteLine("Calcular o fatorial (1)");
            Console.WriteLine("Verificar se o número é primo (2)");
            Console.WriteLine("Efetuar a divisão de um número inteiro (3)");
            Console.WriteLine("Sair (4)");
            Console.WriteLine("Opção: ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static int Fatorial(int numero)
        {
            //4 * 3 * 2 * 1 = fatorial
            for (int i = numero - 1; i > 1; i--)
            {
                numero = numero * i;
            }
            return numero;
        }

        //Função do número primo
        static Boolean NumeroPrimo(int numero)
        {
            //4/4 = 1 4/2 = 2 4/1 = 4
            Boolean primo = false;
            int count = 0;
            for (int i = numero; i > 0; i--)
            {
                  if (numero % i == 0) count++;
            }
            if (count == 2) primo = true;
            return primo;
        }

        //Função da divisão
        static void Dividir(int dividendo, int divisor, out int resto, out int quociente)
        {
            resto = dividendo % divisor;
            quociente = dividendo / divisor;
        }

        static void Main(string[] args)
        {
            int op = 0;
            int n1 = 0;
            int n2 = 0;
            int fatorial = 0;
            int resto = 0;
            int quociente = 0;

            while (op != 4)
            {
                op = ExibirMenu();
                Console.Clear();

                //Programa
                switch (op)
                {
                    //Calcular fatorial
                    case 1:
                        Console.WriteLine("Informe um número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        fatorial = Fatorial(n1);
                        Console.WriteLine("O fatorial de {0} é {1}", n1, fatorial);
                        break;

                    //Número primo
                    case 2:
                        Console.WriteLine("Informe um número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        //Como eu não criei uma variável eu posso pegar o valor direto da função
                        if (NumeroPrimo(n1))
                        {
                            Console.WriteLine("O número {0} é um número primo", n1);
                        }
                        else
                        {
                            Console.WriteLine("O número {0} não é um número primo", n1);
                        }
                        break;

                    //Divisão
                    case 3:
                        Console.WriteLine("Informe o dividendo: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o divisor: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        Dividir(n1, n2, out resto, out quociente);
                        Console.WriteLine("{0} / {1} = {2} e sobra {3}", n1, n2, quociente, resto);
                        break;

                    }
                    Console.ReadLine();
            }
        }
    }
}