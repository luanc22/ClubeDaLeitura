using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Caixa
    {
        public string cor;
        public string etiqueta;
        public int numero;
        public Revista[] revistas = new Revista[10];

        public int obterPosicaoVaziaRevista()
        {
            int posicaoLivre = 0;

            for(int i = 0; i < revistas.Length; i++)
            {
                if(revistas[i] == null)
                {
                    posicaoLivre = i;
                    break;
                }
            }

            return posicaoLivre;
        }
    }

}
