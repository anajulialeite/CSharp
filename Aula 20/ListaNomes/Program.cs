using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir[] nome = new tipo [10] o tamanho entre colchetes 
            //string[] nomes = { "Ana Júlia", "Danilo", "César", "Cássia", "Maria Clara" };
            string[] lista = new string[5];
            //string nome = "";

            lista[0] = "Ana Júlia";
            lista[1] = "Danilo";
            lista[2] = "César";
            lista[3] = "Cássia";
            lista[4] = "Maria Clara";
            //lista[9]

            Console.WriteLine("lista de 5 nomes");
            for (int i = 0; i < 5 ; i++)
            {
                Console.Write("Informe um nome: ");
                //nome = Console.ReadLine();
                lista[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.Write("Nome: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(lista[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
