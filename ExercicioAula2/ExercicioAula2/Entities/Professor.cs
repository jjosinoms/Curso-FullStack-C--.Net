using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExercicioAula2.Entities
{
    public class Professor
    {
        private Guid _id;
        private string _nome;
        private string _cpf;
        private string _telefone;

        public Guid Id
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor, informe um ID válido.");
                _id = value;
            }
            get { return _id; }

        }
        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, é necessário infomar um nome válido.");
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{8,50}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe um nome válido.");
                _nome = value;
            }
            get { return _nome; }

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
            get { return _cpf; }

        }
        public string Telefone
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, é necessário infomar um Telefone válido.");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe um Telefone com 11 dígitos numéricos.");

                _telefone = value;
            }
            get { return _telefone; }

        }

    }

}
