using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    /// <summary>
    /// Modelo de entidade para Cliente
    /// </summary>
    public class Cliente
    {
        #region Atributos

        private Guid _id;
        private string? _nome;
        private string? _cpf;
        private DateTime _dataNascimento;

        #endregion

        #region Propriedades

        public Guid Id
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("O Id do cliente é obrigatório.");

                _id = value;
            }
            get => _id;
        }

        public string? Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O Nome do cliente é obrigatório.");

                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,100}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Informe um nome válido de 6 a 100 caracteres.");

                _nome = value;
            }
            get => _nome;
        }

        public string? Cpf
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O CPF do cliente é obrigatório.");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Informe um CPF com exatamente 11 dígitos numéricos.");

                _cpf = value;
            }
            get => _cpf;
        }

        public DateTime DataNascimento
        {
            set
            {

                var dataAtual = DateTime.Now;
                var dataNascimento = value;

                var idade = dataAtual.Year - dataNascimento.Year;
                if (dataNascimento.DayOfYear > dataAtual.DayOfYear)
                    idade--;

                if (idade < 18)
                    throw new ArgumentException("O Cliente deve ser maior de idade (18 anos).");

                _dataNascimento = value;
            }
            get => _dataNascimento;
        }

        #endregion
    }
}

