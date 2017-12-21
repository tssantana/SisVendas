using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas
{
    public class Pedido
    {
        public int codPedido { get; set; }
        public string nomeCliente { get; set; }
        public string descMercadoria { get; set; }
        public int quantidade { get; set; }
        public double valorTotal { get; set; }
        public double valorUnit { get; set; }

    }
}

