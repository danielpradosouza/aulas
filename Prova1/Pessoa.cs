using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
      abstract class Pessoa
    {
        protected Pessoa(long id ,string nome, Endereco endereco, string email)
        {
            this.Id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
        }

        public long Id { get; set; }
        public string nome { get; protected set; }
        public Endereco endereco { get; protected set; }
        public string email { get; protected set; }
    }
}
