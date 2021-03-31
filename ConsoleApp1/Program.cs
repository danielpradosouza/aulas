using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro percy_Jackson = new Livro("Rick Riordan", "Percy Jackson e o mar de monstros", 25.90f);
            Livro auto_da_compadecida = new Livro("Ariano Suassuna", "Auto da Compadecida", 50.99f);
            JogoDigital god_of_war = new JogoDigital("ps2", "god of war2", 5.99f);
            JogoDigital minecraft = new JogoDigital("xbox 360", "minecraft", 80.50f);
            percy_Jackson.informarnome(percy_Jackson.Autor, percy_Jackson.Titulo);
            percy_Jackson.InformarPreco(percy_Jackson.Preco);
            auto_da_compadecida.informarnome(auto_da_compadecida.Autor, auto_da_compadecida.Titulo);
            auto_da_compadecida.InformarPreco(auto_da_compadecida.Preco);
            god_of_war.informarnome(god_of_war.Plataforma, god_of_war.Titulo);
            god_of_war.InformarPreco(god_of_war.Preco);
            minecraft.informarnome(minecraft.Plataforma, minecraft.Titulo);
            minecraft.InformarPreco(minecraft.Preco);
        }
    
    }
}
