using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Models
{
    public class Patrocinador
    {
        public int PatrocinadorId { get; set; }
        public string Nome { get; set; }

        public IList<Projeto> Projetos { get; set; }
    }
}