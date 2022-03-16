using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Amigo
    {
        static int id;
        public int idAmigo;
        public string nome;
        public string nomeResponsavel;
        public string telefone;
        public string endereco;

        public Amigo()
        {
            id++;
            idAmigo = id;
        }
    }
}
