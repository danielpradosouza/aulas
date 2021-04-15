using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class PessoaFisica: Pessoa , IItemRelatorio
    {


        public PessoaFisica(long id,string nome, Endereco endereco, string email, string cPF, bool vip) : base(id,nome, endereco, email)
        {
            CPF = cPF;
            this.vip = vip;
        }

        public string CPF { get; protected set; }
        public bool vip { get; protected set; }
        public void MostrarDerscricao()
        {
            Console.WriteLine(" O nome da pessoa e " + nome +" e o seu CPF e " + CPF);
            Console.ReadLine();
        }

        public void MostrarQuantidadeEstoque()
        {
            Console.WriteLine(" Essa pessoa não esta a venda nesse momento Volte outra hora ");
            Console.ReadLine();
        }
    }
}
