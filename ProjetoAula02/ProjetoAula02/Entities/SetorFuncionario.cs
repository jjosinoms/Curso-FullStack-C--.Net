using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula02.Entities
{
    /// <summary>
    /// Classe de modelo de dados para a entidade Setor Funcionário
    /// </summary>
    public class SetorFuncionario
    {
        private Guid _id;
        private string _nome;
        private List<Funcionario> _funcionario;
        

        public Guid Id
        {
            set { _id = value; } //entrada
            get { return _id; } //saida

        }
        public string Nome
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, é necessário infomar um nome válido.");
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{8,100}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, insira o Setor corretamente!");
                _nome = value;
            } //entrada
            get { return _nome; } //saida

        }

        public List<Funcionario> Funcionario
        {
            set { _funcionario = value; } //entrada
            get { return _funcionario; } //saida
        }

    }
}
