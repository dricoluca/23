using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Persistencia;

namespace Fiap08.Web.MVC.Repositories
{
    public class PatrocinadorRepository : IPatrocinadorRepository
    {
        private FiapStarterContext _context;

        public PatrocinadorRepository(FiapStarterContext context)
        {
            _context = context;
        }

        public void Atualizar(Patrocinador patrocinador)
        {
            _context.Entry(patrocinador).State = System.Data.Entity.EntityState.Modified;
        }

        public Patrocinador Buscar(int codigo)
        {
            return _context.Patrocinadores.Find(codigo);
        }

        public IList<Patrocinador> BuscarPor(Expression<Func<Patrocinador, bool>> filtro)
        {
            return _context.Patrocinadores.Where(filtro).ToList();
        }

        public void Cadastrar(Patrocinador patrocinador)
        {
            _context.Patrocinadores.Add(patrocinador);
        }

        public IList<Patrocinador> Listar()
        {
            return _context.Patrocinadores.ToList();
        }

        public void Remover(int codigo)
        {
            _context.Patrocinadores.Remove(Buscar(codigo));
        }
    }
}