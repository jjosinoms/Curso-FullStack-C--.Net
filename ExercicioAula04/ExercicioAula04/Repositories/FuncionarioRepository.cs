using ExercicioAula04.Entities;
using ExercicioAula04.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula04.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        public void adicionarFuncionario(Funcionario funcionario)
        {
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);
            using (var streamWriter = new StreamWriter($"f:\\funcionario\\JSON_funcionario_{funcionario.Id}.json"))
            {
                streamWriter.WriteLine(json);
            }

        }
    }
}
