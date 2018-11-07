using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    public class Aposta
    {
        public int ApostaId { get; set; }

        public DateTime Data { get; set; }

        private IList<int> _sequencia;

        private string _sequenciaString;

        public IList<int> Sequencia
        {
            get { return _sequencia; }
            set
            {
                _sequencia = value;
                //Gera uma string com os números do array separados por virgula
                _sequenciaString = string.Join(",", Sequencia.ToArray());
            }
        }

        public string SequenciaString
        {
            set
            {
                _sequenciaString = value;
                //Transforma uma string em uma lista de inteiros
                _sequencia = _sequenciaString.Split(',').Select(Int32.Parse).ToList();
            }
            get { return _sequenciaString; }
        }

        //Relacionamentos
        public Concurso Concurso { get; set; }

        public int Numero { get; set; }
    }
}