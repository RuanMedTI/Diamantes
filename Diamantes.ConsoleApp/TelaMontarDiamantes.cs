using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamantes.ConsoleApp
{
    public class TelaMontarDiamantes : Tela
    {
        public override void ObterOpcao()
        {
            Console.WriteLine("'1' para montar um novo diamante");
            Console.WriteLine("'S' para sair");
        }

        public void MontarDiamantes()
        {
            char[] letra = new char[26]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 
                'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S',
                'T', 'U', 'V', 'W', 'X', 
                'Y', 'Z'
            };

            int padraoZero = 0;

            string[] diamante = new string[52];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Diamantes 1.1");
            Console.WriteLine("Digite uma letra (MAIÚSCULA): ");
            Console.ResetColor();

            char inputLetras = Console.ReadKey().KeyChar;

            Console.WriteLine(" ");

            for (int i = 0; i < letra.Length; i++)
            {
                if (letra[i] == inputLetras)
                {
                    padraoZero = i;
                    break;
                }
            }

            for (int i = 0; i <= padraoZero; i++)
            {
                for (int j = 0; j < padraoZero - i; j++)
                {
                    diamante[i] += " ";
                }
                diamante[i] += letra[i];

                if (letra[i] != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        diamante[i] += " ";
                    }
                    diamante[i] += letra[i];
                }
                Console.WriteLine(diamante[i]);
            }

            for (int i = padraoZero - 1; i >= 0; i--)
            {
                Console.WriteLine(diamante[i]);
            }
            Console.ReadKey();
        }

        public void funcaoSair()
        {
            Environment.Exit(1);
        }
    }
}

