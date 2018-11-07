using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;

namespace Fiap06.Web.MVC.Respositories
{
    public class ConcursoRepository : IConcursoRepository
    {
        private FiapsenaContext _context;

        //ctor -> tab tab (construtor)
        public ConcursoRepository(FiapsenaContext context)
        {
            _context = context;
        }

        public void Atualizar(Concurso concurso)
        {
            _context.Entry(concurso).State = EntityState.Modified;
        }

        public IList<Concurso> BuscarPor(Expression<Func<Concurso, bool>> filtro)
        {
            return _context.Concursos.Where(filtro).ToList();
        }

        public Concurso BuscarPorNumero(int numero)
        {
            return _context.Concursos.Find(numero);
        }

        public void Cadastrar(Concurso concurso)
        {
            _context.Concursos.Add(concurso);
        }

        public void Excluir(int numero)
        {
            var concurso = BuscarPorNumero(numero);
            _context.Concursos.Remove(concurso);
        }

        public IList<Concurso> Listar()
        {
            return _context.Concursos.ToList();
        }
    }
}