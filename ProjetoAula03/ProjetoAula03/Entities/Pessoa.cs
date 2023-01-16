using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Entities
{
    /// <summary>
    /// Modelo de dados para entidade Pessoa
    /// </summary>
    public class Pessoa
    {
        private Guid _id;
        private string? _nome;

        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string? Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }
    }
}
