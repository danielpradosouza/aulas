using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Produto
    {
        private float preco;

        public float Preco { get => preco; protected set => preco = value; }

        public void Descricao()
        {
            Console.WriteLine("Iten da loja");
        }
        public virtual void InformarPreco(float preco)
        {
            Console.WriteLine("deve ser feita na classe especifica");
        }
    }
}
