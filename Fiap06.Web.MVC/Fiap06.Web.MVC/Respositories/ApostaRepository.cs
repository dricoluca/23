using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap06.Web.MVC.Respositories
{
    public class ApostaRepository : IApostaRepository
    {
        private FiapsenaContext _context;

        public ApostaRepository(FiapsenaContext context)
        {
            _context = context;
        }

        public void Atualizar(Aposta aposta)
        {
            _context.Entry(aposta).State = EntityState.Modified;
        }

        public List<Aposta> BuscarPor(Expression<Func<Aposta, bool>> filtro)
        {
            return _context.Apostas.Where(filtro).ToList();
        }

        public Aposta BuscarPorCodigo(int codigo)
        {
            return _context.Apostas.Find(codigo);
        }

        public void Cadastrar(Aposta aposta)
        {
            _context.Apostas.Add(aposta);
        }

        public List<Aposta> Listar()
        {
            return _context.Apostas.Include("Concurso").ToList();
        }

        public void Remover(int codigo)
        {
            var a = BuscarPorCodigo(codigo);
            _context.Apostas.Remove(a);
        }
    }
}