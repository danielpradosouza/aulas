using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Cadastro
    {


        public PessoaFisica[] clientes { get; set; }
        public Pessoajuridica[] fornecedores { get; set; }

        public string relacionarClientes(string[] clientes)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                return clientes[i];
            }
            return null;
        }
        public string relacionarForbecedores(string[] fornecedores)
        {
            for (int i = 0; i < fornecedores.Length; i++)
            {
                return fornecedores[i];
            }
            return null;
        }
       public void AdicionarClinte( PessoaFisica clinte)
        {
            Console.WriteLine("O cliente "+clinte+" foi colocado na fila");
            Console.ReadLine();
        }
        public void RemoverClinte(PessoaFisica clinte)
        {
            Console.WriteLine("O " + clinte + " cliente foi atendido");
            Console.ReadLine();
        }
        public void AdicionarFornecedor(Pessoajuridica fornecedor)
        {
            Console.WriteLine("Novos itens chegaram pelo fornecedor "+fornecedor);
            Console.ReadLine();
        }
        public void RemoverFornecedor(Pessoajuridica fornecedor)
        {
            Console.WriteLine("O contrato com o fornecedor "+fornecedor+" teminou");
            Console.ReadLine();
        }
    }
}
