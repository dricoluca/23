using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.ViewModel
{
    public class PatrocinadorViewModel
    {
        public Patrocinador Patrocinador { get; set; }
        public IList<Patrocinador> Patrocinadores { get; set; }
    }
}