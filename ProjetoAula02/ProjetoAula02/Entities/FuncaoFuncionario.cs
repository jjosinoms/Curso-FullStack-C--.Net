using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula02.Entities
{
    /// <summary>
    /// Classe de modelo de dados para a entidade Função Funcionário
    /// </summary>
    public class FuncaoFuncionario
    {
        private Guid _id;
        private string _descricao;
        private List<Funcionario> _funcionario;

        public Guid Id
        {
            set {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor, insira o id da função.");
                
                _id = value;
            
            } //entrada
            get { return _id; } //saida

        }
        public string Descricao
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, informa a descrição da função");
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,100}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe uma descrição válida");
                _descricao = value;
            } //entrada
            get { return _descricao; } //saida

        }
        public List<Funcionario> Funcionario
        {
            set { _funcionario = value; } //entrada
            get { return _funcionario; } //saida
        }
    }
}
