using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Revista
    {
        public int id;
        public string tipoColecao;
        public int numeroEdicao;
        public Data anoRevista;
        public Caixa caixaGuardada;

        public void MostrarDadosDaRevista()
        {
            Console.WriteLine();
            Console.WriteLine("ID da Revista: {0}.", id);
            Console.WriteLine("Tipo de Colecao da Revista: {0}.", tipoColecao);
            Console.WriteLine("Numero da Edicao: {0}.", numeroEdicao);
            Console.WriteLine("Ano da Revista: {0}.", anoRevista.anoSeparado);
            Console.WriteLine("Caixa da Revista: {0}.", caixaGuardada.numero);
        }
    }
}
