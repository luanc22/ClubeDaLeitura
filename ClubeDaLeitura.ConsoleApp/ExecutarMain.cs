using System;

/*
 
  Requisitos
  
[OK]  Para cada Revista, deverá ser cadastrado:  
• o tipo de coleção [OK]
• o número da edição [OK]
• o ano da revista [OK]
• a caixa onde está guardada [OK]
• Cada caixa tem uma cor, uma etiqueta e um número. [OK]

=========================

[WIP] Para cada Empréstimo cadastram-se: 
• o amigo que pegou a revista [WIP]
• qual foi a revista emprestada [WIP]
• a data do empréstimo [WIP]
• a data de devolução [WIP]
• Cada criança só pode pegar uma revista por empréstimo. [OK]

=========================

[OK] O cadastro do Amigo consiste de: 
• nome [OK]
• nome do responsável [OK]
• telefone [OK]
• endereço [OK]

=========================

[WIP] Mensalmente Gustavo verifica os empréstimos realizados no mês e diariamente 

*/

namespace ClubeDaLeitura.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            Revista[] listaDeRevista = new Revista[100];
            Caixa[] listaDeCaixa = new Caixa[100];
            Amigo[] listaDeAmigo = new Amigo[100];
            Notificacao notificacao = new Notificacao();
            Menu menu = new Menu();

            int quantidadeDeCaixas = 0;
            int quantidadeDeRevistas = 0;
            int quantidadeDeAmigos = 0;
            int opcaoEscolhida = 0;

            bool fecharApp = false;
            while (fecharApp == false)
            {
                Console.Clear();
                Cabecalho();
                opcaoEscolhida = menu.ChamarMenu();

                switch (opcaoEscolhida)
                {
                    case 1:
                        #region Menu Caixas. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuCaixas();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarCaixa(listaDeCaixa, ref quantidadeDeCaixas);
                        }
                        else if (opcaoEscolhida == 2)
                        {
                            Console.Clear();
                            Cabecalho();
                            ListarCaixas(listaDeCaixa);
                        }
                        else
                        {
                            notificacao.ApresentarMensagem(ConsoleColor.Red, "Opcao invalida, digite uma opcao valida!");
                        }
                        #endregion
                        break;
                    case 2:
                        #region Menu Revistas. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuRevistas();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarRevista(listaDeRevista, listaDeCaixa, ref quantidadeDeRevistas);
                        }
                        else if (opcaoEscolhida == 2)
                        {
                            Console.Clear();
                            Cabecalho();
                            ListarRevistas(listaDeRevista);
                        }
                        else
                        {
                            notificacao.ApresentarMensagem(ConsoleColor.Red, "Opcao invalida, digite uma opcao valida!");
                        }
                        #endregion
                        break;
                    case 3:
                        #region Menu Amigos. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuAmigos();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarAmigo(listaDeAmigo, listaDeRevista, ref quantidadeDeAmigos);
                        }
                        else if (opcaoEscolhida == 2)
                        {
                            Console.Clear();
                            Cabecalho();
                            ListarAmigos(listaDeAmigo);
                        }
                        else
                        {
                            notificacao.ApresentarMensagem(ConsoleColor.Red, "Opcao invalida, digite uma opcao valida!");
                        }
                        break;
                        #endregion
                }
            }

        }

        #region Metodo Cabecalho. [OK]

        static void Cabecalho()
        {
            Console.WriteLine("======================= Clube da Leitura =======================");
            Console.WriteLine();
            Console.WriteLine("   Programa para gerenciar os emprestimos do clube da leitura.");
            Console.WriteLine();
            Console.WriteLine("================================================================");
        }

        #endregion

        #region Metodos de Cadastro. [OK]

        static void CadastrarRevista(Revista[] listaDeRevista, Caixa[] listaDeCaixa, ref int quantidadeDeRevistas)
        {
            Revista revista1 = new Revista();
            Notificacao notificacao = new Notificacao();
            string numeroEdicaoEmString;
            string anoEmString;
            string caixaEmString;
            int numeroDaCaixa = 0;

            if (listaDeCaixa[0] == null)
            {
                notificacao.ApresentarMensagem(ConsoleColor.Red, "ERRO! Cadastre uma caixa antes de prosseguir com o registro de revistas.");
                return;
            }

            Console.Clear();
            Cabecalho();

            ListarCaixas(listaDeCaixa);

            Console.WriteLine();
            Console.WriteLine("======== Registro da Revista ========");

            #region Coletar dados sobre a revista e armazenar. [OK]

            Console.WriteLine();
            Console.Write("Digite o tipo de colecao da revista: ");
            revista1.tipoColecao = Console.ReadLine();

            bool numeroValido = false;
            while (numeroValido == false)
            {
                Console.WriteLine();
                Console.Write("Digite o numero de edicao da revista: ");
                numeroEdicaoEmString = Console.ReadLine();

                numeroValido = int.TryParse(numeroEdicaoEmString, out revista1.numeroEdicao);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            numeroValido = false;
            while (numeroValido == false)
            {
                Console.WriteLine();
                Console.Write("Digite o ano da revista: ");
                anoEmString = Console.ReadLine();

                numeroValido = int.TryParse(anoEmString, out revista1.anoRevista);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            numeroValido = false;
            while (numeroValido == false)
            {
                Console.WriteLine();
                Console.Write("Digite o numero da caixa: ");
                caixaEmString = Console.ReadLine();

                numeroValido = int.TryParse(caixaEmString, out numeroDaCaixa);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            #endregion

            #region Pegar a posicao da caixa e armazenar revista na caixa. [OK]

            numeroDaCaixa = numeroDaCaixa - 1;

            int contador = 0;

            for (int i = 0; i < listaDeCaixa.Length; i++)
            {
                if (listaDeCaixa[i] == null)
                {
                    contador = i - 1;
                    break;
                }
            }

            for (int i = 0; i <= contador; i++)
            {
                if (listaDeCaixa[i].numero == numeroDaCaixa - 1)
                {
                    revista1.caixaArmazenada = listaDeCaixa[i];
                    int espacoVazioCaixas = listaDeCaixa[i].obterPosicaoVaziaRevista();
                    listaDeCaixa[i].revistas[espacoVazioCaixas] = revista1;
                }
            }

            #endregion

            #region Guardar os dados da revista e incrementar a array. [OK]

            listaDeRevista[quantidadeDeRevistas] = revista1;
            quantidadeDeRevistas++;

            #endregion
        }

        static void CadastrarCaixa(Caixa[] listaDeCaixa, ref int quantidadeDeCaixas)
        {
            Caixa caixa1 = new Caixa();
            Notificacao notificacao = new Notificacao();

            Console.Clear();
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine("======== Registro da Caixa ========");

            #region Coletar dados sobre a caixa e armazenar. [OK]

            Console.WriteLine();
            Console.Write("Digite a cor da caixa: ");
            caixa1.cor = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite a etiqueta da caixa: ");
            caixa1.etiqueta = Console.ReadLine();

            bool numeroValido = false;
            while (numeroValido == false)
            {
                Console.WriteLine();
                Console.Write("Digite o numero da caixa: ");
                string numeroEmString = Console.ReadLine();

                numeroValido = int.TryParse(numeroEmString, out caixa1.numero);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            notificacao.ApresentarMensagem(ConsoleColor.Green, "Caixa cadastrada com sucesso.");

            #endregion

            #region Guardar os dados da caixa e incrementar a array. [OK]

            listaDeCaixa[quantidadeDeCaixas] = caixa1;
            quantidadeDeCaixas++;

            #endregion

        }

        static void CadastrarAmigo(Amigo[] listaDeAmigo, Revista[] listaDeRevista, ref int quantidadeDeAmigos)
        {
            Amigo amigo1 = new Amigo();
            Notificacao notificacao = new Notificacao();

            Console.Clear();
            Cabecalho();

            ListarRevistas(listaDeRevista);

            Console.WriteLine();
            Console.WriteLine("======== Registro de Amigo ========");

            #region Coletar dados sobre o amigo e armazenar. [OK]

            Console.WriteLine();
            Console.Write("Digite o nome do amigo: ");
            amigo1.nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o nome do responsavel do amigo: ");
            amigo1.nomeResponsavel = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o telefone do amigo: ");
            amigo1.telefone = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o endereco do amigo: ");
            amigo1.endereco = Console.ReadLine();

            notificacao.ApresentarMensagem(ConsoleColor.Green, "Amigo cadastrado com sucesso.");

            #endregion

            #region Guardar os dados do amigo e incrementar a array. [OK]

            listaDeAmigo[quantidadeDeAmigos] = amigo1;
            quantidadeDeAmigos++;

            #endregion
        }

        #endregion

        #region Metodos de Listagem. [OK]

        static void ListarCaixas(Caixa[] listaDeCaixa)
        {
            Notificacao notificacao = new Notificacao();
            int contador = 0;

            if (listaDeCaixa[0] == null)
            {
                notificacao.ApresentarMensagem(ConsoleColor.Red, "Nao existem caixas registradas.");
                return;
            }

            #region Realiza a contagem das caixas e mostra. [OK]

            for (int i = 0; i < listaDeCaixa.Length; i++)
            {
                if (listaDeCaixa[i] == null)
                {
                    contador = i - 1;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=============== Caixas ===============");
            Console.WriteLine("");
            Console.WriteLine("{0, -10} | {1, -55} | {2, -35}", "Numero", "Etiqueta", "Cor de Caixa");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i <= contador; i++)
            {
                Console.Write("{0, -10} | {1, -55} | {2, -35}", listaDeCaixa[i].numero, listaDeCaixa[i].etiqueta, listaDeCaixa[i].cor);
                Console.WriteLine();
            }

            notificacao.ApresentarMensagem(ConsoleColor.Yellow, "Lista de Caixas carregada com sucesso.");

            Console.WriteLine();
            Console.WriteLine("======================================");

            #endregion
        }

        static void ListarRevistas(Revista[] listaDeRevista)
        {
            Notificacao notificacao = new Notificacao();
            int contador = 0;

            if (listaDeRevista[0] == null)
            {
                notificacao.ApresentarMensagem(ConsoleColor.Red, "Nao existem revistas registradas.");
                return;
            }

            #region Realiza a contagem das revistas e mostra. [OK]

            for (int i = 0; i < listaDeRevista.Length; i++)
            {
                if (listaDeRevista[i] == null)
                {
                    contador = i - 1;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=============== Revistas ===============");
            Console.WriteLine("");
            Console.WriteLine("{0, -10} | {1, -55} | {2, -35}", "ID", "Tipo da Revista", "N. da Caixa");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i <= contador; i++)
            {
                //Ver isso amanha
                Console.Write("{0, -10} | {1, -55} | {2, -35}", listaDeRevista[i].idRevista, listaDeRevista[i].tipoColecao, listaDeRevista[i].caixaArmazenada.numero);
                Console.WriteLine();
            }

            notificacao.ApresentarMensagem(ConsoleColor.Yellow, "Lista de Revistas carregada com sucesso.");

            Console.WriteLine();
            Console.WriteLine("======================================");

            #endregion
        }

        static void ListarAmigos(Amigo[] listaDeAmigo)
        {
            Notificacao notificacao = new Notificacao();
            int contador = 0;

            if (listaDeAmigo[0] == null)
            {
                notificacao.ApresentarMensagem(ConsoleColor.Red, "Nao existem amigos registrados.");
                return;
            }

            #region Realiza a contagem das revistas e mostra. [OK]

            for (int i = 0; i < listaDeAmigo.Length; i++)
            {
                if (listaDeAmigo[i] == null)
                {
                    contador = i - 1;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=============== Amigos ===============");
            Console.WriteLine("");
            Console.WriteLine("{0, -10} | {1, -55} | {2, -35}", "ID", "Nome do Amigo", "Nome do Responsavel");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i <= contador; i++)
            {
                Console.Write("{0, -10} | {1, -55} | {2, -35}", listaDeAmigo[i].idAmigo, listaDeAmigo[i].nome, listaDeAmigo[i].nomeResponsavel);
                Console.WriteLine();
            }

            notificacao.ApresentarMensagem(ConsoleColor.Yellow, "Lista de Amigos carregada com sucesso.");

            Console.WriteLine();
            Console.WriteLine("======================================");

            #endregion
        }

        #endregion
    }
}
