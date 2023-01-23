using ProjetoAula06.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Entities
{
    public class Funcionario
    {
        #region Atributos

        private Guid _id;
        private string? _nome;
        private string? _cpf;
        private DateTime _dataAdmissao;
        private TipoContratacao _tipoContratacao;
        private Endereco? _endereco;

        #endregion

        #region Propriedades
        public Guid Id { get => _id; set => _id = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Cpf { get => _cpf; set => _cpf = value; }
        public DateTime DataAdmissao { get => _dataAdmissao; set => _dataAdmissao = value; }
        public TipoContratacao TipoContratacao { get => _tipoContratacao; set => _tipoContratacao = value; }
        public Endereco? Endereco { get => _endereco; set => _endereco = value; }

        #endregion
    }
}
