using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap08.Web.MVC.Repositories;
using Fiap08.Web.MVC.Persistencia;

namespace Fiap08.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private FiapStarterContext _context = new FiapStarterContext();

        private IProjetoRepository _projetoRepository;

        public IProjetoRepository ProjetoRepository
        {
            get
            {
                if (_projetoRepository == null)
                {
                    _projetoRepository = new ProjetoRepository(_context);
                }
                return _projetoRepository;
            }
        }

        private IPatrocinadorRepository _patrocinadorRepository;

        public IPatrocinadorRepository PatrocinadorRepository
        {
            get
            {
                if (_patrocinadorRepository == null)
                {
                    _patrocinadorRepository = new PatrocinadorRepository(_context);
                }
                return _patrocinadorRepository;
            }
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}