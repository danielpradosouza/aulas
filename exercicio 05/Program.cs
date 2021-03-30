using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aperitivo cem_coxinhas = new Aperitivo(" um cento de  coxinha",25.5f);
            Aperitivo porcaodebisteca = new Aperitivo("uma porção de bisteca com mandioca", 50);
            Bebida coca = new Bebida("coca cola", 5, 7, 10);
            Bebida sucodeuva = new Bebida("Suco de uva", 3, 5, 7);
            Bebida vitaminadeabacate = new Bebida("Vitamina de abacate", 6, 9, 12);
            cem_coxinhas.ImprimirNome(cem_coxinhas.Nome);
            cem_coxinhas.ImprimirPreco(cem_coxinhas.Preco);
            porcaodebisteca.ImprimirNome(porcaodebisteca.Nome);
            porcaodebisteca.ImprimirPreco(porcaodebisteca.Preco);
            coca.ImprimirNome(coca.Nome);
            coca.ImprimirPreco(coca.Pequena,coca.Precopequno);
            coca.ImprimirPreco(coca.Media, coca.Precomedio);
            coca.ImprimirPreco(coca.Grande, coca.Precogrande);
            sucodeuva.ImprimirNome(sucodeuva.Nome);
            sucodeuva.ImprimirPreco(sucodeuva.Pequena, sucodeuva.Precopequno);
            sucodeuva.ImprimirPreco(sucodeuva.Media, sucodeuva.Precomedio);
            sucodeuva.ImprimirPreco(sucodeuva.Grande, sucodeuva.Precogrande);
            vitaminadeabacate.ImprimirNome(vitaminadeabacate.Nome);
            vitaminadeabacate.ImprimirPreco(vitaminadeabacate.Pequena, vitaminadeabacate.Precopequno);
            vitaminadeabacate.ImprimirPreco(vitaminadeabacate.Media, vitaminadeabacate.Precomedio);
            vitaminadeabacate.ImprimirPreco(vitaminadeabacate.Grande, vitaminadeabacate.Precogrande);
            Console.WriteLine("obrigado pela preferencia");
            Console.ReadLine();




        }
    }
}
