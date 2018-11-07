using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    public class Concurso
    {
        [Key]
        public int Numero { get; set; }

        public DateTime Data { get; set; }

        public decimal Premio { get; set; }

        public bool Acumulado { get; set; }

        //Relacionamento
        public IList<Aposta> Apostas { get; set; }
    }
}