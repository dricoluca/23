using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Models
{
    public class Projeto
    {
        public int ProjetoId { get; set; }
        public string Titulo { get; set; }
        public decimal MetaInvestimento { get; set; }
        public DateTime DataLimite { get; set; }
        public decimal InvestimentoAtual { get; set; }
        public bool DeducaoIR { get; set; }

        public Patrocinador Patrocinador { get; set; }
        public int PatrocinadorId { get; set; }
    }
}