using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Estado
    {
        public Estado(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }

        public string nome { get; protected set; }
        public string sigla { get; protected set; }
    }
}
