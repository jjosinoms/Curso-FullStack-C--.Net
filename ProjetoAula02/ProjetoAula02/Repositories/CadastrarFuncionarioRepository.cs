using Newtonsoft.Json;
using ProjetoAula02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoAula02.Repositories
{
    public class CadastrarFuncionarioRepository
    {
        public void registrarFuncionario(Funcionario funcionario)
        {
            //abrindo um arquivo novo para escrita
            using (var streamWriter = new StreamWriter($"f:\\funcionario\\funcionario_{funcionario.Id}.txt"))
            {
                //escrever o conteudo do arquivo...
                streamWriter.WriteLine("DADOS DO CLIENTE:");
                streamWriter.WriteLine($"ID........: {funcionario.Id}");
                streamWriter.WriteLine($"NOME......: {funcionario.Nome}");
                streamWriter.WriteLine($"CPF.......: {funcionario.Cpf}");
                streamWriter.WriteLine($"MATRICULA..: {funcionario.Matricula}");
                streamWriter.WriteLine($"DataAdmissao.....: {funcionario.DataAdmissao}");
                streamWriter.WriteLine($"SETOR.....: {funcionario.SetorFuncionario.Nome}");
                streamWriter.WriteLine($"FUNÇÃO.....: {funcionario.FuncaoFuncionario.Descricao}");

            }
        }
        public void ExportarJson(Funcionario funcionario)
        {
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);
            using (var streamWriter = new StreamWriter($"f:\\funcionario\\JSON\\JSON_funcionario_{funcionario.Id}.json"))
            {
                streamWriter.WriteLine(json);
            }

        }

        public void ExportarXml(Funcionario funcionario)
        {
            var xml = new XmlSerializer(typeof(Funcionario));
            using (var streamWriter = new StreamWriter($"f:\\funcionario\\XML\\XML_funcionario_{funcionario.Id}.xml"))
            {
                xml.Serialize(streamWriter, funcionario);
            }
        }
    }
}
