using ExercicioAula04.Entities;
using ExercicioAula04.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ExercicioAula04.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        public void adicionarDepartamento(Departamento departamento)
        {
            var json = JsonConvert.SerializeObject(departamento, Formatting.Indented);
            using (var streamWriter = new StreamWriter($"f:\\departamento\\JSON_departamento_{departamento.Id}.json"))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}
