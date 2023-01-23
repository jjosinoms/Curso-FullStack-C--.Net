using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Interfaces
{
    /// <summary>
    /// Interface para abstração de métodos de repositório
    /// </summary>
    /// <typeparam name="T">Tipo genérico que representa qualquer entidade</typeparam>

    public interface IRepository<T>
    {
        /// <summary>
        /// Método para realizar um cadastro no banco de dados
        /// </summary>
        public void Inserir(T obj);
    }
}
