using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Cidade
    {
        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            this.estado = estado;
        }

        public string Nome { get; set; }
        public Estado estado { get; set; }
    }
}
