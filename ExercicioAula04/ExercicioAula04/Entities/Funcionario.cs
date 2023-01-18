using ExercicioAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula04.Entities
{
    public class Funcionario 
    {
        private Guid _id;
        private string? _nome;
        private double _salario;
        private DateTime _dataAdmissao;
        private Departamento? _departamento;

        public Guid Id { get => _id; set => _id = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public DateTime DataAdmissao { get => _dataAdmissao; set => _dataAdmissao = value; }
        public Departamento? Departamento { get => _departamento; set => _departamento = value; }

    }
}
