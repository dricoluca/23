using Fiap06.Web.MVC.Persistencia;
using Fiap06.Web.MVC.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private FiapsenaContext _context = new FiapsenaContext();

        private IConcursoRepository _concursoRepository;

        private IApostaRepository _apostaRepository;

        public IApostaRepository ApostaRepository
        {
            get
            {
                if(_apostaRepository == null)
                {
                    _apostaRepository = new ApostaRepository(_context);
                }
                return _apostaRepository;
            }
        }

        public IConcursoRepository ConcursoRepository
        {
            get
            {
                if (_concursoRepository == null)
                {
                    _concursoRepository = new ConcursoRepository(_context);
                }
                return _concursoRepository;
            }
        }

        //Liberar os recursos
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

    }
}