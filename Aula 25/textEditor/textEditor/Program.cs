using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textEditor
{
    class Program
    {
        static void ExibirTexto(string arquivo)
        {
            try
            {
                string line = " ";
                StreamReader sr = new StreamReader(arquivo);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Mensagem: " + "Arquivo está em branco ou não existe");
            }
            Console.ReadKey();
        }

        static void GravarTexto(string arquivo)
        {

        }
        static int ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Editor de texto");
            Console.WriteLine("Abrir/criar um arquivo (1)");
            Console.WriteLine("Exibir texto do arquivo (2)");
            Console.WriteLine("Gravar um texto no arquivo (3)");
            Console.WriteLine("Gravar um novo texto no arquivo (4)");
            Console.WriteLine("Sair (5)");

            Console.Write("Opção ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void Main(string[] args)
        {
            int op = 0; //menu
            string arquivo = ""; //arquivo texto
            while (op !=5)
            {
                op = ExibirMenu();
                Console.Clear();
                //Abrir o arquivo
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Informe o nome do arquivo: ");
                        arquivo = Console.ReadLine();
                        break;
                    case 2:
                        ExibirTexto(arquivo);
                        break;
                }
            }

        }
    }
}
