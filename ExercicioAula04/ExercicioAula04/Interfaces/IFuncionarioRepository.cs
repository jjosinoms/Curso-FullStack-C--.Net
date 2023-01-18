using ExercicioAula04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula04.Interfaces
{
    public interface IFuncionarioRepository
    {
        void adicionarFuncionario(Funcionario funcionario);
    }
}
