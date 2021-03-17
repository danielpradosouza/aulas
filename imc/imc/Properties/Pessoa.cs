using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc.Properties
{
    class Pessoa
    {
        int idade;
        float peso;
        string nome;
        double altura;

        public Pessoa(int idade, float peso, string nome, double altura)
        {
            this.idade = idade;
            this.peso = peso;
            this.nome = nome;
            this.altura = altura;
        }
    }
}
