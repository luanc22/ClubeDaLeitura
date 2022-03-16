using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Revista
    {
        static int id;
        public int idRevista;
        public string tipoColecao;
        public int numeroEdicao;
        public int anoRevista;
        public Caixa caixaArmazenada;

        public Revista()
        {
            id++;
            idRevista = id;
        }

        public void MostrarDadosDaRevista()
        {
            Console.WriteLine();
            Console.WriteLine("ID da Revista: {0}.", idRevista);
            Console.WriteLine("Tipo de Colecao da Revista: {0}.", tipoColecao);
            Console.WriteLine("Numero da Edicao: {0}.", numeroEdicao);
            Console.WriteLine("Ano da Revista: {0}.", anoRevista);
        }
    }
}
