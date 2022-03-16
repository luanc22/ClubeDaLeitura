using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Notificacao
    {

        public void ApresentarMensagem(ConsoleColor cor, string mensagemApresentada)
        {
            Console.WriteLine();
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagemApresentada);
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Aperte ENTER para prosseguir.");
            Console.ReadLine();
        }
    }
}
