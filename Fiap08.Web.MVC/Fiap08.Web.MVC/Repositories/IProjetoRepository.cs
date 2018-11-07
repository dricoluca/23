using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap08.Web.MVC.Repositories
{
    public interface IProjetoRepository
    {
        void Cadastrar(Projeto projeto);
        void Editar(Projeto projeto);
        void Excluir(int codigo);
        IList<Projeto> Listar();
        IList<Projeto> BuscarPor(Expression<Func<Projeto, bool>> filtro);
        Projeto Buscar(int codigo);
    }
}