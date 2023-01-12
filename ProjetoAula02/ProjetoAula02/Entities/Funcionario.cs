using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula02.Entities
{
    /// <summary>
    /// Classe de modelo de dados para a entidade Funcionário
    /// </summary>
    public class Funcionario
    {
        private Guid _id;
        private string _nome;
        private string _cpf;
        private string _matricula;
        private DateTime _dataAdmissao;
        private SetorFuncionario _setorFuncionario;
        private FuncaoFuncionario _funcaoFuncionario;

        public Guid Id
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor, informe um ID válido.");
                _id = value;
            }
            get { return _id; } //saida

        }
        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, é necessário infomar um nome válido.");
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{8,100}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe um nome válido.");
                _nome = value;
            } //entrada
            get { return _nome; } //saida

        }
        public string Cpf
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, é necessário infomar um CPF válido.");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe um CPF com 11 dígitos numéricos.");

                _cpf = value;
            }
            get { return _cpf; } //saida

        }
        public string Matricula
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, é necessário infomar uma Matrícula válida.");
                var regex = new Regex("^[A-Z0-9]{6,10}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe uma Matrícula Válida.");

                _matricula = value;
            }
            get { return _matricula; } //saida

        }
        public DateTime DataAdmissao
        {
            set {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("Por favor, informe a data de admissão do funcionário");

                _dataAdmissao = value;
            } 
            get { return _dataAdmissao; } //saida

        }
      
        public SetorFuncionario SetorFuncionario
        {
            set { _setorFuncionario = value; }
            get { return _setorFuncionario; }
        }

        public FuncaoFuncionario FuncaoFuncionario
        {
            set { _funcaoFuncionario = value; }
            get { return _funcaoFuncionario; }
        }

    }
}
