using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamantes.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TelaMontarDiamantes telaMontarDiamantes = new TelaMontarDiamantes();

            string opcao = "";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Academia do Programador - Diamantes 1.1");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite 1 para acessar o menu dos Diamantes");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite S para Sair");
            Console.ResetColor();

            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                while (true)
                {
                    telaMontarDiamantes.ObterOpcao();

                    if (Console.ReadLine().Equals("s", StringComparison.OrdinalIgnoreCase))
                        break;

                    if (opcao == "1")
                        telaMontarDiamantes.MontarDiamantes();

                    if (opcao == "S")
                        telaMontarDiamantes.funcaoSair();
                }
            }
        }
    }
}

