using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoAula04.Repositories
{
    /// <summary>
    /// Repositorio de dados de Funcionario para arquivo XML
    /// </summary>
    public class FuncionarioRepositoryXML : IFuncionarioRepository
    {
        public void exportarFuncionario(Funcionario funcionario)
        {
            var xml = new XmlSerializer(typeof(Funcionario));
            using (var streamWriter = new StreamWriter($"f:\\funcionario\\XML_funcionario_{funcionario.Id}.xml"))
            {
                xml.Serialize(streamWriter, funcionario);
            }
        }

    }
}
