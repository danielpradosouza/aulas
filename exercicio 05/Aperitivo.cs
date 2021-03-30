using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_05
{
    class Aperitivo:ItemMenu
    {
        public Aperitivo(string nome,float preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
        public override void ImprimirPreco(float preco)
        {
            Console.WriteLine("o preço do apretivo e "+ preco);
            Console.ReadLine();
        }
        public override void ImprimirNome(string nome)
        {
            Console.WriteLine("o nome do aperitivo e " +  nome);
            Console.ReadLine();
        }
    }
}
