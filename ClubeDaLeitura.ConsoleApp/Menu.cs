using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Menu
    {
        public string opcoesMenu;

        public int ChamarMenu()
        {
            Notificacao notificacao = new Notificacao();
            int opcaoMenu = 0;

            Console.WriteLine();
            Console.WriteLine("Bem-vindo Gustavo.");
            Console.WriteLine();
            Console.WriteLine("[1] - Caixas.");
            Console.WriteLine("[2] - Revistas.");
            Console.WriteLine("[3] - Amigos.");
            Console.WriteLine();

            bool numeroValido = false;
            while(numeroValido == false)
            {
                Console.Write("Opcao escolhida: ");
                opcoesMenu = Console.ReadLine();
                bool checarNumero = int.TryParse(opcoesMenu, out opcaoMenu);

                if(checarNumero == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Entrada invalida, por favor, digite apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }

            }
            return opcaoMenu;
        }

        public int ChamarMenuCaixas()
        {
            Notificacao notificacao = new Notificacao();
            int opcaoMenu = 0;

            Console.WriteLine();           
            Console.WriteLine("[1] - Cadastro de Caixas.");
            Console.WriteLine("[2] - Listar Caixas.");
            Console.WriteLine();

            bool numeroValido = false;
            while (numeroValido == false)
            {
                Console.Write("Opcao escolhida: ");
                opcoesMenu = Console.ReadLine();
                bool checarNumero = int.TryParse(opcoesMenu, out opcaoMenu);

                if (checarNumero == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Entrada invalida, por favor, digite apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }

            }
            return opcaoMenu;
        }

        public int ChamarMenuRevistas()
        {
            Notificacao notificacao = new Notificacao();
            int opcaoMenu = 0;

            Console.WriteLine();
            Console.WriteLine("[1] - Cadastro de Revistas.");
            Console.WriteLine("[2] - Listar Revistas.");
            Console.WriteLine();

            bool numeroValido = false;
            while (numeroValido == false)
            {
                Console.Write("Opcao escolhida: ");
                opcoesMenu = Console.ReadLine();
                bool checarNumero = int.TryParse(opcoesMenu, out opcaoMenu);

                if (checarNumero == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Entrada invalida, por favor, digite apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }

            }
            return opcaoMenu;
        }

        public int ChamarMenuAmigos()
        {
            Notificacao notificacao = new Notificacao();
            int opcaoMenu = 0;

            Console.WriteLine();
            Console.WriteLine("[1] - Cadastro de Amigos.");
            Console.WriteLine("[2] - Listar Amigos.");
            Console.WriteLine();

            bool numeroValido = false;
            while (numeroValido == false)
            {
                Console.Write("Opcao escolhida: ");
                opcoesMenu = Console.ReadLine();
                bool checarNumero = int.TryParse(opcoesMenu, out opcaoMenu);

                if (checarNumero == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Entrada invalida, por favor, digite apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }

            }
            return opcaoMenu;
        }
    }
}
