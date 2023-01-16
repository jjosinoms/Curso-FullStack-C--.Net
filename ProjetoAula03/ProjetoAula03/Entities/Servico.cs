using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Entities
{
    /// <summary>
    /// Modelo de dados para entidade Servico
    /// </summary>
    public class Servico
    {
        private Guid _id;
        private string? _nome;
        private decimal? _valor;
        private List<Profissional>? _profissionais;

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
        public decimal? Valor
        {
            get => _valor;
            set => _valor = value;
        }
        public List<Profissional>? Profissionais
        {
            get => _profissionais;
            set => _profissionais = value;
        }
    }
}
