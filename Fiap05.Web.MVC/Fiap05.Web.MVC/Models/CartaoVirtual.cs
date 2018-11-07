using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class CartaoVirtual
    {
        public int CartaoVirtualId { get; set; }
        [Display(Name ="Número")]
        public long Numero { get; set; }
        public bool Utilizado { get; set; }

        //Relacionamentos
        [Display(Name ="Cartão Real")]
        public CartaoReal CartaoReal { get; set; }
        public int CartaoRealId { get; set; }
    }
}