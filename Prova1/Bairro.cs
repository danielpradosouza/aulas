using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Bairro
    {
        public Bairro(string nome)
        {
            this.nome = nome;
        }

        public string nome { get; protected set; }
    }
}
