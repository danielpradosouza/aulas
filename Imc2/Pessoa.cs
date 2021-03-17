using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc2
{
    class Pessoa
    {
        int idade;
        double peso, altura, Imc;
        double alturaao2;
        string nome;


        public int Idade { get => idade; set => idade = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Imc1 { get => Imc; set => Imc = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Alturaao2 { get => alturaao2; set => alturaao2 = value; }
    }
    }

