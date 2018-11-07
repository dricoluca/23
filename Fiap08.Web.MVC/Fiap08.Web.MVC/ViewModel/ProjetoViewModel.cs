using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap08.Web.MVC.ViewModel
{
    public class ProjetoViewModel
    {
        public Projeto Projeto { get; set; }

        public SelectList Patrocinadores { get; set; }
    }
}