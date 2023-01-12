using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExercicioAula2.Entities
{
    public class Turma
    {
        private Guid _id;
        private string _nome;
        private DateTime _dataInicio;
        private Professor _professor;

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

        public DateTime DataInicio
        {
            set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("Por favor, informe a data de admissão do funcionário");

                _dataInicio = value;
            }
            get { return _dataInicio; }
        }

        public Professor Professor
        {
            set { _professor = value; }
            get { return _professor; }
        }
    }
}
