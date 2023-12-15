using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A < B+C e B < A+C e C < A+B

            int A = 0;
            int B = 0;
            int C = 0;

            Console.WriteLine("Programa que determina se os valores representam os lados de um triângulo");
            Console.WriteLine("Informe o valor do lado A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado C: ");
            C = Convert.ToInt32(Console.ReadLine());

            //Usando a expressão AND (tabela verdade) Se 1 é verdadeiro e 2 é falso tudo é falso
            //Se 1 é verdadeiro e 2 é verdadeiro tudo é verdadeiro
            //Se 1 e 2 forem falsos, ambos são falsos, mas se 1 for verdadeiro e 2 falso, tudo é falso

            //((5 < 10) && (5 < 5 + 5) && (5 < 5 + 5)) -> tudo True
            if ((C < A + B) && (B < A + C) && (C < A + B))
            {
                Console.WriteLine("Os valores representam os lados de um triângulo");
            }
            else
            {
                Console.WriteLine("Os valores não representam os lados de um triângulo");
            }
            Console.ReadKey();

            //if (A < B + C)
            //{
            //    if (B < A + C)
            //    {
            //        if (C < A + B)
            //        {
            //            Console.WriteLine("Os valores representam os lados de um triângulo");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Os valores não representam os lados de um triângulo");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Os valores não representam os lados de um triângulo");
            //    }
            //}   
            //else
            //{
            //    Console.WriteLine("Os valores não representam os lados de um triângulo");
            //}
        }
    }
}
