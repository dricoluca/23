using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime Data { get; set; }

        //Relacionamentos
        public CartaoVirtual CartaoVirtual { get; set; }
        public int CartaoVirtualId { get; set; }

        public IList<Produto> Produtos { get; set; }
    }
}