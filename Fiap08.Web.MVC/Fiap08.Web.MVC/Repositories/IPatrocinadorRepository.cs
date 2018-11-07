using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap08.Web.MVC.Repositories
{
    public interface IPatrocinadorRepository
    {
        void Cadastrar(Patrocinador patrocinador);
        void Atualizar(Patrocinador patrocinador);
        void Remover(int codigo);
        IList<Patrocinador> Listar();
        IList<Patrocinador> BuscarPor(Expression<Func<Patrocinador, bool>> filtro);
        Patrocinador Buscar(int codigo);
    }
}
