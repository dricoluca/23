using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap06.Web.MVC.Respositories
{
    public interface IConcursoRepository
    {
        IList<Concurso> Listar();
        void Cadastrar(Concurso concurso);
        void Atualizar(Concurso concurso);
        Concurso BuscarPorNumero(int numero);
        void Excluir(int numero);
        IList<Concurso> BuscarPor(
            Expression<Func<Concurso,bool>> filtro);
    }
}
