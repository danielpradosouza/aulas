using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Livro : Produto
    {
        string autor;
        string titulo;

        public Livro(string autor, string titulo,float preco)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.Preco = preco;
        }

        public string Autor { get => autor; private set => autor = value; }
        public string Titulo { get => titulo; private set => titulo = value; }

        public void informarnome(string autor, string titulo)
        {
            Console.WriteLine("o livro e do " + autor + " e seu nome e " + titulo);
            Console.ReadLine();
        }
        public override void InformarPreco(float preco)
        {
            Console.WriteLine("o preco do livro e " + preco + " reais");
            Console.ReadLine();
        }
    }
}
