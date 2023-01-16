using ProjetoAula04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Interfaces
{
    /// <summary>
    /// Interface para repositório de Funcionário
    /// </summary>
    public interface IFuncionarioRepository
    {
        /// <summary>
        /// Método abstrato para exportação de dados de funcionário
        /// </summary>
        /// <param name="funcionario">Objeto da classe funcionário</param>
        void exportarFuncionario(Funcionario funcionario);

    }
}
