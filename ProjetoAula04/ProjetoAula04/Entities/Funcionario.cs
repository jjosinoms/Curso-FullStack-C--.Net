using ProjetoAula04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Entities
{
    /// <summary>
    /// Modelo de dados para a entidade Funcionario
    /// </summary>
    public class Funcionario 
    {
        private Guid _id;
        private string? _nome;
        private string? _cpf;
        private string? _matricula;
        private DateTime? _dataAdmissao;
        private TipoContratacao? _tipoContratacao;

        public Guid Id
        {
            get => _id;
            set => _id = value;
        }
        public string? Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public string? Cpf
        {
            get => _cpf;
            set => _cpf = value;
        }
        public string? Matricula
        {
            get => _matricula;
            set => _matricula = value;
        }
        public DateTime? DataAdmissao
        {
            get => _dataAdmissao;
            set => _dataAdmissao = value;
        }
        public TipoContratacao? TipoContratacao
        {
            get => _tipoContratacao;
            set => _tipoContratacao = value;
        }
    }
}
