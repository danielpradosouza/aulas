using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_05
{
    class Bebida:ItemMenu
    {
        float precopequno, precomedio, precogrande;
        string pequena = "pequena", media = "media", grande = "grande";


        public string Pequena { get => pequena; }
        public string Media { get => media; }
        public string Grande { get => grande; }
        public float Precopequno { get => precopequno; set => precopequno = value; }
        public float Precomedio { get => precomedio; set => precomedio = value; }
        public float Precogrande { get => precogrande; set => precogrande = value; }

        public Bebida(string nome ,float precopequno, float precomedio, float precogrande)
        {
            this.Nome = nome;
            this.Precopequno = precopequno;
            this.Precomedio = precomedio;
            this.Precogrande = precogrande;
        }
        public  void ImprimirPreco(string tipodebebida, float preco)
        {
            Console.WriteLine("o preço da bebida " + tipodebebida + " e " + preco) ;
            Console.ReadLine();
        }
        public override void ImprimirNome(string nome)
        {
            Console.WriteLine("o nome da bebida e " + nome);
            Console.ReadLine();
        }
    }
}
