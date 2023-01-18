using ExercicioAula04.Enums;
using ExercicioAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula04.Entities
{
    public class Departamento { 
        private Guid _id;
        private string? _nome;
        private string? _descricao;
        private TipoDepartamento? _tipoDepartamento;
        private List<Funcionario>? _funcionarios;

        public Guid Id { get => _id; set => _id = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Descricao { get => _descricao; set => _descricao = value; }
        public TipoDepartamento? TipoDepartamento { get => _tipoDepartamento; set => _tipoDepartamento = value; }
        public List<Funcionario>? Funcionarios { get => _funcionarios; set => _funcionarios = value; }
    }
}
