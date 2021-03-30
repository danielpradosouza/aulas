using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_05
{
    class ItemMenu
    {
        private string nome;
        private float preco;

        public string Nome { get => nome; set => nome = value; }
        public float Preco { get => preco; set => preco = value; }

        public virtual void  ImprimirPreco(float preco)
        {
            Console.WriteLine("o preço deve ser consultado na clase propria");
        }
        public virtual void ImprimirNome(string nome)
        {
            Console.WriteLine("o nome deve ser consultado na clase propria");
        }
    }
   
}
