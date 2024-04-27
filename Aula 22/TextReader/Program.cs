using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arquivo que eu quero abrir
            string arquivo = args[0];
            string line = "";

            try
            {
                StreamReader sr = new StreamReader(arquivo);
                //quero acessar algo que está no mesmo arquivo sr.
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                //Quando eu coloco um . na frente da variável eu posso ver os comandos e os valores que ela possui
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e) 
            { 
                Console.WriteLine("Error: " + e.Message);
            }
            //Para rodar esse programa vá em compulação e depois compilar solução
        }
    }
}
