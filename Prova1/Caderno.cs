using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Caderno : ItemLoja , IItemRelatorio
    {
        public string nome { get; protected set; }
        public int quantidadeDeFolhas { get; protected set; }
        public Caderno(long id, string nome, float precoCompra, float precoVenda, Pessoajuridica pessoajuridica, int quantidaDeFolhas) : base(id, precoCompra, precoVenda, pessoajuridica)
        {
            this.nome = nome;
            this.quantidadeDeFolhas = quantidaDeFolhas;
        }

        public void MostrarDerscricao()
        {
            Console.WriteLine(" O Caderno tem " + quantidadeDeFolhas + " de folhas");
            Console.ReadLine();
        }

        public void MostrarQuantidadeEstoque()
        {
            Console.WriteLine(" Tem 1 cadernp no estoque");
            Console.ReadLine();
        }
    }
}
