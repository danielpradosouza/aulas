using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc2
{
    class Program
    {
        static void Main(string[] args)
        {
            double categoria_bob, categoria_testolfo, categoria_lisa;
            Pessoa bob = new Pessoa();
            bob.Altura = 1.70;
            bob.Idade = 37;
            bob.Nome = "Bob Nelson";
            bob.Peso = 78;
            bob.Alturaao2 = bob.Altura*bob.Altura;
            
            Pessoa Testosfo = new Pessoa();
            Testosfo.Altura = 1.65;
            Testosfo.Idade = 43;
            Testosfo.Nome = "Testolfo Rocha";
            Testosfo.Peso = 60;
            Testosfo.Alturaao2 =Testosfo.Altura*Testosfo.Altura;
           
            Pessoa lisa = new Pessoa();
            lisa.Altura = 1.72;
            lisa.Idade = 22;
            lisa.Nome = "Lisa Leite";
            lisa.Peso = 92;
            lisa.Alturaao2 =lisa.Altura*lisa.Altura;
             
            bob.Imc1 = bob.Peso/ bob.Alturaao2;
            Testosfo.Imc1 = Testosfo.Peso/ Testosfo.Alturaao2;
            lisa.Imc1 =lisa.Peso/ lisa.Alturaao2; 

            categoria_testolfo = Testosfo.Imc1;
            categoria_bob = bob.Imc1;
            categoria_lisa = lisa.Imc1;

            Console.WriteLine("o nome da pessoa que vamos calcular o imc e " + Testosfo.Nome + "a sua idade e " + Testosfo.Idade+ "a sua altura e "+ Testosfo.Altura+"e seu peso e "+Testosfo.Peso);
            Console.ReadLine();
            Console.WriteLine("o imc do Testolfo e " + Testosfo.Imc1);
            Console.ReadLine();
            Console.WriteLine("o nome da pessoa que vamos calcular o imc e " + bob.Nome + "a sua idade e " + bob.Idade + "a sua altura e " + bob.Altura + "e seu peso e " + bob.Peso);
            Console.ReadLine();
            Console.WriteLine("o imc do Bob e " + bob.Imc1);
            Console.ReadLine();
            Console.WriteLine("o nome da pessoa que vamos calcular o imc e " + lisa.Nome + "a sua idade e " + lisa.Idade + "a sua altura e " + lisa.Altura + "e seu peso e " + lisa.Peso);
            Console.ReadLine();
            Console.WriteLine("o imc da Lisa e " + lisa.Imc1);
            Console.ReadLine();

            if(categoria_bob>=18.5 && categoria_bob <= 24.9)
            {
                Console.WriteLine("Parabéns — Bob está em seu peso normal!");
                Console.ReadLine();
            }
            if (categoria_bob >= 25.0 && categoria_bob <= 29.9)
            {
                Console.WriteLine("Bob Você está acima de seu peso (sobrepeso)");
                Console.ReadLine();
            }
            if (categoria_bob >= 30.0 && categoria_bob <= 34.9)
            {
                Console.WriteLine("Bob Você está com Obesidade grau I.");
                Console.ReadLine();
            }
            if (categoria_bob >= 35.0 && categoria_bob < 40)
            {
                Console.WriteLine("Bob Você está com Obesidade grau II.");
                Console.ReadLine();
            }
           if (categoria_bob>=40)
            {
                Console.WriteLine("Bob Você está com Obesidade graus III .");
                Console.ReadLine();
            }
            if (categoria_testolfo >= 18.5 && categoria_testolfo <= 24.9)
            {
                Console.WriteLine("Parabéns — Testolfo está em seu peso normal!");
                Console.ReadLine();
            }
            if (categoria_testolfo >= 25.0 && categoria_testolfo <= 29.9)
            {
                Console.WriteLine("Testolfo Você está acima de seu peso (sobrepeso)");
                Console.ReadLine();
            }
            if (categoria_testolfo >= 30.0 && categoria_testolfo <= 34.9)
            {
                Console.WriteLine("Testolfo Você está com Obesidade grau I.");
                Console.ReadLine();
            }
            if (categoria_testolfo >= 35.0 && categoria_testolfo < 40)
            {
                Console.WriteLine("Testolfo Você está com Obesidade grau II.");
                Console.ReadLine();
            }
            if (categoria_testolfo>=40)
            {
                Console.WriteLine("Testolfo Você está com Obesidade graus III .");
                Console.ReadLine();
            }
            if (categoria_lisa >= 18.5 && categoria_lisa <= 24.9)
            {
                Console.WriteLine("Parabéns — LIsa você está em seu peso normal!");
                Console.ReadLine();
            }
            if (categoria_lisa >= 25.0 && categoria_lisa <= 29.9)
            {
                Console.WriteLine("Lisa Você está acima de seu peso (sobrepeso)");
                Console.ReadLine();
            }
            if (categoria_lisa >= 30.0 && categoria_lisa <= 34.9)
            {
                Console.WriteLine("Lisa Você está com Obesidade grau I.");
                Console.ReadLine();
            }
            if (categoria_lisa >= 35.0 && categoria_lisa < 40)
            {
                Console.WriteLine("Lisa Você está com Obesidade grau II.");
                Console.ReadLine();
            }
            if (categoria_lisa >= 40)
            {
                Console.WriteLine("Lisa Você está com Obesidade graus III e IV.");
                Console.ReadLine();
            }

          
            Console.WriteLine("Bob voce precisa perder 5,76 kg");
            Console.ReadLine();
            Console.WriteLine("Testolfo voce não precisa perder peso");
            Console.ReadLine();
            Console.WriteLine("lisa voce precisa perder 18,05 kg");
            Console.ReadLine();


        }
    }
}
