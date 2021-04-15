using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Livro : ItemLoja , IItemRelatorio
    {
        public Livro(string titulo, genero genero, string autor, string editora,long iD, float precoCompra, float precoVenda,  Pessoajuridica pessoajuridica) : base(iD,precoCompra, precoVenda, pessoajuridica)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.autor = autor;
            this.editora = editora;
        }

        

        public string titulo { get; protected set; }
        public genero genero { get; protected set; }
        public string autor { get; protected set; }
        public string editora { get; protected set; }

        public void MostrarDerscricao()
        {
            Console.WriteLine(" O livro é do " + autor + " e o nome dele é "+titulo);
            Console.ReadLine();
        }

        public void MostrarQuantidadeEstoque()
        {
            Console.WriteLine(" tem  1 livros no estoque");
            Console.ReadLine();
        }
    }
    enum genero { ficção,informatica,games,negócio };
}
