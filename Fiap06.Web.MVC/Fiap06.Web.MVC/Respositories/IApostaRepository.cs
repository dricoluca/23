using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap06.Web.MVC.Respositories
{
    public interface IApostaRepository
    {
        void Cadastrar(Aposta aposta);
        void Atualizar(Aposta aposta);
        List<Aposta> Listar();
        List<Aposta> BuscarPor(Expression<Func<Aposta, bool>> filtro);
        Aposta BuscarPorCodigo(int codigo);
        void Remover(int codigo);
    }
}
