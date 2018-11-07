using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Persistencia
{
    public class FiapStarterContext : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Patrocinador> Patrocinadores { get; set; }
    }
}