using Newtonsoft.Json;
using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ProjetoAula04.Repositories
{
    /// <summary>
    /// Repositorio de dados de Funcionario para arquivo JSON
    /// </summary>
    public class FuncionarioRepositoryJSON : IFuncionarioRepository
    {
        /// <summary>
        /// Método para gravar os dados de Funcionário em arquivo JSON
        /// </summary>
        public void exportarFuncionario(Funcionario funcionario)
        {
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);
            using (var streamWriter = new StreamWriter($"f:\\funcionario\\JSON_funcionario_{funcionario.Id}.json"))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}
