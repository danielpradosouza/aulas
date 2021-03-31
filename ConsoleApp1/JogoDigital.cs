using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class JogoDigital : Produto
    {
        string plataforma;
        string titulo;

        public JogoDigital(string plataforma, string titulo,float preco)
        {
            this.Plataforma = plataforma;
            this.Titulo = titulo;
            this.Preco = preco;
        }

        public string Plataforma { get => plataforma; protected set => plataforma = value; }
        public string Titulo { get => titulo; protected set => titulo = value; }

        public void informarnome(string plataforma,string titulo)
        {
            Console.WriteLine("o jogo e do " + plataforma + " e seu nome e " + titulo);
            Console.ReadLine();
        }
        public override void InformarPreco(float preco)
        {
            Console.WriteLine("o preco do jogo e " + preco + " Reais");
            Console.ReadLine();
        }
    }
}
