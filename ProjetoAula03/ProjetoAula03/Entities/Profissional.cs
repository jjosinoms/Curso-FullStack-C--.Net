using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Entities
{
    /// <summary>
    /// Modelo de dados para entidade Profissional
    /// </summary>
    public class Profissional : Pessoa
    {
        private string? _cpf;
        private string? _matricula;
        private string? _telefone;
        private List<Servico>? _servicos;

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
        public string? Telefone
        {
            get => _telefone;
            set => _telefone = value;
        }
        public List<Servico>? Servicos
        {
            get => _servicos;
            set => _servicos = value;
        }
    }
}
