using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Endereco
    {
        public Endereco( string rua,long numero, Bairro bairro, Cidade cidade)
        {
            this.rua = rua;
            this.numero = numero;            
            this.bairro = bairro;
            this.cidade = cidade;
        }

        public long numero { get;}
        public string rua { get;  }
        public Bairro bairro { get; }
        public Cidade cidade { get; }
    }
}
