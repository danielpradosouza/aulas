using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca:Conta
    {
        float jurossaque=0.20f;
        float jurostransferencia=0.15f;
        float tranferir;
        float sacar;
        float depositar;

       public ContaPoupanca(float tranferir, float sacar, float depositar, int numerodeidentificacao, int numerofinal, string nome, float saldo)
        {
            this.tranferir = tranferir;
            this.sacar = sacar;
            this.depositar = depositar;
            this.numerodeidentificacao = numerodeidentificacao;
            this.numerofinal = numerofinal;
            this.nome = nome;
            this.saldo = saldo;

        }
        public float Sacar(float sacar,float valorsacado)
        {
            sacar = valorsacado + sacar;
            return sacar;
        }

    }
}
