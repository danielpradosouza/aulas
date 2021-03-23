using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta_Corrente:Conta
    {
        float jurossaque = 0.37f;
        float jurostransferencia = 0.10f;
        float tranferir;
        float sacar;
        float depositar;

        public Conta_Corrente(float tranferir, float sacar, float depositar,int numerodeidentificacao,int numerofinal,string nome,float saldo)
        {
            this.tranferir = tranferir;
            this.sacar = sacar;
            this.depositar = depositar;
            this.numerodeidentificacao = numerodeidentificacao;
            this.numerofinal = numerofinal;
            this.nome = nome;
            this.saldo = saldo ;

        }
    }
}
