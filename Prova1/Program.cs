using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PessoaFisica> clentes = new List<PessoaFisica>();
            List<Pessoajuridica> fornecedor = new List<Pessoajuridica>();
            Bairro jardin = new Bairro("Bairro Jardim das Oliveiras");
            Bairro oprearios = new Bairro("Bairro Operarios");
            Bairro monges = new Bairro("Bairro Monges Unidos");
            Bairro copacabana = new Bairro("Copacabana");
            Estado brasilia = new Estado("Brasília", "DF");
            Estado goias = new Estado("Goiás", "GO");
            Estado minas = new Estado("Minas Gerais", "MG");
            Estado rio = new Estado("Rio De Janeiro", "RJ");
            Cidade Brasilia = new Cidade("Brasília", brasilia);
            Cidade verde = new Cidade("Rio Verde", goias);
            Cidade belo = new Cidade("Belo Horizonte", minas);
            Cidade janeiro = new Cidade("Rio de Janeiro", rio);
            Endereco enderecobob = new Endereco("Rua das Classes", 23, jardin, Brasilia);
            Endereco enderecotestolfo = new Endereco("Avenida Abstrata", 4, oprearios, verde);
            Endereco enderecobelo = new Endereco("Vale das Heranças", 26, monges, belo);
            Endereco enderecoassosidos = new Endereco("Edifício Gaveta", 45, copacabana, janeiro);
            PessoaFisica bob = new PessoaFisica(100, "Bob Nelson", enderecobob, "bobNelson@gmail.com", "111.222.333-99", false);
            PessoaFisica testolfo = new PessoaFisica(200, "Testolfo Rocha", enderecotestolfo, "testolfoRocha26@gmail.com", "444.555.666-11", true);
            PessoaFisica Belo = new PessoaFisica(200, "Belo Teste", enderecobelo, "Testebelo@gmail.com", "999.888.777-72", true);
            Pessoajuridica livros = new Pessoajuridica(300, "Livros Associados", enderecoassosidos, "faleconosco@associados.com", "99.8888.7777-77");
            Livro dom = new Livro("Dom Casmurro", genero.ficção, "Machado de assis", "universal", 100, 19.99f, 31.99f, livros);
            Livro unity = new Livro("Unity: design e desenvolvimento de jogos", genero.games, "William Pereira Alves", "universal", 150, 24.35f, 58.99f, livros);
            Caderno caderno100 = new Caderno(170, "Caderno Capa Dura - Jaspion", 10.99f, 25.99f, livros, 100);
            clentes.Add(bob);
            clentes.Add(testolfo);
            clentes.Add(Belo);
            Cadastro clientes = new Cadastro();
            clientes.clientes = clentes.ToArray();
            clientes.AdicionarClinte(bob);
            clientes.AdicionarClinte(testolfo);
            clientes.AdicionarClinte(Belo);
            fornecedor.Add(livros);
            Cadastro Fornecedor = new Cadastro();
            Fornecedor.fornecedores = fornecedor.ToArray();
            Fornecedor.AdicionarFornecedor(livros);


           
            
            
        }
    }
}
