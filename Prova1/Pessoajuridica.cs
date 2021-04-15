using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Pessoajuridica:Pessoa,IItemRelatorio
    {
        public Pessoajuridica(long id,string nome, Endereco endereco, string email, string cNPJ) : base(id,nome, endereco, email)
        {
            CNPJ = cNPJ;
        }

        public string CNPJ { get; set; }

        public void MostrarDerscricao()
        {
            Console.WriteLine(" O nome da editora e " + nome + " o seu endereco e " + endereco + " o seu email e " + email + "e o seu CNPJ e " + CNPJ);
            Console.ReadLine();
        }

        public void MostrarQuantidadeEstoque()
        {
            Console.WriteLine(" Essa editora não esta a venda nesse momento ");
            Console.ReadLine();
        }
    }
}
