using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
      abstract class ItemLoja
    {
        public ItemLoja(long iD ,float precoCompra, float precoVenda,  Pessoajuridica pessoajuridica)
        {
            this.ID = iD;
            this.precoCompra = precoCompra;
            this.precoVenda = precoVenda;
            this.pessoajuridica = pessoajuridica;
        }

       
        public long ID { get; set; }
        public float precoCompra { get; protected set; }
        public float precoVenda { get; protected set; }
      
        public Pessoajuridica pessoajuridica { get; protected set; }
    }
}
